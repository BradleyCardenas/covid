using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using PlantillaProyecto.Objects;
using PlantillaProyecto.Classes.Objects;
using System.Windows.Forms;

namespace PlantillaProyecto.Classes
{
    class PeticionSQL{
        //Bradley
        SqlConnection conexion = new SqlConnection("Server = Edwin-LenguajeV; Database=Covid;Trusted_Connection=True");
        //Daniel
        //SqlConnection conexion = new SqlConnection("server=DESKTOP-FKGSU3G; database=Covid; integrated security=true;");
        SqlCommand comando;
        string sql;

        public bool guardarUsuario(Usuario usuario) {
            bool estatus = true;

            try
            {
                sql = "INSERT INTO Usuarios(curp, correo, nombre, ape_pat, ape_mat, sexo, fecha_nacimiento, nacionalidad, estado_nacimiento, contacto, direccion, colonia, cod_postal, municipio, estado_domicilio) VALUES(@curp, @correo ,@nombre, @ape_pat, @ape_mat, @sexo, @fecha_nacimiento, @nacionalidad, @estado_nacimiento, @contacto, @direccion, @colonia, @cod_postal, @municipio, @estado_domicilio)";
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

                comando.Parameters["@curp"].Value = usuario.generateCurp();
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
            catch (InvalidCastException e) {
                MessageBox.Show(e.ToString());
                estatus = false;
            }

            return estatus;
        }

        public bool guardarVacuna(Vacuna vacuna, string correo, string curp){
            bool estatus = true;
            Usuario usuario = traerUsuario(curp, correo);
            try
            {
                sql = "INSERT INTO Registro_vacuna(idUsuario, Marca, Dosis, Fecha_vacuna, Sede) VALUES(@idUsuario, @marca, @dosis, @Fecha_vacuna, @sede)";
                conexion.Open();
                comando = new SqlCommand(sql, conexion);

                comando.Parameters.Add("@idUsuario", SqlDbType.VarChar);
                comando.Parameters.Add("@marca", SqlDbType.VarChar);
                comando.Parameters.Add("@dosis", SqlDbType.VarChar);
                comando.Parameters.Add("@Fecha_vacuna", SqlDbType.DateTime);
                comando.Parameters.Add("@sede", SqlDbType.VarChar);


                comando.Parameters["@idUsuario"].Value = usuario.Id;
                comando.Parameters["@marca"].Value = vacuna.Marca;
                comando.Parameters["@dosis"].Value = vacuna.Dosis;
                comando.Parameters["@Fecha_vacuna"].Value = vacuna.Fecha_vacuna;
                comando.Parameters["@sede"].Value = vacuna.Sede;

                comando.ExecuteNonQuery();
                conexion.Close();

            }
            catch (InvalidCastException e) {
                MessageBox.Show(e.ToString());
                estatus = false;
            }

            return estatus;
        }

        public bool editarUsuario(Usuario usuario)
        {
            bool estatus = true;
            try
            {
                sql = "UPDATE Usuarios SET(curp, correo, nombre, ape_pat, ape_mat, sexo, fecha_nacimiento, nacionalidad, estado_nacimiento) VALUES(@curp, @correo ,@nombre, @ape_pat, @ape_mat, @sexo, @fecha_nacimiento, @nacionalidad, @estado_nacimiento, @contacto, @direccion, @colonia, @cod_postal, @municipio, @estado_domicilio) WHERE idUsuario = '" + usuario.Id + "'";
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

                comando.Parameters["@curp"].Value = usuario.generateCurp();
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
            catch (InvalidCastException e)
            {
                MessageBox.Show(e.ToString());
                estatus = false;
            }

            return estatus;
        }

        public bool editarDomicilioUsuario(Usuario usuario)
        {
            bool estatus = true;
            try
            {
                sql = "UPDATE Usuarios SET(contacto, direccion, colonia, cod_postal, municipio, estado_domicilio) VALUES(@contacto, @direccion, @colonia, @cod_postal, @municipio, @estado_domicilio) WHERE idUsuario = '" + usuario.Id + "'";
                conexion.Open();
                comando = new SqlCommand(sql, conexion);

                comando.Parameters.Add("@contacto", SqlDbType.VarChar);
                comando.Parameters.Add("@direccion", SqlDbType.VarChar);
                comando.Parameters.Add("@colonia", SqlDbType.VarChar);
                comando.Parameters.Add("@cod_postal", SqlDbType.VarChar);
                comando.Parameters.Add("@municipio", SqlDbType.VarChar);
                comando.Parameters.Add("@estado_domicilio", SqlDbType.VarChar);

                comando.Parameters["@contacto"].Value = usuario.Contacto;
                comando.Parameters["@direccion"].Value = usuario.Direccion;
                comando.Parameters["@colonia"].Value = usuario.Colonia;
                comando.Parameters["@cod_postal"].Value = usuario.CodPostal;
                comando.Parameters["@municipio"].Value = usuario.Municipio;
                comando.Parameters["@estado_domicilio"].Value = usuario.EstadoDomicilio;

                comando.ExecuteNonQuery();
                conexion.Close();

            }
            catch (InvalidCastException e)
            {
                MessageBox.Show(e.ToString());
                estatus = false;
            }

            return estatus;
        }
        public Usuario traerUsuario(string curp, string correo){
            SqlDataReader resultado;
            Usuario usuario = new Usuario();
            try{
                sql = "SELECT * FROM Usuarios WHERE curp = '" + curp +"' AND correo = '" + correo + "';";
                conexion.Open();
                comando = new SqlCommand(sql, conexion);
                resultado = comando.ExecuteReader();
                while (resultado.Read()){
                    usuario.Id = int.Parse(resultado["idUsuario"].ToString());
                    usuario.Nombre = resultado["nombre"].ToString();
                    usuario.Correo = resultado["correo"].ToString();
                    usuario.Ape_pat = resultado["ape_pat"].ToString();
                    usuario.Ape_mat = resultado["ape_mat"].ToString();
                    usuario.Sexo = char.Parse(resultado["sexo"].ToString());
                    usuario.FechaNacimiento = DateTime.Parse(resultado["fecha_nacimiento"].ToString());
                    usuario.Nacionalidad = resultado["nacionalidad"].ToString();
                    usuario.EstadoNacimiento = resultado["estado_nacimiento"].ToString();
                    usuario.Contacto = resultado["contacto"].ToString();
                    usuario.Direccion = resultado["direccion"].ToString();
                    usuario.Colonia = resultado["colonia"].ToString();
                    usuario.CodPostal = resultado["cod_postal"].ToString();
                    usuario.Municipio = resultado["municipio"].ToString();
                    usuario.EstadoDomicilio = resultado["estado_domicilio"].ToString();
                }
                conexion.Close();
             
            }
            catch {
                usuario = null;
            }
            
            return usuario;
        }

        public Vacuna traerVacuna(int idUsuario)
        {
            SqlDataReader resultadoVacuna;
            Vacuna vacuna = new Vacuna();
            try
            {
                sql = "SELECT * FROM Registro_vacuna WHERE idUsuario = '" + idUsuario + "';";
                conexion.Open();
                comando = new SqlCommand(sql, conexion);
                resultadoVacuna = comando.ExecuteReader();
                while (resultadoVacuna.Read())
                {
                    vacuna.Marca = resultadoVacuna["Marca"].ToString();
                    vacuna.Dosis = resultadoVacuna["Dosis"].ToString();
                    vacuna.Fecha_vacuna = DateTime.Parse(resultadoVacuna["Fecha_vacuna"].ToString());
                    vacuna.Sede = resultadoVacuna["Sede"].ToString();
                }
                conexion.Close();
            }
            catch
            {
                vacuna = null;
            }

            return vacuna;
        }

        public List<string> listaMunicipios(int idEstado)
        {
            SqlDataReader resultadoMunicipio;
            List<string> lista = new List<string>();
            try
            {
                sql = "SELECT Municipio FROM Municipios WHERE idEstado = " + idEstado + ";";
                conexion.Open();
                comando = new SqlCommand(sql, conexion);
                resultadoMunicipio = comando.ExecuteReader();               
                while (resultadoMunicipio.Read())
                {
                    lista.Add(resultadoMunicipio["Municipio"].ToString());
                }
                conexion.Close();
            }
            catch
            {
                lista = null;
            }
            return lista;
        }
        public List<string> listaEstados()
        {
            SqlDataReader resultadoEstado;
            List<string> lista = new List<string>();
            try
            {
                sql = "SELECT Estado FROM Estados;";
                conexion.Open();
                comando = new SqlCommand(sql, conexion);
                resultadoEstado = comando.ExecuteReader();               
                while (resultadoEstado.Read())
                {
                    lista.Add(resultadoEstado["Estado"].ToString());
                }
                conexion.Close();
            }
            catch
            {
                lista = null;
            }
            return lista;
        }

        public List<string> listaVacunas()
        {
            SqlDataReader resultadoVacuna;
            List<string> lista = new List<string>();
            try
            {
                sql = "SELECT Nombre FROM Marcas;";
                conexion.Open();
                comando = new SqlCommand(sql, conexion);
                resultadoVacuna = comando.ExecuteReader();
                while (resultadoVacuna.Read())
                {
                    lista.Add(resultadoVacuna["Nombre"].ToString());
                }
                conexion.Close();
            }
            catch
            {
                lista = null;
            }
            return lista;
        }

        public List<string> listaDosis()
        {
            SqlDataReader resultadoDosis;
            List<string> lista = new List<string>();
            try  
            {
                sql = "SELECT Tipo FROM Dosis;";
                conexion.Open();
                comando = new SqlCommand(sql, conexion);
                resultadoDosis = comando.ExecuteReader();
                while (resultadoDosis.Read())
                {
                    lista.Add(resultadoDosis["Tipo"].ToString());
                }
                conexion.Close();
            }
            catch
            {
                lista = null;
            }
            return lista;
        }
    }
}
