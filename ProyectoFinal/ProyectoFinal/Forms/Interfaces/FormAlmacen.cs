using ProyectoFinal.Forms.Registro;
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
    public partial class FormAlmacen : Form
    {
        public int UserId;

        public FormAlmacen(int userid)
        {
            InitializeComponent();
            CargarDatosAlmacen();
            this.UserId = userid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CargarDatosAlmacen()
        {
            string rutaProductos = Rutas.ObtenerRutaProductos();

            var productos = CRUD.LeerTxt(rutaProductos, Producto.ParseFromTxt);

            var datosProductos = productos.Select(p => new
            {
                Id = p.Id,
                Producto = p.nombre,
                Cantidad = p.cantidad
            }).ToList();

            AlmacenDVG.DataSource = datosProductos;
        }

        private void AggProductoBtn_Click(object sender, EventArgs e)
        {
            var formRegistroProducto = new FormRegistroProducto();
            formRegistroProducto.FormClosed += (s, args) =>
            {
                this.Show();
                CargarDatosAlmacen();
            };
            this.Hide();
            formRegistroProducto.Show();
        }

        private void EditarAlmacenBtn_Click(object sender, EventArgs e)
        {
            var formEdicionDeAlmacen = new FormAlmacen(UserId);
            formEdicionDeAlmacen.FormClosed += (s, args) =>
            {
                this.Show();
                CargarDatosAlmacen();
            };
            this.Hide();
            formEdicionDeAlmacen.Show();
        }

        private void HistorialBtn_Click(object sender, EventArgs e)
        {
            var formAuditoria = new FormHistorialAuditoria();
            formAuditoria.FormClosed += (s, args) =>
            {
                this.Show();
                CargarDatosAlmacen();
            };
            this.Hide();
            formAuditoria.Show();
        }

    }
}
