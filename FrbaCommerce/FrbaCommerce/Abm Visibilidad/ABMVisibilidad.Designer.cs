namespace FrbaCommerce.Abm_Visibilidad
{
    partial class AbmVisibilidad
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bBaja = new System.Windows.Forms.Button();
            this.bAlta = new System.Windows.Forms.Button();
            this.bModificacion = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bLimpiar = new System.Windows.Forms.Button();
            this.bBuscar = new System.Windows.Forms.Button();
            this.t_descripcion = new System.Windows.Forms.TextBox();
            this.t_codigo = new System.Windows.Forms.TextBox();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.tb_visibilidades = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_visibilidades)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bBaja);
            this.panel1.Controls.Add(this.bAlta);
            this.panel1.Controls.Add(this.bModificacion);
            this.panel1.Location = new System.Drawing.Point(12, 322);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 45);
            this.panel1.TabIndex = 1;
            // 
            // bBaja
            // 
            this.bBaja.Location = new System.Drawing.Point(345, 3);
            this.bBaja.Name = "bBaja";
            this.bBaja.Size = new System.Drawing.Size(75, 23);
            this.bBaja.TabIndex = 8;
            this.bBaja.Text = "Eliminar";
            this.bBaja.UseVisualStyleBackColor = true;
            this.bBaja.Click += new System.EventHandler(this.bBaja_Click);
            // 
            // bAlta
            // 
            this.bAlta.Location = new System.Drawing.Point(135, 3);
            this.bAlta.Name = "bAlta";
            this.bAlta.Size = new System.Drawing.Size(75, 23);
            this.bAlta.TabIndex = 6;
            this.bAlta.Text = "Ingresar";
            this.bAlta.UseVisualStyleBackColor = true;
            this.bAlta.Click += new System.EventHandler(this.bAlta_Click);
            // 
            // bModificacion
            // 
            this.bModificacion.Location = new System.Drawing.Point(240, 3);
            this.bModificacion.Name = "bModificacion";
            this.bModificacion.Size = new System.Drawing.Size(75, 23);
            this.bModificacion.TabIndex = 7;
            this.bModificacion.Text = "Modificar";
            this.bModificacion.UseVisualStyleBackColor = true;
            this.bModificacion.Click += new System.EventHandler(this.bModificacion_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bLimpiar);
            this.panel2.Controls.Add(this.bBuscar);
            this.panel2.Controls.Add(this.t_descripcion);
            this.panel2.Controls.Add(this.t_codigo);
            this.panel2.Controls.Add(this.lbDescripcion);
            this.panel2.Controls.Add(this.lbCodigo);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(554, 78);
            this.panel2.TabIndex = 1;
            // 
            // bLimpiar
            // 
            this.bLimpiar.Location = new System.Drawing.Point(364, 44);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(75, 23);
            this.bLimpiar.TabIndex = 5;
            this.bLimpiar.Text = "Limpiar";
            this.bLimpiar.UseVisualStyleBackColor = true;
            this.bLimpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(283, 44);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(75, 23);
            this.bBuscar.TabIndex = 4;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // t_descripcion
            // 
            this.t_descripcion.Location = new System.Drawing.Point(364, 15);
            this.t_descripcion.Name = "t_descripcion";
            this.t_descripcion.Size = new System.Drawing.Size(160, 20);
            this.t_descripcion.TabIndex = 3;
            // 
            // t_codigo
            // 
            this.t_codigo.Location = new System.Drawing.Point(80, 15);
            this.t_codigo.Name = "t_codigo";
            this.t_codigo.Size = new System.Drawing.Size(160, 20);
            this.t_codigo.TabIndex = 1;
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(295, 18);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lbDescripcion.TabIndex = 2;
            this.lbDescripcion.Text = "Descripcion";
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(34, 18);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(40, 13);
            this.lbCodigo.TabIndex = 1;
            this.lbCodigo.Text = "Codigo";
            // 
            // tb_visibilidades
            // 
            this.tb_visibilidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_visibilidades.Location = new System.Drawing.Point(12, 97);
            this.tb_visibilidades.Name = "tb_visibilidades";
            this.tb_visibilidades.Size = new System.Drawing.Size(554, 219);
            this.tb_visibilidades.TabIndex = 2;
            this.tb_visibilidades.TabStop = false;
            // 
            // AbmVisibilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 379);
            this.Controls.Add(this.tb_visibilidades);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AbmVisibilidad";
            this.Text = "ABM Visibilidad";
            this.Load += new System.EventHandler(this.AbmEmpresa_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_visibilidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bBaja;
        private System.Windows.Forms.Button bModificacion;
        private System.Windows.Forms.Button bAlta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox t_descripcion;
        private System.Windows.Forms.TextBox t_codigo;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Button bLimpiar;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.DataGridView tb_visibilidades;
    }
}