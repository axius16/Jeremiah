namespace FrbaCommerce.
    
    Abm_Visibilidad
{
    partial class AltaVisibilidad
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
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbPrecioPublicar = new System.Windows.Forms.Label();
            this.lbPorcentajeVenta = new System.Windows.Forms.Label();
            this.lbDuracion = new System.Windows.Forms.Label();
            this.t_descripcion = new System.Windows.Forms.TextBox();
            this.t_precioPorPublicar = new System.Windows.Forms.TextBox();
            this.t_porcentajeVenta = new System.Windows.Forms.TextBox();
            this.t_duracion = new System.Windows.Forms.TextBox();
            this.bAceptar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.ch_habilitado = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.t_codigo = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(6, 65);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lbDescripcion.TabIndex = 0;
            this.lbDescripcion.Text = "Descripcion";
            // 
            // lbPrecioPublicar
            // 
            this.lbPrecioPublicar.AutoSize = true;
            this.lbPrecioPublicar.Location = new System.Drawing.Point(6, 114);
            this.lbPrecioPublicar.Name = "lbPrecioPublicar";
            this.lbPrecioPublicar.Size = new System.Drawing.Size(96, 13);
            this.lbPrecioPublicar.TabIndex = 2;
            this.lbPrecioPublicar.Text = "Precio por Publicar";
            // 
            // lbPorcentajeVenta
            // 
            this.lbPorcentajeVenta.AutoSize = true;
            this.lbPorcentajeVenta.Location = new System.Drawing.Point(6, 163);
            this.lbPorcentajeVenta.Name = "lbPorcentajeVenta";
            this.lbPorcentajeVenta.Size = new System.Drawing.Size(104, 13);
            this.lbPorcentajeVenta.TabIndex = 4;
            this.lbPorcentajeVenta.Text = "Porcentaje de Venta";
            // 
            // lbDuracion
            // 
            this.lbDuracion.AutoSize = true;
            this.lbDuracion.Location = new System.Drawing.Point(6, 212);
            this.lbDuracion.Name = "lbDuracion";
            this.lbDuracion.Size = new System.Drawing.Size(50, 13);
            this.lbDuracion.TabIndex = 6;
            this.lbDuracion.Text = "Duracion";
            // 
            // t_descripcion
            // 
            this.t_descripcion.Location = new System.Drawing.Point(9, 86);
            this.t_descripcion.Name = "t_descripcion";
            this.t_descripcion.Size = new System.Drawing.Size(245, 20);
            this.t_descripcion.TabIndex = 1;
            // 
            // t_precioPorPublicar
            // 
            this.t_precioPorPublicar.Location = new System.Drawing.Point(9, 135);
            this.t_precioPorPublicar.Name = "t_precioPorPublicar";
            this.t_precioPorPublicar.Size = new System.Drawing.Size(245, 20);
            this.t_precioPorPublicar.TabIndex = 3;
            // 
            // t_porcentajeVenta
            // 
            this.t_porcentajeVenta.Location = new System.Drawing.Point(9, 184);
            this.t_porcentajeVenta.Name = "t_porcentajeVenta";
            this.t_porcentajeVenta.Size = new System.Drawing.Size(245, 20);
            this.t_porcentajeVenta.TabIndex = 5;
            // 
            // t_duracion
            // 
            this.t_duracion.Location = new System.Drawing.Point(9, 233);
            this.t_duracion.Name = "t_duracion";
            this.t_duracion.Size = new System.Drawing.Size(245, 20);
            this.t_duracion.TabIndex = 7;
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(58, 311);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 8;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(163, 311);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 9;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // ch_habilitado
            // 
            this.ch_habilitado.AutoSize = true;
            this.ch_habilitado.Location = new System.Drawing.Point(9, 269);
            this.ch_habilitado.Name = "ch_habilitado";
            this.ch_habilitado.Size = new System.Drawing.Size(73, 17);
            this.ch_habilitado.TabIndex = 10;
            this.ch_habilitado.Text = "Habilitado";
            this.ch_habilitado.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.t_codigo);
            this.groupBox1.Controls.Add(this.lbCodigo);
            this.groupBox1.Controls.Add(this.ch_habilitado);
            this.groupBox1.Controls.Add(this.lbDescripcion);
            this.groupBox1.Controls.Add(this.lbPrecioPublicar);
            this.groupBox1.Controls.Add(this.lbPorcentajeVenta);
            this.groupBox1.Controls.Add(this.t_duracion);
            this.groupBox1.Controls.Add(this.lbDuracion);
            this.groupBox1.Controls.Add(this.t_porcentajeVenta);
            this.groupBox1.Controls.Add(this.t_descripcion);
            this.groupBox1.Controls.Add(this.t_precioPorPublicar);
            this.groupBox1.Location = new System.Drawing.Point(13, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 296);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // t_codigo
            // 
            this.t_codigo.Location = new System.Drawing.Point(9, 37);
            this.t_codigo.Name = "t_codigo";
            this.t_codigo.Size = new System.Drawing.Size(245, 20);
            this.t_codigo.TabIndex = 12;
            this.t_codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(6, 16);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(40, 13);
            this.lbCodigo.TabIndex = 11;
            this.lbCodigo.Text = "Codigo";
            // 
            // AltaVisibilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 349);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.groupBox1);
            this.Name = "AltaVisibilidad";
            this.Text = "Visibilidad";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.Label lbPrecioPublicar;
        private System.Windows.Forms.Label lbPorcentajeVenta;
        private System.Windows.Forms.Label lbDuracion;
        private System.Windows.Forms.TextBox t_descripcion;
        private System.Windows.Forms.TextBox t_precioPorPublicar;
        private System.Windows.Forms.TextBox t_porcentajeVenta;
        private System.Windows.Forms.TextBox t_duracion;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.CheckBox ch_habilitado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox t_codigo;
        private System.Windows.Forms.Label lbCodigo;
    }
}