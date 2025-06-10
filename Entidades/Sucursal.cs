using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sucursal
    {
        private int IdSucursal;
        private int IdProvinciaSucursal;
        private string NombreSucursal;
        private string Descripcion;
        private string Direccion;
        // Faltan mas atributos

        public int getIdSucursal()
        {
            return IdSucursal;
        }
        public void setIdSucursal(int idSucursal)
        {
            IdSucursal = idSucursal;
        }
        public int getIdProvinciaSucursal()
        {
            return IdProvinciaSucursal;
        }
        public void setIdProvinciaSucursal(int idProvinciaSucursal)
        {
            IdProvinciaSucursal = idProvinciaSucursal;
        }
        public string getNombre()
        {
            return NombreSucursal;
        }
        public void setNombre(string nombre)
        {
            NombreSucursal = nombre;
        }
        public string getDescripcion()
        {
            return Descripcion;
        }
        public void setDescripcion(string descripcion)
        {
            Descripcion = descripcion;
        }

        public string getDireccion()
        {
            return Direccion;
        }

        public void setDireccion(string direccion)
        {
            Direccion = direccion;
        }
    }
}
