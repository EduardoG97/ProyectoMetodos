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
    public partial class Login : Form, IPelicula
    {
        public Login()
        {
            InitializeComponent();
        }

        public Pelicula ObtenerPelicula()
        {
            return ObtenerPelicula();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
