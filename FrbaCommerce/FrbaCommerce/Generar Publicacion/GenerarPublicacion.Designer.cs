namespace FrbaCommerce.FrbaCommerce.Generar_Publicacion
{
    partial class GenerarPublicacion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ch_preguntasHabilitadas = new System.Windows.Forms.CheckBox();
            this.cb_visibilidad = new System.Windows.Forms.ComboBox();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.cb_tipoPublicacion = new System.Windows.Forms.ComboBox();
            this.l_valor = new System.Windows.Forms.Label();
            this.l_visibilidad = new System.Windows.Forms.Label();
            this.l_estado = new System.Windows.Forms.Label();
            this.l_tipo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.t_valor = new System.Windows.Forms.TextBox();
            this.b_aceptar = new System.Windows.Forms.Button();
            this.b_cancelar = new System.Windows.Forms.Button();
            this.t_stock = new System.Windows.Forms.TextBox();
            this.l_stock = new System.Windows.Forms.Label();
            this.t_descripcion = new System.Windows.Forms.TextBox();
            this.l_descripcion = new System.Windows.Forms.Label();
            this.tb_rolesAsignados = new System.Windows.Forms.DataGridView();
            this.tb_rolesDisponibles = new System.Windows.Forms.DataGridView();
            this.l_roles = new System.Windows.Forms.Label();
            this.l_rolesDisp = new System.Windows.Forms.Label();
            this.b_movDcha = new System.Windows.Forms.Button();
            this.b_movIzq = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_rolesAsignados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_rolesDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_visibilidad);
            this.groupBox1.Controls.Add(this.cb_estado);
            this.groupBox1.Controls.Add(this.cb_tipoPublicacion);
            this.groupBox1.Controls.Add(this.l_visibilidad);
            this.groupBox1.Controls.Add(this.l_estado);
            this.groupBox1.Controls.Add(this.l_tipo);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Publicacion";
            // 
            // ch_preguntasHabilitadas
            // 
            this.ch_preguntasHabilitadas.AutoSize = true;
            this.ch_preguntasHabilitadas.Checked = true;
            this.ch_preguntasHabilitadas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_preguntasHabilitadas.Location = new System.Drawing.Point(113, 18);
            this.ch_preguntasHabilitadas.Name = "ch_preguntasHabilitadas";
            this.ch_preguntasHabilitadas.Size = new System.Drawing.Size(129, 17);
            this.ch_preguntasHabilitadas.TabIndex = 8;
            this.ch_preguntasHabilitadas.Text = "Preguntas Habilitadas";
            this.ch_preguntasHabilitadas.UseVisualStyleBackColor = true;
            // 
            // cb_visibilidad
            // 
            this.cb_visibilidad.FormattingEnabled = true;
            this.cb_visibilidad.Location = new System.Drawing.Point(347, 36);
            this.cb_visibilidad.Name = "cb_visibilidad";
            this.cb_visibilidad.Size = new System.Drawing.Size(150, 21);
            this.cb_visibilidad.TabIndex = 6;
            // 
            // cb_estado
            // 
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Location = new System.Drawing.Point(591, 36);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(150, 21);
            this.cb_estado.TabIndex = 5;
            // 
            // cb_tipoPublicacion
            // 
            this.cb_tipoPublicacion.FormattingEnabled = true;
            this.cb_tipoPublicacion.Location = new System.Drawing.Point(113, 36);
            this.cb_tipoPublicacion.Name = "cb_tipoPublicacion";
            this.cb_tipoPublicacion.Size = new System.Drawing.Size(150, 21);
            this.cb_tipoPublicacion.TabIndex = 4;
            // 
            // l_valor
            // 
            this.l_valor.AutoSize = true;
            this.l_valor.Location = new System.Drawing.Point(29, 56);
            this.l_valor.Name = "l_valor";
            this.l_valor.Size = new System.Drawing.Size(77, 13);
            this.l_valor.TabIndex = 3;
            this.l_valor.Text = "Valor Producto";
            // 
            // l_visibilidad
            // 
            this.l_visibilidad.AutoSize = true;
            this.l_visibilidad.Location = new System.Drawing.Point(288, 39);
            this.l_visibilidad.Name = "l_visibilidad";
            this.l_visibilidad.Size = new System.Drawing.Size(53, 13);
            this.l_visibilidad.TabIndex = 2;
            this.l_visibilidad.Text = "Visibilidad";
            // 
            // l_estado
            // 
            this.l_estado.AutoSize = true;
            this.l_estado.Location = new System.Drawing.Point(545, 39);
            this.l_estado.Name = "l_estado";
            this.l_estado.Size = new System.Drawing.Size(40, 13);
            this.l_estado.TabIndex = 1;
            this.l_estado.Text = "Estado";
            // 
            // l_tipo
            // 
            this.l_tipo.AutoSize = true;
            this.l_tipo.Location = new System.Drawing.Point(5, 39);
            this.l_tipo.Name = "l_tipo";
            this.l_tipo.Size = new System.Drawing.Size(101, 13);
            this.l_tipo.TabIndex = 0;
            this.l_tipo.Text = "Tipo de Publicación";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.b_movIzq);
            this.groupBox2.Controls.Add(this.b_movDcha);
            this.groupBox2.Controls.Add(this.l_rolesDisp);
            this.groupBox2.Controls.Add(this.l_roles);
            this.groupBox2.Controls.Add(this.tb_rolesDisponibles);
            this.groupBox2.Controls.Add(this.tb_rolesAsignados);
            this.groupBox2.Controls.Add(this.ch_preguntasHabilitadas);
            this.groupBox2.Controls.Add(this.l_descripcion);
            this.groupBox2.Controls.Add(this.t_descripcion);
            this.groupBox2.Controls.Add(this.l_stock);
            this.groupBox2.Controls.Add(this.t_stock);
            this.groupBox2.Controls.Add(this.t_valor);
            this.groupBox2.Controls.Add(this.l_valor);
            this.groupBox2.Location = new System.Drawing.Point(13, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(758, 274);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Articulo";
            // 
            // t_valor
            // 
            this.t_valor.Location = new System.Drawing.Point(113, 53);
            this.t_valor.Name = "t_valor";
            this.t_valor.Size = new System.Drawing.Size(150, 20);
            this.t_valor.TabIndex = 7;
            // 
            // b_aceptar
            // 
            this.b_aceptar.Location = new System.Drawing.Point(279, 395);
            this.b_aceptar.Name = "b_aceptar";
            this.b_aceptar.Size = new System.Drawing.Size(75, 23);
            this.b_aceptar.TabIndex = 2;
            this.b_aceptar.Text = "Aceptar";
            this.b_aceptar.UseVisualStyleBackColor = true;
            this.b_aceptar.Click += new System.EventHandler(this.b_aceptar_Click);
            // 
            // b_cancelar
            // 
            this.b_cancelar.Location = new System.Drawing.Point(402, 394);
            this.b_cancelar.Name = "b_cancelar";
            this.b_cancelar.Size = new System.Drawing.Size(75, 23);
            this.b_cancelar.TabIndex = 3;
            this.b_cancelar.Text = "Cancelar";
            this.b_cancelar.UseVisualStyleBackColor = true;
            this.b_cancelar.Click += new System.EventHandler(this.b_cancelar_Click);
            // 
            // t_stock
            // 
            this.t_stock.Location = new System.Drawing.Point(113, 88);
            this.t_stock.Name = "t_stock";
            this.t_stock.Size = new System.Drawing.Size(150, 20);
            this.t_stock.TabIndex = 8;
            // 
            // l_stock
            // 
            this.l_stock.AutoSize = true;
            this.l_stock.Location = new System.Drawing.Point(71, 91);
            this.l_stock.Name = "l_stock";
            this.l_stock.Size = new System.Drawing.Size(35, 13);
            this.l_stock.TabIndex = 10;
            this.l_stock.Text = "Stock";
            // 
            // t_descripcion
            // 
            this.t_descripcion.Location = new System.Drawing.Point(32, 152);
            this.t_descripcion.Multiline = true;
            this.t_descripcion.Name = "t_descripcion";
            this.t_descripcion.Size = new System.Drawing.Size(231, 97);
            this.t_descripcion.TabIndex = 12;
            // 
            // l_descripcion
            // 
            this.l_descripcion.AutoSize = true;
            this.l_descripcion.Location = new System.Drawing.Point(29, 127);
            this.l_descripcion.Name = "l_descripcion";
            this.l_descripcion.Size = new System.Drawing.Size(63, 13);
            this.l_descripcion.TabIndex = 13;
            this.l_descripcion.Text = "Descripcion";
            // 
            // tb_rolesAsignados
            // 
            this.tb_rolesAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_rolesAsignados.Location = new System.Drawing.Point(291, 53);
            this.tb_rolesAsignados.Name = "tb_rolesAsignados";
            this.tb_rolesAsignados.Size = new System.Drawing.Size(206, 196);
            this.tb_rolesAsignados.TabIndex = 14;
            // 
            // tb_rolesDisponibles
            // 
            this.tb_rolesDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_rolesDisponibles.Location = new System.Drawing.Point(548, 53);
            this.tb_rolesDisponibles.Name = "tb_rolesDisponibles";
            this.tb_rolesDisponibles.Size = new System.Drawing.Size(193, 196);
            this.tb_rolesDisponibles.TabIndex = 15;
            // 
            // l_roles
            // 
            this.l_roles.AutoSize = true;
            this.l_roles.Location = new System.Drawing.Point(291, 18);
            this.l_roles.Name = "l_roles";
            this.l_roles.Size = new System.Drawing.Size(34, 13);
            this.l_roles.TabIndex = 16;
            this.l_roles.Text = "Roles";
            // 
            // l_rolesDisp
            // 
            this.l_rolesDisp.AutoSize = true;
            this.l_rolesDisp.Location = new System.Drawing.Point(545, 18);
            this.l_rolesDisp.Name = "l_rolesDisp";
            this.l_rolesDisp.Size = new System.Drawing.Size(91, 13);
            this.l_rolesDisp.TabIndex = 17;
            this.l_rolesDisp.Text = "Roles Disponibles";
            // 
            // b_movDcha
            // 
            this.b_movDcha.Location = new System.Drawing.Point(503, 117);
            this.b_movDcha.Name = "b_movDcha";
            this.b_movDcha.Size = new System.Drawing.Size(39, 23);
            this.b_movDcha.TabIndex = 18;
            this.b_movDcha.Text = ">>";
            this.b_movDcha.UseVisualStyleBackColor = true;
            this.b_movDcha.Click += new System.EventHandler(this.b_movDcha_Click);
            // 
            // b_movIzq
            // 
            this.b_movIzq.Location = new System.Drawing.Point(503, 152);
            this.b_movIzq.Name = "b_movIzq";
            this.b_movIzq.Size = new System.Drawing.Size(39, 23);
            this.b_movIzq.TabIndex = 19;
            this.b_movIzq.Text = "<<";
            this.b_movIzq.UseVisualStyleBackColor = true;
            this.b_movIzq.Click += new System.EventHandler(this.b_movIzq_Click);
            // 
            // GenerarPublicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 433);
            this.Controls.Add(this.b_cancelar);
            this.Controls.Add(this.b_aceptar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GenerarPublicacion";
            this.Text = "GenerarPublicacion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_rolesAsignados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_rolesDisponibles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button b_aceptar;
        private System.Windows.Forms.Button b_cancelar;
        private System.Windows.Forms.CheckBox ch_preguntasHabilitadas;
        private System.Windows.Forms.TextBox t_valor;
        private System.Windows.Forms.ComboBox cb_visibilidad;
        private System.Windows.Forms.ComboBox cb_estado;
        private System.Windows.Forms.ComboBox cb_tipoPublicacion;
        private System.Windows.Forms.Label l_valor;
        private System.Windows.Forms.Label l_visibilidad;
        private System.Windows.Forms.Label l_estado;
        private System.Windows.Forms.Label l_tipo;
        private System.Windows.Forms.Label l_stock;
        private System.Windows.Forms.TextBox t_stock;
        private System.Windows.Forms.TextBox t_descripcion;
        private System.Windows.Forms.Label l_descripcion;
        private System.Windows.Forms.DataGridView tb_rolesDisponibles;
        private System.Windows.Forms.DataGridView tb_rolesAsignados;
        private System.Windows.Forms.Button b_movIzq;
        private System.Windows.Forms.Button b_movDcha;
        private System.Windows.Forms.Label l_rolesDisp;
        private System.Windows.Forms.Label l_roles;
    }
}