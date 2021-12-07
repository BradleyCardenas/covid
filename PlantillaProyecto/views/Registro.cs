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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void abrirForm(object formulario)
        {
            if (pnl_registro.Controls.Count > 0)
                pnl_registro.Controls.RemoveAt(0);

            Form fr = formulario as Form;
            fr.TopLevel = false;
            fr.Dock = DockStyle.Fill;
            this.pnl_registro.Controls.Add(fr);
            this.pnl_registro.Tag = fr;
            fr.Show();
        }

        int estado = 0;

        private void Registro_Load(object sender, EventArgs e)
        {
            abrirForm(new PanelRegistroUsuario());
        }

        private void btn_cancelar_Click(object sender, EventArgs e){
            cambiarEstadoAnterior();

        }

        private void btn_siguiente_Click(object sender, EventArgs e){
            cambiarEstadoSiguiente();
        }

        private void cambiarEstadoSiguiente() {
            switch (estado) {
                case 0:
                    estado++;
                    abrirForm(new PanelRegistroDomicilio());
                    btn_cancelar.Text = "Anterior";
                    break;
                case 1:
                    estado++;
                    abrirForm(new PanelRegistroVacuna());
                    btn_siguiente.Text = "Guardar";
                    break;
                case 2:
                    Comprobante comprobante = new Comprobante();
                    this.Hide();
                    comprobante.Show();
                    break;

            }
        }

        private void cambiarEstadoAnterior() {
            switch (estado) {
                case 0:
                    InicioSesion inicioSesion = new InicioSesion();
                    this.Hide();
                    inicioSesion.Show();
                    break;
                case 1:
                    estado--;
                    abrirForm(new PanelRegistroUsuario());
                    btn_cancelar.Text = "Cancelar";
                    break;
                case 2:
                    estado--;
                    abrirForm(new PanelRegistroDomicilio());
                    btn_siguiente.Text = "Siguiente";
                    break;
            }
        }

    }
}
