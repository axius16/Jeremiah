﻿namespace FrbaCommerce.Abm_Rol
{
    partial class ABMRol
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
            this.bAlta = new System.Windows.Forms.Button();
            this.bModificacion = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.l_rol = new System.Windows.Forms.TextBox();
            this.bBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_roles = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_roles)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bAlta);
            this.panel1.Controls.Add(this.bModificacion);
            this.panel1.Location = new System.Drawing.Point(12, 322);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 45);
            this.panel1.TabIndex = 1;
            // 
            // bAlta
            // 
            this.bAlta.Location = new System.Drawing.Point(72, 0);
            this.bAlta.Name = "bAlta";
            this.bAlta.Size = new System.Drawing.Size(75, 23);
            this.bAlta.TabIndex = 0;
            this.bAlta.Text = "Ingresar";
            this.bAlta.UseVisualStyleBackColor = true;
            this.bAlta.Click += new System.EventHandler(this.bAlta_Click);
            // 
            // bModificacion
            // 
            this.bModificacion.Location = new System.Drawing.Point(153, 0);
            this.bModificacion.Name = "bModificacion";
            this.bModificacion.Size = new System.Drawing.Size(75, 23);
            this.bModificacion.TabIndex = 1;
            this.bModificacion.Text = "Modificar";
            this.bModificacion.UseVisualStyleBackColor = true;
            this.bModificacion.Click += new System.EventHandler(this.bModificacion_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.l_rol);
            this.panel2.Controls.Add(this.bBuscar);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 50);
            this.panel2.TabIndex = 1;
            // 
            // l_rol
            // 
            this.l_rol.Location = new System.Drawing.Point(52, 15);
            this.l_rol.Name = "l_rol";
            this.l_rol.Size = new System.Drawing.Size(179, 20);
            this.l_rol.TabIndex = 7;
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(237, 13);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(23, 23);
            this.bBuscar.TabIndex = 6;
            this.bBuscar.Text = "?";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rol";
            // 
            // tb_roles
            // 
            this.tb_roles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_roles.Location = new System.Drawing.Point(13, 69);
            this.tb_roles.Name = "tb_roles";
            this.tb_roles.Size = new System.Drawing.Size(300, 247);
            this.tb_roles.TabIndex = 2;
            // 
            // ABMRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 379);
            this.Controls.Add(this.tb_roles);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ABMRol";
            this.Text = "ABM Rol";
            this.Load += new System.EventHandler(this.ABMRol_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_roles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bModificacion;
        private System.Windows.Forms.Button bAlta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.TextBox l_rol;
        private System.Windows.Forms.DataGridView tb_roles;
    }
}