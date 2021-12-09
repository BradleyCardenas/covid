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
    public partial class PanelRegistroVacuna : Form
    {
        PeticionSQL funciones = new PeticionSQL();
        public PanelRegistroVacuna()
        {
            InitializeComponent();
        }

        private void PanelRegistroVacuna_Load(object sender, EventArgs e)
        {
            comboMarca_vacuna.DataSource = funciones.listaVacunas();
            comboDosis_vacuna.DataSource = funciones.listaDosis();
            
        }

        public bool hayCamposVacios() {
            bool hayCamposVacios = false;
            string text = "";

            foreach (Control control in Controls) {
                if (control.Text.Length == 0) {
                    text = "El campo " + control.Name +" está vacío";
                }
            }

            if (comboDosis_vacuna.SelectedIndex < 0){
                text = "El campo Dosis está vacío";
                hayCamposVacios = true;
            }
            else if (comboMarca_vacuna.SelectedIndex < 0) {
                text = "El campo Marca está vacío";
                hayCamposVacios = true;
            }

            if (hayCamposVacios) {
                MessageBox.Show(text);
            }

            return hayCamposVacios;
        }
    }
}
