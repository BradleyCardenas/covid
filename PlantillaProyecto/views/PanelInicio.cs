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
using PlantillaProyecto.Objects;

namespace PlantillaProyecto.views
{
    public partial class PanelInicio : Form
    {
        PeticionSQL funciones = new PeticionSQL();
        Comprobante comprobante = new Comprobante();
        public PanelInicio()
        {
            InitializeComponent();
        }

        private void PanelInicio_Load(object sender, EventArgs e)
        {
            llenar(comprobante.usuarioLog);
        }

        public void llenar(Usuario log)
        {
                txt_nombre.Text = log.Nombre();               
        }
    }
}
