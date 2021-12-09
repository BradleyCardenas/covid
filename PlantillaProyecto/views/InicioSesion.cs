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
using PlantillaProyecto.Classes;
using PlantillaProyecto.Classes.Objects;
using PlantillaProyecto.Objects;

namespace PlantillaProyecto
{
    public partial class InicioSesion : Form
    {
        PeticionSQL funciones = new PeticionSQL();
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {
           
        }

        private void btnIngresar_Click(object sender, EventArgs e){

            Usuario usuario = funciones.traerUsuario(txtCURP_login.Text, txtCorreo_login.Text);
            Vacuna vacuna = funciones.traerVacuna(usuario.Id);

            if (usuario != null)
            {
                Comprobante comprobante = new Comprobante();

                this.Hide();
                comprobante.Show();
                comprobante.usuarioLog = usuario;
                comprobante.vacunaLog = vacuna;
            } else
            {
                MessageBox.Show("El usuario o contraseña son incorrectos");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e){
            Registro registro = new Registro();
            this.Hide();
            registro.Show();
        }
    }
}
