namespace FrbaCommerce.FrbaCommerce.Asignacion_telefonos
{
    partial class Form1
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
            this.bDesasignar = new System.Windows.Forms.Button();
            this.bCerrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bBuscar = new System.Windows.Forms.Button();
            this.l_buscar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.l_estadoAsignacion = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bDesasignar);
            this.panel1.Controls.Add(this.bCerrar);
            this.panel1.Location = new System.Drawing.Point(12, 289);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 78);
            this.panel1.TabIndex = 1;
            // 
            // bDesasignar
            // 
            this.bDesasignar.Location = new System.Drawing.Point(22, 0);
            this.bDesasignar.Name = "bDesasignar";
            this.bDesasignar.Size = new System.Drawing.Size(75, 23);
            this.bDesasignar.TabIndex = 0;
            this.bDesasignar.Text = "Desasignar";
            this.bDesasignar.UseVisualStyleBackColor = true;
            this.bDesasignar.Click += new System.EventHandler(this.button1_Click);
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(118, 52);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(75, 23);
            this.bCerrar.TabIndex = 1;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bModificacion_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.l_estadoAsignacion);
            this.panel2.Controls.Add(this.bBuscar);
            this.panel2.Controls.Add(this.l_buscar);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(311, 98);
            this.panel2.TabIndex = 1;
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(74, 41);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(84, 23);
            this.bBuscar.TabIndex = 10;
            this.bBuscar.Text = "Asignar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // l_buscar
            // 
            this.l_buscar.Location = new System.Drawing.Point(74, 15);
            this.l_buscar.Name = "l_buscar";
            this.l_buscar.Size = new System.Drawing.Size(214, 20);
            this.l_buscar.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefonos Asignados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefono";
            // 
            // l_estadoAsignacion
            // 
            this.l_estadoAsignacion.AutoSize = true;
            this.l_estadoAsignacion.Location = new System.Drawing.Point(177, 46);
            this.l_estadoAsignacion.Name = "l_estadoAsignacion";
            this.l_estadoAsignacion.Size = new System.Drawing.Size(22, 13);
            this.l_estadoAsignacion.TabIndex = 11;
            this.l_estadoAsignacion.Text = "OK";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 378);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Asignar Telefonos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.Button bDesasignar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox l_buscar;        
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.Label l_estadoAsignacion;
    }
}