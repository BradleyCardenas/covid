using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PlantillaProyecto.Classes;


namespace PlantillaProyecto
{
    public partial class PanelVacuna : Form
    {
        PeticionSQL funciones = new PeticionSQL();
        public PanelVacuna()
        {
            InitializeComponent();
        }

        private void RegistroVacuna_Load(object sender, EventArgs e)
        {
            comboMarca_vacuna.DataSource = funciones.listaVacunas();
            comboDosis_vacuna.DataSource = funciones.listaDosis();
            comboEstado_vacuna.DataSource = funciones.listaEstados();
        }
        private void comboEstado_vacuna_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboMunicipio_vacuna.DataSource = funciones.listaMunicipios(comboEstado_vacuna.SelectedIndex - 1);
        }
        public Boolean validar_vacios()
        {
            Boolean validar = true;
            string msg = "";

            if (txtTel1_vacuna.TextLength < 10)
            {
                msg = "Te hace falta colocar un primer teléfono";
                validar = false;
            }
            else if (txtTel2_vacuna.TextLength < 10)
            {
                msg = "Te hace falta colocar un segundo teléfono";
                validar = false;
            }
            else if (comboMarca_vacuna.SelectedIndex < 0)
            {
                msg = "Te hace falta seleccionar una marca de vacuna";
                validar = false;
            }
            else if (comboDosis_vacuna.SelectedIndex < 0)
            {
                msg = "Te hace falta seleccionar la dosis de la vacuna";
                validar = false;
            }
            else if (txtCalle_vacuna.TextLength == 0)
            {
                msg = "Te hace falta colocar la calle de tu domicilio";
                validar = false;
            }
            else if (txtExterior_vacuna.TextLength == 0)
            {
                msg = "Te hace falta colocar el número exterior de tu domicilio";
                validar = false;
            }
            else if (txtInterior_vacuna.TextLength == 0)
            {
                msg = "Te hace falta colocar el número interior de tu domicilio, en caso de no tener digita 0";
                validar = false;
            }
            else if (comboEstado_vacuna.SelectedIndex < 0)
            {
                msg = "Te hace falta seleccionar el estado de tu domicilio";
                validar = false;
            }
            else if (comboMunicipio_vacuna.SelectedIndex < 0)
            {
                msg = "Te hace falta seleccionar el municipio de tu domicilio";
                validar = false;
            }
            else if (txtColonia_vacuna.TextLength == 0)
            {
                msg = "Te hace falta colocar la colonia de tu domicilio";
                validar = false;
            }
            else if (txtCP_vacuna.TextLength == 0)
            {
                msg = "Te hace falta colocar el Código Postal de tu domicilio";
                validar = false;
            }
            if (validar == false)
            {
                MessageBox.Show(msg);
            }
            return validar;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (validar_vacios())
            {

            }
        }
    }
}
