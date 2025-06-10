using Gestor;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GestionDeSucursales
{
    public partial class ListadoSucursales : System.Web.UI.Page
    {
        private GestorSucursales gestor = new GestorSucursales();
        protected void Page_Load(object sender, EventArgs e)
        {

            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            if (!IsPostBack)
            {
            llenarTabla();
            }
        }
        // Cree el metodo llenarTabla para que se llene la tabla al cargar la pagina.
        private void llenarTabla()
        {
            DataTable tabla = gestor.ObtenerTabla();
            gvSucursales.DataSource = tabla;
            gvSucursales.DataBind();
        }
        protected void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            llenarTabla();
            txtbBuscarSucursales.Text = string.Empty;
            lblNoResultados.Text = string.Empty;
        }
        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            string idSucursal = txtbBuscarSucursales.Text.Trim();
            DataTable tabla = null;

            if (!string.IsNullOrEmpty(idSucursal) && int.TryParse(idSucursal, out int id))
            {
                tabla = gestor.ListarSucursales(id.ToString());

                if (tabla.Rows.Count > 0)
                {
                    lblNoResultados.Text = string.Empty;
                }
                else
                {
                    lblNoResultados.Text = "No se pudo encontrar la sucursal.";
                }
            }

            if (tabla != null)
            {
                gvSucursales.DataSource = tabla;
                gvSucursales.DataBind();
            }

        }
    }
}