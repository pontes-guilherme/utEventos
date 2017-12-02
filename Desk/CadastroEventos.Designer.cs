namespace Desk
{
    partial class CadastroEventos
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
            this.title = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ckbImportante = new System.Windows.Forms.CheckBox();
            this.txtCapacidade = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbEscopo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtCapacidade)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(292, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(130, 18);
            this.title.TabIndex = 10;
            this.title.Text = "Cadastrar Evento";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(250, 332);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(212, 23);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dtInicio
            // 
            this.dtInicio.Location = new System.Drawing.Point(250, 244);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(212, 20);
            this.dtInicio.TabIndex = 12;
            // 
            // dtFim
            // 
            this.dtFim.Location = new System.Drawing.Point(250, 270);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(212, 20);
            this.dtFim.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(250, 164);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(212, 20);
            this.txtNome.TabIndex = 15;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(250, 217);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(212, 21);
            this.cmbCategoria.TabIndex = 16;
            this.cmbCategoria.Text = "Outro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Categoria:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Início:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Fim:";
            // 
            // ckbImportante
            // 
            this.ckbImportante.AutoSize = true;
            this.ckbImportante.Location = new System.Drawing.Point(386, 298);
            this.ckbImportante.Name = "ckbImportante";
            this.ckbImportante.Size = new System.Drawing.Size(76, 17);
            this.ckbImportante.TabIndex = 20;
            this.ckbImportante.Text = "Importante";
            this.ckbImportante.UseVisualStyleBackColor = true;
            // 
            // txtCapacidade
            // 
            this.txtCapacidade.Location = new System.Drawing.Point(250, 296);
            this.txtCapacidade.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtCapacidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCapacidade.Name = "txtCapacidade";
            this.txtCapacidade.Size = new System.Drawing.Size(120, 20);
            this.txtCapacidade.TabIndex = 22;
            this.txtCapacidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Capacidade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Escopo:";
            // 
            // cmbEscopo
            // 
            this.cmbEscopo.FormattingEnabled = true;
            this.cmbEscopo.Items.AddRange(new object[] {
            "Global",
            "Pessoal",
            "Disciplina"});
            this.cmbEscopo.Location = new System.Drawing.Point(250, 190);
            this.cmbEscopo.Name = "cmbEscopo";
            this.cmbEscopo.Size = new System.Drawing.Size(212, 21);
            this.cmbEscopo.TabIndex = 24;
            this.cmbEscopo.Text = "Global";
            // 
            // CadastroEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 522);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbEscopo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCapacidade);
            this.Controls.Add(this.ckbImportante);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtFim);
            this.Controls.Add(this.dtInicio);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastroEventos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CadastroEventos";
            this.Load += new System.EventHandler(this.CadastroEventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCapacidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckbImportante;
        private System.Windows.Forms.NumericUpDown txtCapacidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbEscopo;
    }
}