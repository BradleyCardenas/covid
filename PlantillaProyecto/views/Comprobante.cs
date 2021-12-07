using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlantillaProyecto.views
{
    public partial class Comprobante : Form
    {
        public Comprobante()
        {
            InitializeComponent();
        }

        private void abrirForm(object formulario)
        {
            if (pnl_principal.Controls.Count > 0)
                pnl_principal.Controls.RemoveAt(0);

            Form fr = formulario as Form;
            fr.TopLevel = false;
            fr.Dock = DockStyle.Fill;
            this.pnl_principal.Controls.Add(fr);
            this.pnl_principal.Tag = fr;
            fr.Show();
        }

        private void Comprobante_Load(object sender, EventArgs e){
            abrirForm(new PanelInicio());
        }

        private void btn_salir_Click(object sender, EventArgs e){
            InicioSesion fr = new InicioSesion();
            fr.Show();
            this.Close();
        }

        private void btn_registroUsuario_Click(object sender, EventArgs e){
            abrirForm(new PanelUsuario());
        }

        private void btn_registrVacuna_Click(object sender, EventArgs e)
        {
            abrirForm(new PanelVacuna());
        }

        private void btn_consultaInformacion_Click(object sender, EventArgs e){
            abrirForm(new PanelConsultaInformacion());
        }

        private void btn_comprobante_Click(object sender, EventArgs e)
        {
            abrirForm(new PanelComprobante());
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            abrirForm(new PanelInicio());
        }
    }
}
