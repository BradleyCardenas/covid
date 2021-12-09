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
    public partial class PanelRegistroDomicilio : Form
    {
        PeticionSQL funciones = new PeticionSQL();
        public PanelRegistroDomicilio(){
            InitializeComponent();
        }


        private void PanelRegistroDomicilio_Load(object sender, EventArgs e){
            comboEstado_vacuna.DataSource = funciones.listaEstados();
        }

        private void comboMunicipio_vacuna_SelectedIndexChanged(object sender, EventArgs e){

        }

        private void comboEstado_vacuna_SelectedIndexChanged(object sender, EventArgs e){
            comboMunicipio_vacuna.DataSource = funciones.listaMunicipios(comboEstado_vacuna.SelectedIndex + 1);
        }

        public bool hayCamposVacios() {
            bool hayCamposVacios = false;
            string text = "";

            foreach (Control control in this.Controls) {
                if (control.Text.Length == 0) {
                    text = "El campo " + control.Name +" está vacío";
                    hayCamposVacios = true;
                }
            }

            if (comboEstado_vacuna.SelectedIndex < 0){
                text = "El campo Estado está vacío";
                hayCamposVacios = true;
            }
            else if (comboMunicipio_vacuna.SelectedIndex < 0) {
                text = "El campo Municipio está vacío";
                hayCamposVacios = true;
            }

            if (hayCamposVacios) {
                MessageBox.Show(text);
            }
            return hayCamposVacios;
        }
    }
}
