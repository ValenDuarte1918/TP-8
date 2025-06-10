using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
using System.Data;

namespace Gestor
{
    public class GestorSucursales
    {
        public bool AgregarSucursal(string nombre, string descripcion, int provincia, string direccion) // cambie a bool para que devuelva verdadero o falso.
        {
            Sucursal sucursal = new Sucursal();

            sucursal.setNombre(nombre);
            sucursal.setDescripcion(descripcion);
            sucursal.setIdProvinciaSucursal(provincia);
            sucursal.setDireccion(direccion);

            //Aqui va la Comunicacion con Datos
           DaoSucursales dao = new DaoSucursales();
            int op = dao.InsertarSucursal(sucursal);
            if (op == 1)
                return true;
            else
                return false;
        }
        public bool EliminarSucursal(int idSucursal)
        {
            DaoSucursales dao = new DaoSucursales();
            Sucursal sucursal = new Sucursal();
            sucursal.setIdSucursal(idSucursal);
            
            int op = dao.EliminarSucursal(sucursal);
            if (op == 1)
                return true;
            else
                return false;
        }

         public DataTable ObtenerTabla()
        {
            DaoSucursales dao = new DaoSucursales();
            return dao.ListarSucursales();
        }

        public DataTable ListarSucursales(string idSucursal = null)
        {
            DaoSucursales dao = new DaoSucursales();
            return dao.ListarSucursales(idSucursal);
        }
    }
}
