namespace FrbaCommerce.FrbaCommerce.RegistroUsuario
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
            this.rb_ninguno = new System.Windows.Forms.RadioButton();
            this.rb_empresa = new System.Windows.Forms.RadioButton();
            this.rb_cliente = new System.Windows.Forms.RadioButton();
            this.bQuitar = new System.Windows.Forms.Button();
            this.bAgregar = new System.Windows.Forms.Button();
            this.l_roles = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.l_password = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.l_usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bCancelar = new System.Windows.Forms.Button();
            this.l_habilitado = new System.Windows.Forms.CheckBox();
            this.l_detalle = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(123, 344);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 14;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.l_detalle);
            this.groupBox1.Controls.Add(this.l_habilitado);
            this.groupBox1.Controls.Add(this.rb_ninguno);
            this.groupBox1.Controls.Add(this.rb_empresa);
            this.groupBox1.Controls.Add(this.rb_cliente);
            this.groupBox1.Controls.Add(this.bQuitar);
            this.groupBox1.Controls.Add(this.bAgregar);
            this.groupBox1.Controls.Add(this.l_roles);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.l_password);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.l_usuario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 326);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro Usuario";
            // 
            // rb_ninguno
            // 
            this.rb_ninguno.AutoSize = true;
            this.rb_ninguno.Location = new System.Drawing.Point(110, 236);
            this.rb_ninguno.Name = "rb_ninguno";
            this.rb_ninguno.Size = new System.Drawing.Size(65, 17);
            this.rb_ninguno.TabIndex = 59;
            this.rb_ninguno.TabStop = true;
            this.rb_ninguno.Text = "Ninguno";
            this.rb_ninguno.UseVisualStyleBackColor = true;
            // 
            // rb_empresa
            // 
            this.rb_empresa.AutoSize = true;
            this.rb_empresa.Location = new System.Drawing.Point(110, 212);
            this.rb_empresa.Name = "rb_empresa";
            this.rb_empresa.Size = new System.Drawing.Size(120, 17);
            this.rb_empresa.TabIndex = 58;
            this.rb_empresa.TabStop = true;
            this.rb_empresa.Text = "Usuario de Empresa";
            this.rb_empresa.UseVisualStyleBackColor = true;
            // 
            // rb_cliente
            // 
            this.rb_cliente.AutoSize = true;
            this.rb_cliente.Location = new System.Drawing.Point(110, 188);
            this.rb_cliente.Name = "rb_cliente";
            this.rb_cliente.Size = new System.Drawing.Size(111, 17);
            this.rb_cliente.TabIndex = 57;
            this.rb_cliente.TabStop = true;
            this.rb_cliente.Text = "Usuario de Cliente";
            this.rb_cliente.UseVisualStyleBackColor = true;
            // 
            // bQuitar
            // 
            this.bQuitar.Location = new System.Drawing.Point(266, 145);
            this.bQuitar.Name = "bQuitar";
            this.bQuitar.Size = new System.Drawing.Size(75, 23);
            this.bQuitar.TabIndex = 56;
            this.bQuitar.Text = "Quitar";
            this.bQuitar.UseVisualStyleBackColor = true;
            this.bQuitar.Click += new System.EventHandler(this.bQuitar_Click);
            // 
            // bAgregar
            // 
            this.bAgregar.Location = new System.Drawing.Point(185, 145);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(75, 23);
            this.bAgregar.TabIndex = 55;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // l_roles
            // 
            this.l_roles.FormattingEnabled = true;
            this.l_roles.Location = new System.Drawing.Point(110, 83);
            this.l_roles.Name = "l_roles";
            this.l_roles.Size = new System.Drawing.Size(231, 56);
            this.l_roles.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Roles";
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
            this.bCancelar.Location = new System.Drawing.Point(220, 344);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 16;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // l_habilitado
            // 
            this.l_habilitado.AutoSize = true;
            this.l_habilitado.Location = new System.Drawing.Point(110, 294);
            this.l_habilitado.Name = "l_habilitado";
            this.l_habilitado.Size = new System.Drawing.Size(112, 17);
            this.l_habilitado.TabIndex = 61;
            this.l_habilitado.Text = "Usuario Habilitado";
            this.l_habilitado.UseVisualStyleBackColor = true;
            // 
            // l_detalle
            // 
            this.l_detalle.AutoSize = true;
            this.l_detalle.Location = new System.Drawing.Point(107, 269);
            this.l_detalle.Name = "l_detalle";
            this.l_detalle.Size = new System.Drawing.Size(43, 13);
            this.l_detalle.TabIndex = 62;
            this.l_detalle.Text = "Detalle:";
            // 
            // AltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 379);
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
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.TextBox l_password;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button bQuitar;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.ListBox l_roles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_ninguno;
        private System.Windows.Forms.RadioButton rb_empresa;
        private System.Windows.Forms.RadioButton rb_cliente;
        private System.Windows.Forms.CheckBox l_habilitado;
        private System.Windows.Forms.Label l_detalle;

    }
}