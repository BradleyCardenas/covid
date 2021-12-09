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
    public partial class PanelUsuario : Form
    {
        PeticionSQL funciones = new PeticionSQL();
        public PanelUsuario()
        {
            InitializeComponent();
        }

        private void panelRegistroUsuario_Load(object sender, EventArgs e)
        {
            comboEstado_registro.Enabled = false;
        }

        private void comboNacion_registro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboNacion_registro.SelectedIndex == 0)
            {
                comboEstado_registro.Enabled = true;
                comboEstado_registro.DataSource = funciones.listaEstados();
            }
            else
            {
                comboEstado_registro.Items.Clear();
                comboEstado_registro.Enabled = false;
            }
        }
    }
}
