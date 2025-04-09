using ProyectoFinal.Modelos;
using ProyectoFinal.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Forms.Registro
{
    public partial class FormRegistroPacienteAtendido : Form
    {
        public int UserId;
        public int IdCita;
        private List<Producto> productosSeleccionados = new List<Producto>();
        public FormRegistroPacienteAtendido(int userId, int idCita)
        {
            InitializeComponent();
            UserId = userId;
            IdCita = idCita;
            CargarProductos();
        }
        private void ActualizarListBox()
        {
            ProductosListBox.Items.Clear();

            foreach (var producto in productosSeleccionados)
            {
                ProductosListBox.Items.Add($"{producto.nombre} - Cantidad: {producto.cantidad}");
            }
        }

        private void CargarProductos()
        {
            string rutaProductos = Rutas.ObtenerRutaProductos();
            var productos = CRUD.LeerTxt(rutaProductos, Producto.ParseFromTxt);

            ProductosDgv.DataSource = productos.Select(p => new
            {
                Id = p.Id,
                Nombre = p.nombre,
                CantidadDisponible = p.cantidad
            }).ToList();
        }

        private void UsarProductoBtn_Click(object sender, EventArgs e)
        {
            if (ProductosDgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(CantidadTxt.Text, out int cantidadAUsar) || cantidadAUsar <= 0)
            {
                MessageBox.Show("Por favor, ingresa una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedRow = ProductosDgv.SelectedRows[0];
            int idProducto = Convert.ToInt32(selectedRow.Cells["Id"].Value);
            string nombreProducto = selectedRow.Cells["Nombre"].Value.ToString();
            int cantidadDisponible = Convert.ToInt32(selectedRow.Cells["CantidadDisponible"].Value);

            // Validar que la cantidad total no exceda el máximo disponible
            var existente = productosSeleccionados.FirstOrDefault(p => p.Id == idProducto);
            int cantidadTotal = (existente?.cantidad ?? 0) + cantidadAUsar;

            if (cantidadTotal > cantidadDisponible)
            {
                MessageBox.Show($"La cantidad total para el producto '{nombreProducto}' no puede exceder el stock disponible ({cantidadDisponible}).",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            var productoSeleccionado = new Producto
            {
                Id = idProducto,
                nombre = nombreProducto,
                cantidad = cantidadAUsar
            };

            // Validar el producto antes de agregarlo
            if (!productoSeleccionado.EsValido())
            {
                MessageBox.Show("El producto seleccionado no tiene un formato válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Añadir a la lista global de productos seleccionados
            if (existente != null)
            {
                existente.cantidad += productoSeleccionado.cantidad; // Sumar cantidades si ya existe
            }
            else
            {
                productosSeleccionados.Add(productoSeleccionado);
            }

            MessageBox.Show("Producto utilizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Actualizar el ListBox
            ActualizarListBox();

            // Recargar el DGV para reflejar los cambios
            CargarProductos();
        }
        private void ActualizarAlmacen(List<Producto> productosSeleccionados)
        {
            string rutaProductos = Rutas.ObtenerRutaProductos();
            var productos = CRUD.LeerTxt(rutaProductos, Producto.ParseFromTxt);

            foreach (var productoSeleccionado in productosSeleccionados)
            {
                var producto = productos.FirstOrDefault(p => p.Id == productoSeleccionado.Id);
                if (producto != null)
                {
                    producto.cantidad -= productoSeleccionado.cantidad;

                    if (producto.cantidad < 5)
                    {
                        MessageBox.Show($"El producto '{producto.nombre}' tiene menos de 5 unidades. Considera agregar inventario.",
                                        "Alerta de inventario bajo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    }
                }
            }

            // Guardar los cambios en el archivo
            CRUD.EscribirTxt(rutaProductos, productos);
        }
        private void RegistrarAuditoria(List<Producto> productosSeleccionados, int idUsuario)
        {
            string rutaAuditoria = Rutas.ObtenerRutaAuditoria();
            var auditoriasExistentes = CRUD.LeerTxt(rutaAuditoria, Auditoria.ParseFromTxt);

            var nuevosRegistros = new List<Auditoria>();

            foreach (var producto in productosSeleccionados)
            {
                int nuevoId = CRUD.GenerarNuevoId(rutaAuditoria);

                nuevosRegistros.Add(new Auditoria
                {
                    Id = nuevoId,
                    IdUsuario = idUsuario,
                    IdProducto = producto.Id,
                    CantidadMovida = -producto.cantidad,
                    Fecha = DateTime.Now
                });
            }

            auditoriasExistentes.AddRange(nuevosRegistros);
            CRUD.EscribirTxt(rutaAuditoria, auditoriasExistentes);
        }

        private void RegistrarHistorialBtn_Click(object sender, EventArgs e)
        {
            string diagnostico = DiagnosticoTxt.Text;
            string tratamiento = TratamientoTxt.Text;
            string observaciones = ObservacionesTxt.Text;
            string evolucion = EvolucionTxt.Text;

            if (string.IsNullOrWhiteSpace(diagnostico) || string.IsNullOrWhiteSpace(tratamiento))
            {
                MessageBox.Show("El diagnóstico y el tratamiento son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (productosSeleccionados.Count == 0)
            {
                MessageBox.Show("No se han utilizado productos para este historial clínico.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            RegistrarHistorialClinico(diagnostico, tratamiento, observaciones, evolucion, productosSeleccionados);

            // Marcar la cita como atendida
            MarcarCitaComoAtendida(IdCita);

            ActualizarAlmacen(productosSeleccionados);
            RegistrarAuditoria(productosSeleccionados, UserId);
            // Limpiar la lista de productos seleccionados después de registrar el historial
            productosSeleccionados.Clear();

            // Cerrar el formulario
            this.Close();
        }

        private void MarcarCitaComoAtendida(int idCita)
        {
            string rutaCitas = Rutas.ObtenerRutaCitas();
            var citas = CRUD.LeerTxt(rutaCitas, Citas.ParseFromTxt);

            var cita = citas.FirstOrDefault(c => c.Id == idCita);
            if (cita != null)
            {
                cita.estado = "atendido"; // Cambiar el estado de la cita
            }

            // Guardar los cambios en el archivo
            CRUD.EscribirTxt(rutaCitas, citas);
        }

        private void RegistrarHistorialClinico(string diagnostico, string tratamiento, string observaciones, string evolucion, List<Producto> productosUtilizados)
        {
            string rutaHistorial = Rutas.ObtenerRutaHistorialClinico();
            var historialesExistentes = CRUD.LeerTxt(rutaHistorial, HistorialClinico.ParseFromTxt);

            int nuevoId = CRUD.GenerarNuevoId(rutaHistorial);

            var nuevoHistorial = new HistorialClinico
            {
                Id = nuevoId,
                IdCita = IdCita,
                Diagnostico = diagnostico,
                Tratamiento = tratamiento,
                Observaciones = observaciones,
                Fecha = DateTime.Now,
                evolucion = evolucion,
                ProductosUtilizados = productosUtilizados
            };

            historialesExistentes.Add(nuevoHistorial);
            CRUD.EscribirTxt(rutaHistorial, historialesExistentes);

            MessageBox.Show("Historial clínico registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

