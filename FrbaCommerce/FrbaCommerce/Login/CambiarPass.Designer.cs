namespace FrbaCommerce.Login
{
    partial class CambiarPass
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
            this.l_passNueva = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.l_error = new System.Windows.Forms.Label();
            this.l_passAnterior = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bCancelar = new System.Windows.Forms.Button();
            this.l_passNuevaConfirmada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(145, 166);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 14;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.l_passNuevaConfirmada);
            this.groupBox1.Controls.Add(this.l_passNueva);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.l_error);
            this.groupBox1.Controls.Add(this.l_passAnterior);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 142);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cambio de Contraseña";
            // 
            // l_passNueva
            // 
            this.l_passNueva.BackColor = System.Drawing.SystemColors.Window;
            this.l_passNueva.Enabled = false;
            this.l_passNueva.Location = new System.Drawing.Point(174, 57);
            this.l_passNueva.Name = "l_passNueva";
            this.l_passNueva.Size = new System.Drawing.Size(241, 20);
            this.l_passNueva.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 13);
            this.label13.TabIndex = 50;
            this.label13.Text = "Ingrese Nueva Contraseña";
            // 
            // l_error
            // 
            this.l_error.AutoSize = true;
            this.l_error.Location = new System.Drawing.Point(178, 117);
            this.l_error.Name = "l_error";
            this.l_error.Size = new System.Drawing.Size(22, 13);
            this.l_error.TabIndex = 50;
            this.l_error.Text = "OK";
            // 
            // l_passAnterior
            // 
            this.l_passAnterior.Location = new System.Drawing.Point(174, 31);
            this.l_passAnterior.Name = "l_passAnterior";
            this.l_passAnterior.Size = new System.Drawing.Size(241, 20);
            this.l_passAnterior.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Contraseña Anterior";
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(238, 166);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 16;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // l_passNuevaConfirmada
            // 
            this.l_passNuevaConfirmada.Location = new System.Drawing.Point(174, 84);
            this.l_passNuevaConfirmada.Name = "l_passNuevaConfirmada";
            this.l_passNuevaConfirmada.Size = new System.Drawing.Size(241, 20);
            this.l_passNuevaConfirmada.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Repita la Contraseña Anterior";
            // 
            // CambiarPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 200);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.groupBox1);
            this.Name = "CambiarPass";
            this.Text = "FRBA Commerce";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox l_passAnterior;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label l_error;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.TextBox l_passNueva;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox l_passNuevaConfirmada;
        private System.Windows.Forms.Label label1;

    }
}