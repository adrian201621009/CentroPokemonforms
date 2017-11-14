namespace CentroPokemonforms
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btntipo = new System.Windows.Forms.Button();
            this.btnestado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.txthp = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.txtdatos = new System.Windows.Forms.TextBox();
            this.atendidos = new System.Windows.Forms.Button();
            this.btnhp = new System.Windows.Forms.Button();
            this.btninfectados = new System.Windows.Forms.Button();
            this.cbotipo = new System.Windows.Forms.ComboBox();
            this.cboestado = new System.Windows.Forms.ComboBox();
            this.cbopokerus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btntipo
            // 
            this.btntipo.Location = new System.Drawing.Point(481, 202);
            this.btntipo.Name = "btntipo";
            this.btntipo.Size = new System.Drawing.Size(75, 23);
            this.btntipo.TabIndex = 0;
            this.btntipo.Text = "Tipo";
            this.btntipo.UseVisualStyleBackColor = true;
            this.btntipo.Click += new System.EventHandler(this.btntipo_Click);
            // 
            // btnestado
            // 
            this.btnestado.Location = new System.Drawing.Point(578, 202);
            this.btnestado.Name = "btnestado";
            this.btnestado.Size = new System.Drawing.Size(75, 23);
            this.btnestado.TabIndex = 2;
            this.btnestado.Text = "Estado";
            this.btnestado.UseVisualStyleBackColor = true;
            this.btnestado.Click += new System.EventHandler(this.btnestado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre del Pokemon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numero de Pokemon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "HP del Pokemon";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(121, 12);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 6;
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(121, 47);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(100, 20);
            this.txtnumero.TabIndex = 7;
            // 
            // txthp
            // 
            this.txthp.Location = new System.Drawing.Point(121, 73);
            this.txthp.Name = "txthp";
            this.txthp.Size = new System.Drawing.Size(100, 20);
            this.txthp.TabIndex = 8;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(643, 23);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 9;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // txtdatos
            // 
            this.txtdatos.Location = new System.Drawing.Point(258, 11);
            this.txtdatos.Multiline = true;
            this.txtdatos.Name = "txtdatos";
            this.txtdatos.Size = new System.Drawing.Size(357, 176);
            this.txtdatos.TabIndex = 10;
            // 
            // atendidos
            // 
            this.atendidos.Location = new System.Drawing.Point(400, 202);
            this.atendidos.Name = "atendidos";
            this.atendidos.Size = new System.Drawing.Size(75, 23);
            this.atendidos.TabIndex = 11;
            this.atendidos.Text = "Atendidos";
            this.atendidos.UseVisualStyleBackColor = true;
            this.atendidos.Click += new System.EventHandler(this.atendidos_Click);
            // 
            // btnhp
            // 
            this.btnhp.Location = new System.Drawing.Point(319, 202);
            this.btnhp.Name = "btnhp";
            this.btnhp.Size = new System.Drawing.Size(75, 23);
            this.btnhp.TabIndex = 12;
            this.btnhp.Text = "Hp = 0";
            this.btnhp.UseVisualStyleBackColor = true;
            this.btnhp.Click += new System.EventHandler(this.btnhp_Click);
            // 
            // btninfectados
            // 
            this.btninfectados.Location = new System.Drawing.Point(179, 201);
            this.btninfectados.Name = "btninfectados";
            this.btninfectados.Size = new System.Drawing.Size(134, 23);
            this.btninfectados.TabIndex = 13;
            this.btninfectados.Text = "Infectados de Pokerus";
            this.btninfectados.UseVisualStyleBackColor = true;
            this.btninfectados.Click += new System.EventHandler(this.btninfectados_Click);
            // 
            // cbotipo
            // 
            this.cbotipo.FormattingEnabled = true;
            this.cbotipo.Location = new System.Drawing.Point(121, 110);
            this.cbotipo.Name = "cbotipo";
            this.cbotipo.Size = new System.Drawing.Size(121, 21);
            this.cbotipo.TabIndex = 14;
            // 
            // cboestado
            // 
            this.cboestado.FormattingEnabled = true;
            this.cboestado.Location = new System.Drawing.Point(121, 138);
            this.cboestado.Name = "cboestado";
            this.cboestado.Size = new System.Drawing.Size(121, 21);
            this.cboestado.TabIndex = 15;
            // 
            // cbopokerus
            // 
            this.cbopokerus.FormattingEnabled = true;
            this.cbopokerus.Location = new System.Drawing.Point(121, 165);
            this.cbopokerus.Name = "cbopokerus";
            this.cbopokerus.Size = new System.Drawing.Size(121, 21);
            this.cbopokerus.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Pokerus";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Estado de Pokemon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tipo de Pokemon";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(764, 261);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbopokerus);
            this.Controls.Add(this.cboestado);
            this.Controls.Add(this.cbotipo);
            this.Controls.Add(this.btninfectados);
            this.Controls.Add(this.btnhp);
            this.Controls.Add(this.atendidos);
            this.Controls.Add(this.txtdatos);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txthp);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnestado);
            this.Controls.Add(this.btntipo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntipo;
        private System.Windows.Forms.Button btnestado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.TextBox txthp;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.TextBox txtdatos;
        private System.Windows.Forms.Button atendidos;
        private System.Windows.Forms.Button btnhp;
        private System.Windows.Forms.Button btninfectados;
        private System.Windows.Forms.ComboBox cbotipo;
        private System.Windows.Forms.ComboBox cboestado;
        private System.Windows.Forms.ComboBox cbopokerus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

