using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGit.Clases
{
    public class Pelicula
    {
        public String Nombre { get; set; }
        public int Precio { get; set; }
        public DateTime Fecha_Publicacion { get; set; }
        public string Portada { get; set; }
        public string Descripccion { get; set; }
        public String Calidad { get; set; }
        public void RegistrararPelicula(Pelicula pelicula)
        {

        }
        public DataTable ListarPeliculas()
        {
            DataTable pelicula = new DataTable();
            return pelicula;
        }
    }
}
