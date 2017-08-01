using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGit.View
{
    public partial class Reproduccion : Form
    {
        string direccion;
        public Reproduccion(string direccion)
        {
            InitializeComponent();
            this.direccion = direccion;
        }

        private void Reproduccion_Load(object sender, EventArgs e)
        {
            //"C:\Users\kjc j k\Desktop\Peliculas\
            axWindowsMediaPlayer1.URL = (direccion);
        }
    }
}
