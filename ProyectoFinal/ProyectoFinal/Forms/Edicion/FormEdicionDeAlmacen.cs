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

namespace ProyectoFinal.Forms.Interfaces
{
    public partial class FormAuditoria : Form
    {
        public int UserId;
        private string rutaProductos = Rutas.ObtenerRutaProductos();
        private int productoSeleccionadoId;

        public FormAuditoria(int userId)
        {
            InitializeComponent();
            CargarDatos();
            this.UserId = userId;
        }

        private void CargarDatos()
        {
            var productos = CRUD.LeerTxt(rutaProductos, Producto.ParseFromTxt);

            var datosProductos = productos.Select(p => new
            {
                Id = p.Id,
                Producto = p.nombre,
                Cantidad = p.cantidad
            }).ToList();

            EdicionDGV.DataSource = datosProductos;
        }

        private void EdicionDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var filaSeleccionada = EdicionDGV.Rows[e.RowIndex];
                productoSeleccionadoId = (int)filaSeleccionada.Cells["Id"].Value;
                NombreTxt.Text = filaSeleccionada.Cells["Producto"].Value.ToString();
                CantidadTxt.Text = filaSeleccionada.Cells["Cantidad"].Value.ToString();
            }
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NombreTxt.Text) || string.IsNullOrWhiteSpace(CantidadTxt.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(CantidadTxt.Text, out int nuevaCantidad) || nuevaCantidad < 0)
            {
                MessageBox.Show("La cantidad debe ser un número no negativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var productos = CRUD.LeerTxt(rutaProductos, Producto.ParseFromTxt);

            var producto = productos.FirstOrDefault(p => p.Id == productoSeleccionadoId);
            if (producto != null)
            {
                int diferencia = nuevaCantidad - producto.cantidad;

                // Actualizar el producto
                producto.nombre = NombreTxt.Text;
                producto.cantidad = nuevaCantidad;
                CRUD.EscribirTxt(rutaProductos, productos);

                // Registrar la auditoría
                var rutaAuditoria = Rutas.ObtenerRutaAuditoria(); 
                var auditorias = CRUD.LeerTxt(rutaAuditoria, Auditoria.ParseFromTxt);

                var nuevaAuditoria = new Auditoria
                {
                    Id = auditorias.Any() ? auditorias.Max(a => a.Id) + 1 : 1,
                    IdUsuario = this.UserId,
                    IdProducto = producto.Id,
                    CantidadMovida = diferencia,
                    Fecha = DateTime.Now
                };

                auditorias.Add(nuevaAuditoria);
                CRUD.EscribirTxt(rutaAuditoria, auditorias);

                MessageBox.Show("Producto actualizado y auditoría registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos();
            }
            else
            {
                MessageBox.Show("No se encontró el producto seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VolverBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
