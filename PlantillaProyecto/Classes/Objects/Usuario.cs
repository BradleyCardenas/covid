using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


       // private string generateCurp() {
            //TODO:
            //crear el método de generar CURP

       // }



    }
}
