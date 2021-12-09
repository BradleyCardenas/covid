using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using PlantillaProyecto.Objects;

namespace PlantillaProyecto.Classes.Functions
{
    class FuncionesSQL{
        //Bradley
        //SqlConnection conexion = new SqlConnection("Server = Edwin-LenguajeV; Database=Covid;Trusted_Connection=True");
        //Daniel
        SqlConnection conexion = new SqlConnection("server=DESKTOP-FKGSU3G; database=Covid; integrated security=true;");
        PeticionSQL peticion = new PeticionSQL();

        public bool SetUsuario(Usuario usuario) {
            return peticion.guardarUsuario(usuario);
        }

        //public Usuario GetUsuario(int idUsuario) {
            //TODO:
            //Convertir el SqlDataReader en un Usuario
        //}
    }
}
