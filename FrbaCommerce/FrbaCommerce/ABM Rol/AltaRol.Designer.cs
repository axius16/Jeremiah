namespace FrbaCommerce.ABM_Rol
{
    partial class AltaRol
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
            this.label2 = new System.Windows.Forms.Label();
            this.l_rol = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bFiltrarFuncionalidad = new System.Windows.Forms.Button();
            this.l_funcionalidad = new System.Windows.Forms.TextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bMoverADerecha = new System.Windows.Forms.Button();
            this.bMoverAIzquierda = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.l_habilitado = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rol";
            // 
            // l_rol
            // 
            this.l_rol.Location = new System.Drawing.Point(51, 32);
            this.l_rol.Name = "l_rol";
            this.l_rol.Size = new System.Drawing.Size(249, 20);
            this.l_rol.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.l_habilitado);
            this.groupBox1.Controls.Add(this.bFiltrarFuncionalidad);
            this.groupBox1.Controls.Add(this.l_funcionalidad);
            this.groupBox1.Controls.Add(this.listBox2);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bMoverADerecha);
            this.groupBox1.Controls.Add(this.bMoverAIzquierda);
            this.groupBox1.Controls.Add(this.l_rol);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 320);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rol";
            // 
            // bFiltrarFuncionalidad
            // 
            this.bFiltrarFuncionalidad.Location = new System.Drawing.Point(639, 73);
            this.bFiltrarFuncionalidad.Name = "bFiltrarFuncionalidad";
            this.bFiltrarFuncionalidad.Size = new System.Drawing.Size(23, 23);
            this.bFiltrarFuncionalidad.TabIndex = 15;
            this.bFiltrarFuncionalidad.Text = "?";
            this.bFiltrarFuncionalidad.UseVisualStyleBackColor = true;
            // 
            // l_funcionalidad
            // 
            this.l_funcionalidad.Location = new System.Drawing.Point(463, 76);
            this.l_funcionalidad.Name = "l_funcionalidad";
            this.l_funcionalidad.Size = new System.Drawing.Size(170, 20);
            this.l_funcionalidad.TabIndex = 14;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(25, 109);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(275, 199);
            this.listBox2.TabIndex = 13;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(387, 109);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(275, 199);
            this.listBox1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Funcionalidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Funcionalidades Admitidas";
            // 
            // bMoverADerecha
            // 
            this.bMoverADerecha.Location = new System.Drawing.Point(306, 214);
            this.bMoverADerecha.Name = "bMoverADerecha";
            this.bMoverADerecha.Size = new System.Drawing.Size(75, 23);
            this.bMoverADerecha.TabIndex = 9;
            this.bMoverADerecha.Text = ">>";
            this.bMoverADerecha.UseVisualStyleBackColor = true;
            this.bMoverADerecha.Click += new System.EventHandler(this.bMoverADerecha_Click);
            // 
            // bMoverAIzquierda
            // 
            this.bMoverAIzquierda.Location = new System.Drawing.Point(306, 185);
            this.bMoverAIzquierda.Name = "bMoverAIzquierda";
            this.bMoverAIzquierda.Size = new System.Drawing.Size(75, 23);
            this.bMoverAIzquierda.TabIndex = 8;
            this.bMoverAIzquierda.Text = "<<";
            this.bMoverAIzquierda.UseVisualStyleBackColor = true;
            this.bMoverAIzquierda.Click += new System.EventHandler(this.bMoverAIzquierda_Click);
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(273, 339);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 8;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(370, 339);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 9;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // l_habilitado
            // 
            this.l_habilitado.AutoSize = true;
            this.l_habilitado.Location = new System.Drawing.Point(387, 35);
            this.l_habilitado.Name = "l_habilitado";
            this.l_habilitado.Size = new System.Drawing.Size(92, 17);
            this.l_habilitado.TabIndex = 16;
            this.l_habilitado.Text = "Rol Habilitado";
            this.l_habilitado.UseVisualStyleBackColor = true;
            // 
            // AltaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 377);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.groupBox1);
            this.Name = "AltaRol";
            this.Text = "Rol";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox l_rol;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bMoverADerecha;
        private System.Windows.Forms.Button bMoverAIzquierda;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bFiltrarFuncionalidad;
        private System.Windows.Forms.TextBox l_funcionalidad;
        private System.Windows.Forms.CheckBox l_habilitado;
    }
}