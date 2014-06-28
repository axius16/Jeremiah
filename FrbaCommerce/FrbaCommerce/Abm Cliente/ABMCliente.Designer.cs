namespace FrbaCommerce.Abm_Cliente
{
    partial class ABMCliente
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
            this.Limpiar = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Button();
            this.l_TipoDocumento = new System.Windows.Forms.ComboBox();
            this.l_NumeroDocumento = new System.Windows.Forms.TextBox();
            this.l_eMail = new System.Windows.Forms.TextBox();
            this.l_Apellido = new System.Windows.Forms.TextBox();
            this.l_Nombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.t_clientes = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_clientes)).BeginInit();
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
            this.bBaja.TabIndex = 11;
            this.bBaja.Text = "Eliminar";
            this.bBaja.UseVisualStyleBackColor = true;
            this.bBaja.Click += new System.EventHandler(this.bBaja_Click);
            // 
            // bAlta
            // 
            this.bAlta.Location = new System.Drawing.Point(135, 3);
            this.bAlta.Name = "bAlta";
            this.bAlta.Size = new System.Drawing.Size(75, 23);
            this.bAlta.TabIndex = 9;
            this.bAlta.Text = "Ingresar";
            this.bAlta.UseVisualStyleBackColor = true;
            this.bAlta.Click += new System.EventHandler(this.bAlta_Click);
            // 
            // bModificacion
            // 
            this.bModificacion.Location = new System.Drawing.Point(240, 3);
            this.bModificacion.Name = "bModificacion";
            this.bModificacion.Size = new System.Drawing.Size(75, 23);
            this.bModificacion.TabIndex = 10;
            this.bModificacion.Text = "Modificar";
            this.bModificacion.UseVisualStyleBackColor = true;
            this.bModificacion.Click += new System.EventHandler(this.bModificacion_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Limpiar);
            this.panel2.Controls.Add(this.Buscar);
            this.panel2.Controls.Add(this.l_TipoDocumento);
            this.panel2.Controls.Add(this.l_NumeroDocumento);
            this.panel2.Controls.Add(this.l_eMail);
            this.panel2.Controls.Add(this.l_Apellido);
            this.panel2.Controls.Add(this.l_Nombre);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(554, 109);
            this.panel2.TabIndex = 1;
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(364, 70);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Limpiar.TabIndex = 7;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(283, 70);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 6;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // l_TipoDocumento
            // 
            this.l_TipoDocumento.FormattingEnabled = true;
            this.l_TipoDocumento.Location = new System.Drawing.Point(364, 15);
            this.l_TipoDocumento.Name = "l_TipoDocumento";
            this.l_TipoDocumento.Size = new System.Drawing.Size(160, 21);
            this.l_TipoDocumento.TabIndex = 4;
            // 
            // l_NumeroDocumento
            // 
            this.l_NumeroDocumento.Location = new System.Drawing.Point(364, 41);
            this.l_NumeroDocumento.Name = "l_NumeroDocumento";
            this.l_NumeroDocumento.Size = new System.Drawing.Size(160, 20);
            this.l_NumeroDocumento.TabIndex = 5;
            // 
            // l_eMail
            // 
            this.l_eMail.Location = new System.Drawing.Point(80, 67);
            this.l_eMail.Name = "l_eMail";
            this.l_eMail.Size = new System.Drawing.Size(160, 20);
            this.l_eMail.TabIndex = 3;
            // 
            // l_Apellido
            // 
            this.l_Apellido.Location = new System.Drawing.Point(80, 41);
            this.l_Apellido.Name = "l_Apellido";
            this.l_Apellido.Size = new System.Drawing.Size(160, 20);
            this.l_Apellido.TabIndex = 2;
            // 
            // l_Nombre
            // 
            this.l_Nombre.Location = new System.Drawing.Point(80, 15);
            this.l_Nombre.Name = "l_Nombre";
            this.l_Nombre.Size = new System.Drawing.Size(160, 20);
            this.l_Nombre.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Numero Documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "eMail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo Documento";
            // 
            // t_clientes
            // 
            this.t_clientes.AllowUserToAddRows = false;
            this.t_clientes.AllowUserToDeleteRows = false;
            this.t_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.t_clientes.Location = new System.Drawing.Point(12, 128);
            this.t_clientes.Name = "t_clientes";
            this.t_clientes.ReadOnly = true;
            this.t_clientes.Size = new System.Drawing.Size(554, 188);
            this.t_clientes.TabIndex = 8;
            this.t_clientes.TabStop = false;
            // 
            // ABMCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 379);
            this.Controls.Add(this.t_clientes);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ABMCliente";
            this.Text = "ABM Clientes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_clientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bBaja;
        private System.Windows.Forms.Button bModificacion;
        private System.Windows.Forms.Button bAlta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox l_TipoDocumento;
        private System.Windows.Forms.TextBox l_NumeroDocumento;
        private System.Windows.Forms.TextBox l_eMail;
        private System.Windows.Forms.TextBox l_Apellido;
        private System.Windows.Forms.TextBox l_Nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.DataGridView t_clientes;
    }
}