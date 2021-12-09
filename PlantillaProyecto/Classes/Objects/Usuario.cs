using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlantillaProyecto.Objects
{
    class Usuario{
        int id;
        string curp;
        string correo;
        string nombre;
        string ape_pat;
        string ape_mat;
        char sexo;
        DateTime fechaNacimiento;
        string nacionalidad;
        string estadoNacimiento;
        string contacto;
        string direccion;
        string colonia;
        string codPostal;
        string municipio;
        string estadoDomicilio;

        public Usuario() { }
        
        public int Id { get => id; set => id = value; }
        public string Curp { get => curp; set => curp = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Ape_pat { get => ape_pat; set => ape_pat = value; }
        public string Ape_mat { get => ape_mat; set => ape_mat = value; }
        public char Sexo { get => sexo; set => sexo = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        public string EstadoNacimiento { get => estadoNacimiento; set => estadoNacimiento = value; }
        public string Contacto { get => contacto; set => contacto = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Colonia { get => colonia; set => colonia = value; }
        public string CodPostal { get => codPostal; set => codPostal = value; }
        public string Municipio { get => municipio; set => municipio = value; }
        public string EstadoDomicilio { get => estadoDomicilio; set => estadoDomicilio = value; }


       private string generateCurp() {
            string CURP = "";
            //Primera letra del apellido paterno
            CURP += ape_pat.ToUpper().Substring(0, 1);
            //Primera vocal del apellido paterno
            for (int i = 1; i < ape_pat.Length; i++)
            {
                String vocal = ape_pat.ToUpper().Substring(i, 1);
                if (vocal.Equals("A") || vocal.Equals("E") || vocal.Equals("I") || vocal.Equals("O") || vocal.Equals("U"))
                {
                    CURP += vocal;
                    break;
                }
            }
            //Primera letra del apellido materno
            CURP += ape_mat.ToUpper().Substring(0, 1);
            //Primera letra del nombre
            CURP += nombre.ToUpper().Substring(0, 1);
            //Año de nacimiento
            CURP += fechaNacimiento.ToString("yy");
            //Mes de nacimiento
            CURP += fechaNacimiento.ToString("MM");
            //Dia de nacimiento
            CURP += fechaNacimiento.ToString("dd");
            //Sexo
            if (sexo.Equals("Masculino"))
            {
                CURP += "H";
            }else
            {
                CURP += "M";
            }           
            //Abreviatura estado
            if (Nacionalidad.Equals("Extranjero"))
            {
                CURP += "NE";
            }
            else
            {
                CURP += "YN";
            }
            //Primera consonante del apellido paterno
            for (int i = 1; i < ape_pat.Length; i++)
            {
                String consonante = ape_pat.ToUpper().Substring(i, 1);
                if (consonante != "A" && consonante != "E" && consonante != "I" && consonante != "O" && consonante != "U")
                {
                    CURP += consonante;
                    MessageBox.Show("apelllido paterno" + ape_pat + " - " + consonante);
                    break;
                }
            }
            //Primera consonante del apellido materno
            for (int i = 1; i < ape_mat.Length; i++)
            {
                String consonante = ape_mat.ToUpper().Substring(i, 1);
                if (consonante != "A" && consonante != "E" && consonante != "I" && consonante != "O" && consonante != "U")
                {
                    CURP += consonante;
                    MessageBox.Show("apelllido materno" + ape_mat+ " - " + consonante);
                    break;
                }
            }
            //Primera consonante del nombre
            for (int i = 1; i < nombre.Length; i++)
            {
                String consonante = nombre.ToUpper().Substring(i, 1);
                if (consonante != "A" && consonante != "E" && consonante != "I" && consonante != "O" && consonante != "U")
                {
                    CURP += consonante;
                    MessageBox.Show("nombre" + nombre + " - " + consonante);
                    break;
                }
            }
            MessageBox.Show(CURP);
            return CURP;
       }
    }
}
