
namespace PlantillaProyecto.views
{
    partial class Comprobante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_inicio = new System.Windows.Forms.Button();
            this.btn_registroUsuario = new System.Windows.Forms.Button();
            this.btn_registrVacuna = new System.Windows.Forms.Button();
            this.btn_consultaInformacion = new System.Windows.Forms.Button();
            this.btn_comprobante = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.pnl_principal = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_inicio
            // 
            this.btn_inicio.Location = new System.Drawing.Point(13, 13);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(125, 45);
            this.btn_inicio.TabIndex = 0;
            this.btn_inicio.Text = "Inicio";
            this.btn_inicio.UseVisualStyleBackColor = true;
            // 
            // btn_registroUsuario
            // 
            this.btn_registroUsuario.Location = new System.Drawing.Point(13, 64);
            this.btn_registroUsuario.Name = "btn_registroUsuario";
            this.btn_registroUsuario.Size = new System.Drawing.Size(125, 45);
            this.btn_registroUsuario.TabIndex = 1;
            this.btn_registroUsuario.Text = "Registro usuario";
            this.btn_registroUsuario.UseVisualStyleBackColor = true;
            this.btn_registroUsuario.Click += new System.EventHandler(this.btn_registroUsuario_Click);
            // 
            // btn_registrVacuna
            // 
            this.btn_registrVacuna.Location = new System.Drawing.Point(13, 115);
            this.btn_registrVacuna.Name = "btn_registrVacuna";
            this.btn_registrVacuna.Size = new System.Drawing.Size(125, 45);
            this.btn_registrVacuna.TabIndex = 2;
            this.btn_registrVacuna.Text = "Registro vacuna";
            this.btn_registrVacuna.UseVisualStyleBackColor = true;
            this.btn_registrVacuna.Click += new System.EventHandler(this.btn_registrVacuna_Click);
            // 
            // btn_consultaInformacion
            // 
            this.btn_consultaInformacion.Location = new System.Drawing.Point(13, 166);
            this.btn_consultaInformacion.Name = "btn_consultaInformacion";
            this.btn_consultaInformacion.Size = new System.Drawing.Size(125, 45);
            this.btn_consultaInformacion.TabIndex = 3;
            this.btn_consultaInformacion.Text = "Consulta información";
            this.btn_consultaInformacion.UseVisualStyleBackColor = true;
            this.btn_consultaInformacion.Click += new System.EventHandler(this.btn_consultaInformacion_Click);
            // 
            // btn_comprobante
            // 
            this.btn_comprobante.Location = new System.Drawing.Point(13, 217);
            this.btn_comprobante.Name = "btn_comprobante";
            this.btn_comprobante.Size = new System.Drawing.Size(125, 45);
            this.btn_comprobante.TabIndex = 4;
            this.btn_comprobante.Text = "Comprobante";
            this.btn_comprobante.UseVisualStyleBackColor = true;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(12, 425);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(125, 45);
            this.btn_salir.TabIndex = 5;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // pnl_principal
            // 
            this.pnl_principal.Location = new System.Drawing.Point(160, 13);
            this.pnl_principal.Name = "pnl_principal";
            this.pnl_principal.Size = new System.Drawing.Size(757, 457);
            this.pnl_principal.TabIndex = 6;
            // 
            // Comprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 484);
            this.Controls.Add(this.pnl_principal);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_comprobante);
            this.Controls.Add(this.btn_consultaInformacion);
            this.Controls.Add(this.btn_registrVacuna);
            this.Controls.Add(this.btn_registroUsuario);
            this.Controls.Add(this.btn_inicio);
            this.Name = "Comprobante";
            this.Text = "Mi salud de vacunación";
            this.Load += new System.EventHandler(this.Comprobante_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_inicio;
        private System.Windows.Forms.Button btn_registroUsuario;
        private System.Windows.Forms.Button btn_registrVacuna;
        private System.Windows.Forms.Button btn_consultaInformacion;
        private System.Windows.Forms.Button btn_comprobante;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Panel pnl_principal;
    }
}