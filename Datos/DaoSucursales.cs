using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
using System.Data.SqlClient;
using System;

namespace Datos
{
    public class DaoSucursales
    {

        AccsesoDatos ds = new AccsesoDatos();

        public Sucursal getSucursal(int IdSucursal)
        {
            Sucursal sucursal = new Sucursal();

            SqlParameter parametros = new SqlParameter("@IdSucursal", IdSucursal);

            DataTable tabla = ds.EjecutarConsultaDataAdapter("SELECT * FROM Sucursal WHERE Id_Sucursal = @IdSucursal", parametros);

            sucursal.setIdSucursal(Convert.ToInt32(tabla.Rows[0][0].ToString()));
            sucursal.setIdProvinciaSucursal(Convert.ToInt32(tabla.Rows[0][1]));
            sucursal.setNombre(tabla.Rows[0][2].ToString());
            return sucursal;
        }
        public int EliminarSucursal(Sucursal sucursal)
        {
            string query = "DELETE FROM Sucursal WHERE Id_Sucursal = @IdSucursal";
            SqlParameter[] parametros = new SqlParameter[] { new SqlParameter("@IdSucursal", sucursal.getIdSucursal()) };
            return ds.EjecutarConsulta(query, parametros);
        }

        public int InsertarSucursal(Sucursal sucursal)
        {
            string query = "INSERT INTO Sucursal (Id_ProvinciaSucursal, NombreSucursal, DescripcionSucursal, DireccionSucursal) " +
                           "VALUES (@IdProvincia, @NombreSucursal, @DescripcionSucursal, @DireccionSucursal)";
            SqlParameter[] parametros = new SqlParameter[]
            {
        new SqlParameter("@IdProvincia", sucursal.getIdProvinciaSucursal()),
        new SqlParameter("@NombreSucursal", sucursal.getNombre()),
        new SqlParameter("@DescripcionSucursal", sucursal.getDescripcion()),
        new SqlParameter("@DireccionSucursal", sucursal.getDireccion())
            };

            return ds.EjecutarConsulta(query, parametros);
        }
        public DataTable ListarSucursales(string IdSucursal = null)
        {
            string query = "SELECT Id_Sucursal, NombreSucursal, DescripcionSucursal, DescripcionProvincia, DireccionSucursal " +
                "FROM Sucursal " +
                "INNER JOIN Provincia " +
                "ON Sucursal.Id_ProvinciaSucursal = Provincia.Id_Provincia";

            SqlParameter parametro = new SqlParameter();

            if (IdSucursal != null)
            {
                query += " WHERE Id_Sucursal = @IdSucursal";
                parametro = new SqlParameter("@IdSucursal", IdSucursal);
            }
            else
            {
                parametro = null;
            }

            return ds.EjecutarConsultaDataAdapter(query, parametro);
        }
    }
}
