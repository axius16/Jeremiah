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
            this.t_rol = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ch_habilitado = new System.Windows.Forms.CheckBox();
            this.bFiltrarFuncionalidad = new System.Windows.Forms.Button();
            this.t_funcionalidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bMoverADerecha = new System.Windows.Forms.Button();
            this.bMoverAIzquierda = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.tb_admitidas = new System.Windows.Forms.DataGridView();
            this.tb_disponibles = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_admitidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_disponibles)).BeginInit();
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
            // t_rol
            // 
            this.t_rol.Location = new System.Drawing.Point(51, 32);
            this.t_rol.Name = "t_rol";
            this.t_rol.Size = new System.Drawing.Size(249, 20);
            this.t_rol.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_disponibles);
            this.groupBox1.Controls.Add(this.tb_admitidas);
            this.groupBox1.Controls.Add(this.ch_habilitado);
            this.groupBox1.Controls.Add(this.bFiltrarFuncionalidad);
            this.groupBox1.Controls.Add(this.t_funcionalidad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bMoverADerecha);
            this.groupBox1.Controls.Add(this.bMoverAIzquierda);
            this.groupBox1.Controls.Add(this.t_rol);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 320);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rol";
            // 
            // ch_habilitado
            // 
            this.ch_habilitado.AutoSize = true;
            this.ch_habilitado.Location = new System.Drawing.Point(387, 35);
            this.ch_habilitado.Name = "ch_habilitado";
            this.ch_habilitado.Size = new System.Drawing.Size(92, 17);
            this.ch_habilitado.TabIndex = 16;
            this.ch_habilitado.Text = "Rol Habilitado";
            this.ch_habilitado.UseVisualStyleBackColor = true;
            // 
            // bFiltrarFuncionalidad
            // 
            this.bFiltrarFuncionalidad.Location = new System.Drawing.Point(639, 73);
            this.bFiltrarFuncionalidad.Name = "bFiltrarFuncionalidad";
            this.bFiltrarFuncionalidad.Size = new System.Drawing.Size(23, 23);
            this.bFiltrarFuncionalidad.TabIndex = 15;
            this.bFiltrarFuncionalidad.Text = "?";
            this.bFiltrarFuncionalidad.UseVisualStyleBackColor = true;
            this.bFiltrarFuncionalidad.Click += new System.EventHandler(this.bFiltrarFuncionalidad_Click);
            // 
            // t_funcionalidad
            // 
            this.t_funcionalidad.Location = new System.Drawing.Point(463, 76);
            this.t_funcionalidad.Name = "t_funcionalidad";
            this.t_funcionalidad.Size = new System.Drawing.Size(170, 20);
            this.t_funcionalidad.TabIndex = 14;
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
            this.bMoverADerecha.Location = new System.Drawing.Point(306, 181);
            this.bMoverADerecha.Name = "bMoverADerecha";
            this.bMoverADerecha.Size = new System.Drawing.Size(75, 23);
            this.bMoverADerecha.TabIndex = 9;
            this.bMoverADerecha.Text = ">>";
            this.bMoverADerecha.UseVisualStyleBackColor = true;
            this.bMoverADerecha.Click += new System.EventHandler(this.bMoverADerecha_Click);
            // 
            // bMoverAIzquierda
            // 
            this.bMoverAIzquierda.Location = new System.Drawing.Point(306, 210);
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
            // tb_admitidas
            // 
            this.tb_admitidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_admitidas.Location = new System.Drawing.Point(25, 109);
            this.tb_admitidas.Name = "tb_admitidas";
            this.tb_admitidas.Size = new System.Drawing.Size(275, 199);
            this.tb_admitidas.TabIndex = 17;
            // 
            // tb_disponibles
            // 
            this.tb_disponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_disponibles.Location = new System.Drawing.Point(387, 109);
            this.tb_disponibles.Name = "tb_disponibles";
            this.tb_disponibles.Size = new System.Drawing.Size(275, 199);
            this.tb_disponibles.TabIndex = 18;
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
            ((System.ComponentModel.ISupportInitialize)(this.tb_admitidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_disponibles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t_rol;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bMoverADerecha;
        private System.Windows.Forms.Button bMoverAIzquierda;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bFiltrarFuncionalidad;
        private System.Windows.Forms.TextBox t_funcionalidad;
        private System.Windows.Forms.CheckBox ch_habilitado;
        private System.Windows.Forms.DataGridView tb_disponibles;
        private System.Windows.Forms.DataGridView tb_admitidas;
    }
}