using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGit.Clases
{
    public class Conexion
    {
        public SqlConnection Conectar { get; set; }
        public string Cadena { get; set; }
        public SqlConnection EstablecerConexion()
        {
            Cadena = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
            Conectar = new SqlConnection(Cadena);
            Conectar.Open();
            return Conectar;

        }
    }
}
