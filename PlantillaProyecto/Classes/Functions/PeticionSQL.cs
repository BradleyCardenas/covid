using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using PlantillaProyecto.Objects;

namespace PlantillaProyecto.Classes
{
    class PeticionSQL{
        SqlConnection conexion = new SqlConnection("Server = Edwin-LenguajeV; Database=Covid;Trusted_Connection=True");
        SqlCommand comando;
        string sql;

        public bool guardarUsuario(Usuario usuario) {
            bool estatus = true;

            try
            {
                sql = "INSERT INTO Empleados(curp, correo, nombre, ape_pat, ape_mat, sexo, fecha_nacimiento, nacionalidad, estado_nacimiento, contacto, direccion, colonia, cod_postal, municipio, estado_domicilio) VALUES(@nombre, @ape_pat, @ape_mat, @sexo, @fecha_nacimiento, @nacionalidad, @estado_nacimiento, @contacto, @direccion, @colonia, @cod_postal, @municipio, @estado_domicilio)";
                conexion.Open();
                comando = new SqlCommand(sql, conexion);

                comando.Parameters.Add("@curp", SqlDbType.VarChar);
                comando.Parameters.Add("@correo", SqlDbType.VarChar);
                comando.Parameters.Add("@nombre", SqlDbType.VarChar);
                comando.Parameters.Add("@ape_pat", SqlDbType.VarChar);
                comando.Parameters.Add("@ape_mat", SqlDbType.VarChar);
                comando.Parameters.Add("@sexo", SqlDbType.VarChar);
                comando.Parameters.Add("@fecha_nacimiento", SqlDbType.DateTime);
                comando.Parameters.Add("@nacionalidad", SqlDbType.VarChar);
                comando.Parameters.Add("@estado_nacimiento", SqlDbType.VarChar);
                comando.Parameters.Add("@contacto", SqlDbType.VarChar);
                comando.Parameters.Add("@direccion", SqlDbType.VarChar);
                comando.Parameters.Add("@colonia", SqlDbType.VarChar);
                comando.Parameters.Add("@cod_postal", SqlDbType.VarChar);
                comando.Parameters.Add("@municipio", SqlDbType.VarChar);
                comando.Parameters.Add("@estado_domicilio", SqlDbType.VarChar);

                comando.Parameters["@curp"].Value = usuario.Curp;
                comando.Parameters["@correo"].Value = usuario.Correo;
                comando.Parameters["@nombre"].Value = usuario.Nombre;
                comando.Parameters["@ape_pat"].Value = usuario.Ape_pat;
                comando.Parameters["@ape_mat"].Value = usuario.Ape_mat;
                comando.Parameters["@sexo"].Value = usuario.Sexo;
                comando.Parameters["@fecha_nacimiento"].Value = usuario.FechaNacimiento;
                comando.Parameters["@nacionalidad"].Value = usuario.Nacionalidad;
                comando.Parameters["@estado_nacimiento"].Value = usuario.EstadoNacimiento;
                comando.Parameters["@contacto"].Value = usuario.Contacto;
                comando.Parameters["@direccion"].Value = usuario.Direccion;
                comando.Parameters["@colonia"].Value = usuario.Colonia;
                comando.Parameters["@cod_postal"].Value = usuario.CodPostal;
                comando.Parameters["@municipio"].Value = usuario.Municipio;
                comando.Parameters["@estado_domicilio"].Value = usuario.EstadoDomicilio;

                comando.ExecuteNonQuery();
                conexion.Close();

            }
            catch {
                estatus = false;
            }

            return estatus;
        }

        public SqlDataReader traerUsuario(int idUsuario){
            SqlDataReader resultado;
            try{
                sql = "SELECT * FROM Usuarios WHERE idUsuario = " + idUsuario +";";
                conexion.Open();
                comando = new SqlCommand(sql, conexion);
                resultado = comando.ExecuteReader();
                conexion.Close();
             
            }
            catch {
                resultado = null;
            }
            
            return resultado;
        }
    }
}
