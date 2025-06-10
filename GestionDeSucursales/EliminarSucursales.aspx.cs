using Gestor;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Entidades;

namespace GestionDeSucursales
{
    public partial class EliminarSucursales : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            GestorSucursales gestorSuc = new GestorSucursales();
            DataTable table = gestorSuc.ListarSucursales(txtEliminar.Text);

            if (table.Rows.Count != 0)
            {
                string nombreSucursal = Convert.ToString(table.Rows[0][1]);
                Mostrar(txtEliminar.Text, nombreSucursal);
            }
            else
            {
                lblMensaje.Text = "El ID ingresado no corresponde a una sucursal registrada.";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                return;
            }
        }

        protected void Mostrar(string IdSucursal, string nombreSucursal)
        {            
            lblEstasSeguro.Visible = true;
            lblEstasSeguro.Text = "¿Estás seguro de que deseas eliminar la sucursal: " + nombreSucursal + "?";
            btnCancelar.Visible = true;
            btnAceptar.Visible = true;
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            GestorSucursales gestorSuc = new GestorSucursales();
            try
            {
                if (gestorSuc.EliminarSucursal(Convert.ToInt32(txtEliminar.Text)))
                {
                    lblMensaje.Text = $"Sucursal Nro. {txtEliminar.Text} fue eliminada correctamente.";
                }
                else
                {
                    lblMensaje.Text = "El ID ingresado no corresponde a una sucursal registrada";
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error al eliminar la sucursal: " + ex.Message;
            } 
            txtEliminar.Text = string.Empty; 
            lblEstasSeguro.Visible = false;
            btnCancelar.Visible = false;
            btnAceptar.Visible = false;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            txtEliminar.Text = string.Empty;
            lblEstasSeguro.Visible = false;
            btnCancelar.Visible = false;
            btnAceptar.Visible = false;
        }
    }
}