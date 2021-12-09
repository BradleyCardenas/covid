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
    public partial class PanelRegistroVacuna : Form
    {
        PeticionSQL funciones = new PeticionSQL();
        public PanelRegistroVacuna()
        {
            InitializeComponent();
        }

        private void PanelRegistroVacuna_Load(object sender, EventArgs e)
        {
            comboMarca_vacuna.DataSource = funciones.listaVacunas();
            comboDosis_vacuna.DataSource = funciones.listaDosis();
        }
    }
}
