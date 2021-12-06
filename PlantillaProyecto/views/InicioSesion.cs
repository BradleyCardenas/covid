using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlantillaProyecto.views;

namespace PlantillaProyecto
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {
           
        }

        private void btnIngresar_Click(object sender, EventArgs e){
            Comprobante comprobante = new Comprobante();
            this.Hide();
            comprobante.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e){
            Comprobante comprobante = new Comprobante();
            this.Hide();
            comprobante.Show();
        }
    }
}
