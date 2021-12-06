using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlantillaProyecto.Objects;

namespace PlantillaProyecto.Classes.Functions
{
    class FuncionesSQL{
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
