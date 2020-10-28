using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DataAccess.Repository
{
    // 6. Se agrega carpeta Repository dentro de Infra.DataAccess para implementar las Interfaces
    public class ConnectionSQL
    {
        protected SqlConnection Conexion = new SqlConnection("Server=(LocalDB)\\MSSQLLocalDB;Database=Practica_Patrones;User=sa;Pwd=Unemamad249");
    }
}
