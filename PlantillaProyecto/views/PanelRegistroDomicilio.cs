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
    public partial class PanelRegistroDomicilio : Form
    {
        PeticionSQL funciones = new PeticionSQL();
        public PanelRegistroDomicilio()
        {
            InitializeComponent();
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void PanelRegistroDomicilio_Load(object sender, EventArgs e)
        {
            comboEstado_vacuna.DataSource = funciones.listaEstados();
        }

        private void comboMunicipio_vacuna_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboEstado_vacuna_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboMunicipio_vacuna.DataSource = funciones.listaMunicipios(comboEstado_vacuna.SelectedIndex + 1);
        }
    }
}
