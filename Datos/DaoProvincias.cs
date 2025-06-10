using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
using System.Data.SqlClient;
using System;

namespace Datos
{
    public class DaoProvincias
    {
        AccsesoDatos ds = new AccsesoDatos();
        public DataTable ListarProvincias()
        {
            string query = "SELECT Id_Provincia, DescripcionProvincia FROM Provincia";
            return ds.EjecutarConsultaDataAdapter(query);
        }
    }
}

