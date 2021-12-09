using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlantillaProyecto.Classes;
using PlantillaProyecto.Objects;

namespace PlantillaProyecto.views
{
    public partial class PanelUsuario : Form
    {
        PeticionSQL funciones = new PeticionSQL();
        Comprobante comprobante = new Comprobante();
        public PanelUsuario()
        {
            InitializeComponent();
        }

        private void panelRegistroUsuario_Load(object sender, EventArgs e)
        {
            llenar_datoslog(comprobante.usuarioLog);
        }

        private void comboNacion_registro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboNacion_registro.SelectedIndex == 0)
            {
                comboEstado_registro.Enabled = true;
                comboEstado_registro.DataSource = funciones.listaEstados();
            }
            else
            {
                comboEstado_registro.Items.Clear();
                comboEstado_registro.Enabled = false;
            }
        }

        private void btnRegistro_registro_Click(object sender, EventArgs e)
        {
            funciones.editarUsuario(comprobante.usuarioLog);
        }

        public void llenar_datoslog(Usuario log)
        {
            txt_Nombre.Text = log.Nombre();
            txt_apePaterno.Text = log.Ape_pat();
            txtMaterno_registro.Text = log.Ape_mat();
            if (log.Sexo.Equals("M"))
            {
                rbtnMasculino_registro.Checked = true;
            } else
            {
                rbtnFemenino_registro.Checked = true;
            }
            comboNacion_registro.SelectedIndex = int.Parse(log.Nacionalidad);
            comboEstado_registro.SelectedIndex = int.Parse(log.EstadoNacimiento);
            dateNacimiento_registro.Value = log.FechaNacimiento;
            txtCorreo_registro.Text = log.Correo;
        }
    }
}
