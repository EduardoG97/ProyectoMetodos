using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoGit.View;
using ProyectoGit.Clases;

namespace ProyectoGit.View
{
    public partial class ListaPelicula : Form
    {
        public ListaPelicula()
        {
            InitializeComponent();
        }

        private void ListaPelicula_Load(object sender, EventArgs e)
        {
            Pelicula p = new Pelicula();
            dataGridView1.DataSource=p.ListarPeliculas();
            dataGridView1.Columns[0].Visible = false;
            //dataGridView1.Columns[4].Visible = false;
            //dataGridView1.Columns[6].Visible = false;ssss
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int pos = dataGridView1.CurrentRow.Index;
            Reproduccion re = new Reproduccion(dataGridView1[7,pos].Value.ToString());
            re.Show();
        }
    }
}
