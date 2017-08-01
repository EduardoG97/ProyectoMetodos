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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListaPelicula l = new ListaPelicula();
            l.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistroPelicula r = new RegistroPelicula();
            r.Show();
        }
    }
}
