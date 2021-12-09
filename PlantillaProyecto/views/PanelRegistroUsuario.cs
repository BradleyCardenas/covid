using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlantillaProyecto.Classes;

namespace PlantillaProyecto.views
{
    public partial class PanelRegistroUsuario : Form
    {
        PeticionSQL funciones = new PeticionSQL();
        public PanelRegistroUsuario()
        {
            InitializeComponent();
        }

        private void comboEstado_registro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PanelRegistroUsuario_Load(object sender, EventArgs e)
        {
            comboEstado_registro.DataSource = funciones.listaEstados();
        }
    }
}
