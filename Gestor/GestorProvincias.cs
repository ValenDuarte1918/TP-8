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
    public class GestorProvincias
    {
        public DataTable ObtenerProvincias()
        {
            DaoProvincias dao = new DaoProvincias();
            return dao.ListarProvincias();
        }
    }
}
