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
    public partial class FormRegistroProducto : Form
    {
        public FormRegistroProducto()
        {
            InitializeComponent();
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            // Rutas
            string rutaProductos = Rutas.ObtenerRutaProductos();

            // Validar cantidad
            if (!int.TryParse(CantidadTxt.Text, out int cantidad) || cantidad < 0)
            {
                MessageBox.Show("La cantidad debe ser un número no negativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Leer productos existentes
            var productos = CRUD.LeerTxt(rutaProductos, Producto.ParseFromTxt);

            // Validar nombre del producto
            if (productos.Any(p => p.nombre.Equals(ProductoTxt.Text, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Ya existe un producto con el mismo nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Generar nuevo ID
            int nuevoIdProducto = CRUD.GenerarNuevoId(rutaProductos);

            // Crear nuevo producto
            var nuevoProducto = new Producto
            {
                Id = nuevoIdProducto,
                nombre = ProductoTxt.Text,
                cantidad = cantidad
            };
            // Guardar nuevo producto y nuevo objeto en almacen
            CRUD.AgregarRegistro(rutaProductos, nuevoProducto);

            MessageBox.Show("Producto registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
