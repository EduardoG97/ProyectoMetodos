using ProyectoGit.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoGit.Clases;

namespace ProyectoGit
{
    public partial class RegistroPelicula : Form, IPelicula
    {
        public RegistroPelicula()
        {
            InitializeComponent();
        }
        string direccion;
        string foto;
        public Pelicula ObtenerPelicula()
        {
            Pelicula p = new Pelicula();
            p.Nombre=nombre.Text;
            p.Precio = double.Parse(precio.Text);
            p.Fecha_Publicacion = fecha.Text;
            p.Portada =foto;
            p.Descripccion = descripccion.Text;
            p.Direccion =direccion;
            return p;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C: \Users\kjc j k\Desktop\Peliculas";
            openFileDialog1.Filter = "Video (.wmv)|*.wmv|Music (.mp3)|*.mp3|ALL Files (*.*)|*.*";
            //openFileDialog1.ShowDialog(); //Open File dialog box
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                direccion = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pelicula p = new Pelicula();
            p.RegistrararPelicula(ObtenerPelicula());
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                    item.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog2.InitialDirectory = @"C: \Users\kjc j k\Desktop\Peliculas";
            openFileDialog2.Filter = "Video (.wmv)|*.wmv|Music (.mp3)|*.mp3|ALL Files (*.*)|*.*";
            //openFileDialog2.ShowDialog(); //Open File dialog box
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                foto = openFileDialog2.FileName;
                portada.Image = Image.FromFile(openFileDialog2.FileName);
            }

        }
    }
}
