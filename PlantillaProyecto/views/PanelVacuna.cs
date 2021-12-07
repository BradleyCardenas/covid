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

namespace PlantillaProyecto
{
    public partial class PanelVacuna : Form
    {
        //BRADLEY
        //private SqlConnection conexion = new SqlConnection();
        //DANIEL
        private SqlConnection conexion = new SqlConnection();
        private SqlCommand comando;
        String sql;
        public string[] estado = new string[1] {"YUCATÁN"};
        public string[] municipios = new string[106] { "ABALÁ", "ACANCEH", "AKIL", "BACA", "BOKOBÁ", "BUCTZOTZ", "CACALCHÉN", "CALOTMUL", "CANSAHCAB", "CANTAMAYEC", "CELESTÚN", "CENOTILLO", "CONKAL", "CUNCUNUL", "CUZAMÁ", "CHACSINKÍN", "CHANKOM", "CHAPAB", "CHEMAX", "CHICXULUB PUEBLO", "CHICHIMILÁ", "CHIKINDZONOT", "CHOCHOLÁ", "CHUMAYEL", "DZÁN", "DZEMUL", "DZIDZANTÚN", "DZILAM DE BRAVO", "DZILAM GONZÁLEZ", "DZITÁS", "DZONCAUICH", "ESPITA", "HALACHÓ", "HOCABÁ", "HOCTÚN", "HOMÚN", "HUHÍ", "HUNUCMÁ", "IXIL", "IZAMAL", "KANASÍN", "KANTUNIL", "KAUA", "KINCHIL", "KOPOMÁ", "MAMA", "MANÍ", "MAXCANÚ", "MAYAPÁN", "MÉRIDA", "MOCOCHÁ", "MOTUL", "MUNA", "MUXUPIP", "OPICHÉN", "OXKUTZKAB", "PANABÁ", "PETO", "PROGRESO", "QUINTANA ROO", "RÍO LAGARTOS", "SACALUM", "SAMAHIL", "SANAHCAT", "SAN FELIPE", "SANTA ELENA", "SEYÉ", "SINANCHÉ", "SOTUTA", "SUCILÁ", "SUDZAL", "SUMA", "TAHDZIÚ", "TAHMEK", "TEABO", "TECOH", "TEKAL DE VENEGAS", "TEKANTÓ", "TEKAX", "TEKIT", "TEKOM", "TELCHAC PUEBLO", "TELCHAC PUERTO", "TEMAX", "TEMOZÓN", "TEPAKÁN", "TETIZ", "TEYA", "TICUL", "TIMUCUY", "TINUM", "TIXCACALCUPUL", "TIXKOKOB", "TIXMEHUAC", "TIXPÉHUAL", "TIZIMÍN", "TUNKÁS", "TZUCACAB", "UAYMA", "UCÚ", "UMÁN", "VALLADOLID", "XOCCHEL", "YAXCABÁ", "YAXKUKUL", "YOBAÍN"};
        public string[] marcas = new string[6] {"Pfizer", "Astrazeneca", "Sputnik V", "Moderna", "Sinovac", "Cansino"};
        public string[] dosis = new string[4] {"Primera", "Segunda", "Tercera", "Única"};
        public PanelVacuna()
        {
            InitializeComponent();
            llenar_estado();
            llenar_dosis();
            llenar_marcas();
            comboMunicipio_vacuna.Enabled = false;
        }

        private void RegistroVacuna_Load(object sender, EventArgs e)
        {

        }
        public void llenar_estado()
        {
            for (int i = 0; i < estado.Length; i++)
            {
                this.comboEstado_vacuna.Items.Add(this.estado[i]);
            }//Fin del for...
        }
        public void llenar_municipios()
        {
            for (int i = 0; i < municipios.Length; i++)
            {
                this.comboMunicipio_vacuna.Items.Add(this.municipios[i]);
            }//Fin del for...
        }
        public void llenar_marcas()
        {
            for (int i = 0; i < marcas.Length; i++)
            {
                this.comboMarca_vacuna.Items.Add(this.marcas[i]);
            }//Fin del for...
        }
        public void llenar_dosis()
        {
            for (int i = 0; i < dosis.Length; i++)
            {
                this.comboDosis_vacuna.Items.Add(this.dosis[i]);
            }//Fin del for...
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

        private void comboEstado_vacuna_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboMunicipio_vacuna.Enabled = true;
            llenar_municipios();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (validar_vacios())
            {

            }
        }
    }
}
