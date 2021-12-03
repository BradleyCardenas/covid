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
    public partial class InicioSesion : Form
    {
        //BRADLEY
        //private SqlConnection conexion = new SqlConnection();
        //DANIEL
        private SqlConnection conexion = new SqlConnection();
        private SqlCommand comando;
        String sql;
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {
            Text = "Inicio de sesión";
        }
    }
}
