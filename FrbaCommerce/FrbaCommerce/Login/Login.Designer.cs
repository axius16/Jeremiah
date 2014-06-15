namespace FrbaCommerce.FrbaCommerce.Login
{
    partial class AltaCliente
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
            this.bAceptar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.l_password = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.l_error = new System.Windows.Forms.Label();
            this.l_usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(126, 131);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 14;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.l_password);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.l_error);
            this.groupBox1.Controls.Add(this.l_usuario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 113);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // l_password
            // 
            this.l_password.BackColor = System.Drawing.SystemColors.Window;
            this.l_password.Enabled = false;
            this.l_password.Location = new System.Drawing.Point(110, 57);
            this.l_password.Name = "l_password";
            this.l_password.Size = new System.Drawing.Size(231, 20);
            this.l_password.TabIndex = 51;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(43, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 50;
            this.label13.Text = "Contraseña";
            // 
            // l_error
            // 
            this.l_error.AutoSize = true;
            this.l_error.Location = new System.Drawing.Point(107, 89);
            this.l_error.Name = "l_error";
            this.l_error.Size = new System.Drawing.Size(22, 13);
            this.l_error.TabIndex = 50;
            this.l_error.Text = "OK";
            // 
            // l_usuario
            // 
            this.l_usuario.Location = new System.Drawing.Point(110, 31);
            this.l_usuario.Name = "l_usuario";
            this.l_usuario.Size = new System.Drawing.Size(231, 20);
            this.l_usuario.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Usuario";
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(219, 131);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 16;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // AltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 162);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.groupBox1);
            this.Name = "AltaCliente";
            this.Text = "FRBA Commerce";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox l_usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label l_error;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.TextBox l_password;
        private System.Windows.Forms.Label label13;

    }
}