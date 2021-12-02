
namespace PlantillaProyecto
{
    partial class InicioSesion
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
            this.linkRegistro = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtCURP_login = new System.Windows.Forms.TextBox();
            this.txtCorreo_login = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkRegistro
            // 
            this.linkRegistro.AutoSize = true;
            this.linkRegistro.Location = new System.Drawing.Point(361, 146);
            this.linkRegistro.Name = "linkRegistro";
            this.linkRegistro.Size = new System.Drawing.Size(76, 20);
            this.linkRegistro.TabIndex = 13;
            this.linkRegistro.TabStop = true;
            this.linkRegistro.Text = "Regístrate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(97, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 41);
            this.label3.TabIndex = 12;
            this.label3.Text = "INICIO DE SESIÓN";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(162, 171);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(115, 29);
            this.btnIngresar.TabIndex = 11;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            // 
            // txtCURP_login
            // 
            this.txtCURP_login.Location = new System.Drawing.Point(162, 71);
            this.txtCURP_login.Name = "txtCURP_login";
            this.txtCURP_login.Size = new System.Drawing.Size(275, 27);
            this.txtCURP_login.TabIndex = 10;
            // 
            // txtCorreo_login
            // 
            this.txtCorreo_login.Location = new System.Drawing.Point(162, 105);
            this.txtCorreo_login.Name = "txtCorreo_login";
            this.txtCorreo_login.Size = new System.Drawing.Size(275, 27);
            this.txtCorreo_login.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Correo electrónico";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "CURP";
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 229);
            this.Controls.Add(this.linkRegistro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtCURP_login);
            this.Controls.Add(this.txtCorreo_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InicioSesion";
            this.Text = "InicioSesion";
            this.Load += new System.EventHandler(this.InicioSesion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkRegistro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtCURP_login;
        private System.Windows.Forms.TextBox txtCorreo_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}