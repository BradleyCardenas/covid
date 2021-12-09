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

namespace PlantillaProyecto.views
{
    public partial class PanelRegistroUsuario : Form
    {
        PeticionSQL funciones = new PeticionSQL();
        public PanelRegistroUsuario()
        {
            InitializeComponent();
        }

        private void PanelRegistroUsuario_Load(object sender, EventArgs e)
        {
            comboEstado_registro.DataSource = funciones.listaEstados();
            rbtnMasculino_registro.Checked = true;
        }

        public bool hayCamposVacios() {
            string text = "";
            bool hayCamposVacios = false;

            foreach (Control control in Controls) {
                if (control.Text.Length == 0) {
                    text = "El campo " + control.Name + " está vacío";
                    hayCamposVacios = true;
                }
            }

            if (comboNacion_registro.SelectedIndex < 0)
            {
                text = "El campo Nacionalidad está vacío";
                hayCamposVacios = true;
            }
            else if(comboEstado_registro.SelectedIndex < 0){
                text = "El campo Estado está vacío";
                hayCamposVacios = true;
            }

            if (hayCamposVacios) {
                MessageBox.Show(text);
            }

            return hayCamposVacios;
        }

        public char obtenerSexo() { 
            Char sexo;

            if (rbtnMasculino_registro.Checked){
                sexo = 'M';
            }
            else {
                sexo = 'F';
            }
            return sexo;
        }

    }
}
