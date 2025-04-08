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
    public partial class FormHistorialAuditoria : Form
    {
        public FormHistorialAuditoria()
        {
            InitializeComponent();
            CargarAuditoria();
        }

        private void VolverBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CargarAuditoria()
        {
            // Ruta de los archivos
            var rutaAuditoria = Rutas.ObtenerRutaAuditoria();
            var rutaUsuarios = Rutas.ObtenerRutaUsers();
            var rutaProductos = Rutas.ObtenerRutaProductos();

            // Leer los datos
            var auditorias = CRUD.LeerTxt(rutaAuditoria, Auditoria.ParseFromTxt);
            var usuarios = CRUD.LeerTxt(rutaUsuarios, Users.ParseFromTxt);
            var productos = CRUD.LeerTxt(rutaProductos, Producto.ParseFromTxt);

            // Enriquecer los datos de auditoría
            var datosAuditoria = auditorias.Select(a => new
            {
                Username = usuarios.FirstOrDefault(u => u.Id == a.IdUsuario)?.username ?? "Admin",
                Producto = productos.FirstOrDefault(p => p.Id == a.IdProducto)?.nombre ?? "Desconocido",
                CantidadMovida = a.CantidadMovida,
                Fecha = a.Fecha
            }).ToList();

            // Asignar los datos al DataGridView
            HistorialDGV.DataSource = datosAuditoria;
        }
    }
}
