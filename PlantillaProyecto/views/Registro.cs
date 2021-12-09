using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlantillaProyecto.Classes.Objects;
using PlantillaProyecto.Objects;
using PlantillaProyecto.Classes;

namespace PlantillaProyecto.views
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void abrirForm(object formulario)
        {
            if (pnl_registro.Controls.Count > 0)
                pnl_registro.Controls.RemoveAt(0);

            Form fr = formulario as Form;
            fr.TopLevel = false;
            fr.Dock = DockStyle.Fill;
            this.pnl_registro.Controls.Add(fr);
            this.pnl_registro.Tag = fr;
            fr.Show();
        }

        int estado = 0;
        PanelRegistroUsuario panelRegistroUsuario = new PanelRegistroUsuario();
        PanelRegistroDomicilio panelRegistroDomicilio = new PanelRegistroDomicilio();
        PanelRegistroVacuna panelRegistroVacuna = new PanelRegistroVacuna();
        PeticionSQL funcion = new PeticionSQL();

        private void Registro_Load(object sender, EventArgs e){
            abrirForm(panelRegistroUsuario);
        }

        private void btn_cancelar_Click(object sender, EventArgs e){
            cambiarEstadoAnterior();

        }

        private void btn_siguiente_Click(object sender, EventArgs e){
            cambiarEstadoSiguiente();
        }


        Usuario usuario = new Usuario();
        private void cambiarEstadoSiguiente() {
            switch (estado) {
                case 0:
                    if (!panelRegistroUsuario.hayCamposVacios()) {
                        estado++;
                        abrirForm(panelRegistroDomicilio);
                        btn_cancelar.Text = "Anterior";
                    }
                    break;
                case 1:
                    if (!panelRegistroDomicilio.hayCamposVacios()) {
                        estado++;
                        abrirForm(panelRegistroVacuna);
                        btn_siguiente.Text = "Guardar";
                    }
                    break;
                case 2:
                    if (!panelRegistroVacuna.hayCamposVacios()) {
                        Comprobante comprobante = new Comprobante();
                        Usuario usuario = obtenerUsuario();
                        if (funcion.guardarUsuario(usuario)) {
                            if (funcion.guardarVacuna(obtenerVacuna(), usuario.Correo, usuario.generateCurp())) {
                                MessageBox.Show("Su usuario se ha guardado exitosamente");
                                this.Hide();
                                comprobante.Show();
                            }
                        }
                        
                        

                       
                    }
                    break;

            }
        }

        private void cambiarEstadoAnterior() {
            switch (estado) {
                case 0:
                    InicioSesion inicioSesion = new InicioSesion();
                    this.Hide();
                    inicioSesion.Show();
                    break;
                case 1:
                    estado--;
                    abrirForm(panelRegistroUsuario);
                    btn_cancelar.Text = "Cancelar";
                    break;
                case 2:
                    estado--;
                    abrirForm(panelRegistroDomicilio);
                    btn_siguiente.Text = "Siguiente";
                    break;
            }
        }

        private Usuario obtenerUsuario() {
            Usuario usuario = new Usuario();

            if (!panelRegistroUsuario.hayCamposVacios() && !panelRegistroDomicilio.hayCamposVacios() && !panelRegistroVacuna.hayCamposVacios()){
                usuario.Nombre = panelRegistroUsuario.txt_nombre.Text;
                usuario.Ape_pat = panelRegistroUsuario.txt_apePat.Text;
                usuario.Ape_mat = panelRegistroUsuario.txt_apeMat.Text;
                usuario.Sexo = panelRegistroUsuario.obtenerSexo();
                usuario.FechaNacimiento = panelRegistroUsuario.dateNacimiento_registro.Value;
                usuario.Nacionalidad = panelRegistroUsuario.comboEstado_registro.Text;
                usuario.Correo = panelRegistroUsuario.txtCorreo_registro.Text;
                usuario.EstadoNacimiento = panelRegistroUsuario.comboEstado_registro.Text;

                usuario.Direccion = "Calle: " + panelRegistroDomicilio.txtCalle_vacuna.Text + " Num.Interior: " + panelRegistroDomicilio.txtInterior_vacuna.Text + " Num.Exterior: " + panelRegistroDomicilio.txtExterior_vacuna.Text;
                usuario.Colonia = panelRegistroDomicilio.txtColonia_vacuna.Text;
                usuario.CodPostal = panelRegistroDomicilio.txt_codPostal.Text;
                usuario.EstadoDomicilio = panelRegistroDomicilio.comboEstado_vacuna.Text;
                usuario.Municipio = panelRegistroDomicilio.comboMunicipio_vacuna.Text;
                
                usuario.Contacto = "Tel1: " + panelRegistroVacuna.txtTel1_vacuna.Text + " Tel2: " + panelRegistroVacuna.txtTel2_vacuna.Text;
            }
            return usuario;
        }

        private Vacuna obtenerVacuna() {
            Vacuna vacuna = new Vacuna();
            if (!panelRegistroVacuna.hayCamposVacios()){
                vacuna.Marca = panelRegistroVacuna.comboMarca_vacuna.Text;
                vacuna.Dosis = panelRegistroVacuna.comboDosis_vacuna.Text;
                vacuna.Sede = "Centro de salud";
                vacuna.Fecha_vacuna = DateTime.Now.AddDays(15);

            }

            return vacuna;
        }

    }
}
