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
    public partial class RegistroUsuario : Form
    {
        //BRADLEY
        //private SqlConnection conexion = new SqlConnection();
        //DANIEL
        private SqlConnection conexion = new SqlConnection();
        private SqlCommand comando;
        String sql;
        public string[] nacionalidad = new string[2] { "Mexicano", "Extranjero"};
        public string[] estados = new string[32] { "Aguascalientes", "Baja California", "Baja California Sur", "Campeche", "Chiapas", "Chihuahua", "Ciudad de México","Coahuila", "Colima", "Durango", "Guanajuato", "Guerrero", "Hidalgo", "Jalisco", "Estado de México","Michoacán", "Morelos", "Nayarit", "Nuevo León", "Oaxaca", "Puebla", "Querétaro", "Quintana Roo", "San Luis Potosí", "Sinaloa", "Sonora", "Tabasco", "Tamaulipas", "Tlaxcala", "Veracruz", "Yucatán", "Zacatecas" };
        public string[] clave = new string[32] { "AS", "BC", "BS", "CC", "CS", "CH", "DF", "CL", "CM", "DG",  "GT", "GR", "HG", "JC", "MC", "MN", "MS", "NT", "NL", "OC", "PL", "QO", "QR", "SP", "SL", "SR", "TC", "TS", "TL", "VZ", "YN", "ZS" };
        private string CURP = "", sexo;
        private Boolean nacion = true;
        public RegistroUsuario()
        {
            InitializeComponent();
            llenar_naciones();
        }

        private void RegistroUsuario_Load(object sender, EventArgs e)
        {

        }
        public void llenar_naciones()
        {
            for (int i = 0; i < nacionalidad.Length; i++)
            {
                this.comboNacion_registro.Items.Add(this.nacionalidad[i]);
            }//Fin del for...
        }
        public void llenar_estados()
        {
            for (int i = 0; i < estados.Length; i++)
            {
                this.comboEstado_registro.Items.Add(this.estados[i]);
            }//Fin del for...
        }

        private void comboNacion_registro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboNacion_registro.SelectedIndex == 0)
            {
                this.comboEstado_registro.Enabled = true;
                llenar_estados();
            }
            else
            {
                this.comboEstado_registro.Items.Clear();
                this.comboEstado_registro.Enabled = false;
            }
        }

        private void btnRegistro_registro_Click(object sender, EventArgs e)
        {
            if (validarvacio())
            {
                obtener_curp(); 
            }           
        }

        private void rbtnMasculino_registro_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnMasculino_registro.Checked == true)
            {
                sexo = "H";
            } else
            {
                sexo = "M";
            }
        }

        public void obtener_curp()
        {
            //Primera letra del apellido paterno
            CURP += txtPaterno_registro.Text.ToUpper().Substring(0,1);
            //Primera vocal del apellido paterno
            for (int i = 1; i < txtPaterno_registro.Text.Length; i++)
            {
                String vocal = txtPaterno_registro.Text.ToUpper().Substring(i, 1);
                if (vocal.Equals("A") || vocal.Equals("E") || vocal.Equals("I") || vocal.Equals("O") || vocal.Equals("U"))
                {
                    CURP += vocal;
                    break;
                }
            }
            //Primera letra del apellido materno
            CURP += txtMaterno_registro.Text.ToUpper().Substring(0, 1);
            //Primera letra del nombre
            CURP += txtNombre_registro.Text.ToUpper().Substring(0, 1);
            //Año de nacimiento
            CURP += dateNacimiento_registro.Value.ToString("yy");
            //Mes de nacimiento
            CURP += dateNacimiento_registro.Value.ToString("MM");
            //Dia de nacimiento
            CURP += dateNacimiento_registro.Value.ToString("dd");
            //Sexo
            CURP += sexo;
            //Abreviatura estado
            if(this.comboEstado_registro.Enabled == false)
            {
                CURP += "NE";
                nacion = false;
            } else
            {
                CURP += clave[comboEstado_registro.SelectedIndex];
            }
            //Primera consonante del apellido paterno
            for (int i = 1; i < txtPaterno_registro.Text.Length; i++)
            {
                String consonante = txtPaterno_registro.Text.ToUpper().Substring(i, 1);
                if (consonante != "A" && consonante != "E" && consonante != "I" && consonante != "O" && consonante != "U")
                {
                    CURP += consonante;
                    MessageBox.Show("apelllido paterno" + txtPaterno_registro.Text + " - " + consonante);
                    break;
                }
            }
            //Primera consonante del apellido materno
            for (int i = 1; i < txtMaterno_registro.Text.Length; i++)
            {
                String consonante = txtMaterno_registro.Text.ToUpper().Substring(i, 1);
                if (consonante != "A" && consonante != "E" && consonante != "I" && consonante != "O" && consonante != "U")
                {
                    CURP += consonante;
                    MessageBox.Show("apelllido materno" + txtMaterno_registro.Text + " - " + consonante);
                    break;
                }
            }
            //Primera consonante del nombre
            for (int i = 1; i < txtNombre_registro.Text.Length; i++)
            {
                String consonante = txtNombre_registro.Text.ToUpper().Substring(i, 1);
                if (consonante != "A" && consonante != "E" && consonante != "I" && consonante != "O" && consonante != "U")
                {
                    CURP += consonante;
                    MessageBox.Show("nombre" + txtNombre_registro.Text + " - " + consonante);
                    break;
                }
            }
            CURP += "D1";
            MessageBox.Show(CURP);
        }

        public Boolean validarvacio()
        {
            Boolean validacion = true;
            string msg = "";

            if(txtNombre_registro.TextLength == 0)
            {
                msg = "Te hace falta colocar tu nombre";
                validacion = false;
            }
            else if (txtPaterno_registro.TextLength == 0)
            {
                msg = "Te hace falta colocar tu apellido paterno";
                validacion = false;
            }
            else if (txtMaterno_registro.TextLength == 0)
            {
                msg = "Te hace falta colocar tu apellido materno";
                validacion = false;
            }
            else if (rbtnMasculino_registro.Checked == false && rbtnFemenino_registro.Checked == false)
            {
                msg = "Te hace falta seleccionar tu sexo";
                validacion = false;
            }
            else if (dateNacimiento_registro.Checked == false)
            {
                msg = "Te hace falta colocar tu fecha de nacimiento";
                validacion = false;
            }
            else if (comboNacion_registro.SelectedIndex < 0)
            {
                msg = "Te hace falta seleccionar tu nacionalidad";
                validacion = false;
            }
            else if (comboEstado_registro.SelectedIndex < 0 || nacion == true)
            {
                msg = "Te hace falta seleccionar tu estado";
                validacion = false;
            }
            else if (txtCorreo_registro.TextLength == 0)
            {
                msg = "Te hace falta colocar tu correo electrónico";
                validacion = false;
            }
            if(validacion == false)
            {
                MessageBox.Show(msg);
            }
            return validacion;
        }
    }
}
