using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGit.Clases
{
    public class Pelicula
    {
        public String Nombre { get; set; }
        public double Precio { get; set; }
        public string Fecha_Publicacion { get; set; }
        public string Portada { get; set; }
        public string Descripccion { get; set; }
        public int Calidad { get; set; }
        public string Direccion { get; set; }
        public Conexion conectar { get; set; }
        public void RegistrararPelicula(Pelicula pelicula)
        {
            conectar = new Conexion();
            using (conectar.EstablecerConexion())
            {
                string qry = "INSERT tblPelicula VALUES(@Nombre,@Precio,@Fecha,@Portada,@Descripccion,@Calidad,@Direccion)";
                SqlCommand comando = new SqlCommand(qry,conectar.EstablecerConexion());
                comando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value=pelicula.Nombre;
                comando.Parameters.Add("@Precio", SqlDbType.Money).Value = pelicula.Precio;
                comando.Parameters.Add("@Fecha", SqlDbType.Date).Value = pelicula.Fecha_Publicacion;
                comando.Parameters.Add("@Portada", SqlDbType.VarChar).Value = pelicula.Portada;
                comando.Parameters.Add("@Descripccion", SqlDbType.VarChar).Value = pelicula.Descripccion;
                comando.Parameters.Add("@Calidad", SqlDbType.Int).Value = pelicula.Calidad;
                comando.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = pelicula.Direccion;
                int x=comando.ExecuteNonQuery();
                if (x > 0)
                    MessageBox.Show("Pelicula Registrada Correctamente");
            }
        }
        public DataTable ListarPeliculas()
        {
            conectar = new Conexion();
            DataTable pelicula = new DataTable();
            using (conectar.EstablecerConexion())
            {
                SqlCommand comando = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblPelicula",conectar.EstablecerConexion());
                da.Fill(pelicula);
            }
            return pelicula;
        }
        public void ReproducirPelicula()
        {

        }
    }
}
