namespace Desk
{
    partial class VisualizarCalendario
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
            this.components = new System.ComponentModel.Container();
            this.title = new System.Windows.Forms.Label();
            this.dbEventosDataSet = new Desk.dbEventosDataSet();
            this.eventosTableAdapter1 = new Desk.dbEventosDataSetTableAdapters.EventosTableAdapter();
            this.rdbDia = new System.Windows.Forms.RadioButton();
            this.rdbSemana = new System.Windows.Forms.RadioButton();
            this.rdbMes = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbDisciplina = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbEscopo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCapacidade = new System.Windows.Forms.NumericUpDown();
            this.ckbImportante = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.eventosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnInscricao = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVagas = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dbEventosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCapacidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVagas)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(290, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(85, 18);
            this.title.TabIndex = 13;
            this.title.Text = "Calendário";
            // 
            // dbEventosDataSet
            // 
            this.dbEventosDataSet.DataSetName = "dbEventosDataSet";
            this.dbEventosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventosTableAdapter1
            // 
            this.eventosTableAdapter1.ClearBeforeFill = true;
            // 
            // rdbDia
            // 
            this.rdbDia.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbDia.AutoSize = true;
            this.rdbDia.Checked = true;
            this.rdbDia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdbDia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdbDia.Location = new System.Drawing.Point(12, 53);
            this.rdbDia.Name = "rdbDia";
            this.rdbDia.Size = new System.Drawing.Size(90, 23);
            this.rdbDia.TabIndex = 14;
            this.rdbDia.TabStop = true;
            this.rdbDia.Text = "Eventos do Dia";
            this.rdbDia.UseVisualStyleBackColor = true;
            this.rdbDia.CheckedChanged += new System.EventHandler(this.rdbDia_CheckedChanged);
            // 
            // rdbSemana
            // 
            this.rdbSemana.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbSemana.AutoSize = true;
            this.rdbSemana.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdbSemana.Location = new System.Drawing.Point(108, 53);
            this.rdbSemana.Name = "rdbSemana";
            this.rdbSemana.Size = new System.Drawing.Size(113, 23);
            this.rdbSemana.TabIndex = 15;
            this.rdbSemana.Text = "Eventos da Semana";
            this.rdbSemana.UseVisualStyleBackColor = true;
            this.rdbSemana.CheckedChanged += new System.EventHandler(this.rdbSemana_CheckedChanged);
            // 
            // rdbMes
            // 
            this.rdbMes.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbMes.AutoSize = true;
            this.rdbMes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdbMes.Location = new System.Drawing.Point(227, 53);
            this.rdbMes.Name = "rdbMes";
            this.rdbMes.Size = new System.Drawing.Size(94, 23);
            this.rdbMes.TabIndex = 16;
            this.rdbMes.Text = "Eventos do Mês";
            this.rdbMes.UseVisualStyleBackColor = true;
            this.rdbMes.CheckedChanged += new System.EventHandler(this.rdbMes_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 60;
            this.label7.Text = "Eventos Criados:";
            // 
            // cmbDisciplina
            // 
            this.cmbDisciplina.Enabled = false;
            this.cmbDisciplina.FormattingEnabled = true;
            this.cmbDisciplina.Location = new System.Drawing.Point(486, 137);
            this.cmbDisciplina.Name = "cmbDisciplina";
            this.cmbDisciplina.Size = new System.Drawing.Size(166, 21);
            this.cmbDisciplina.TabIndex = 59;
            this.cmbDisciplina.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(216, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "Escopo:";
            // 
            // cmbEscopo
            // 
            this.cmbEscopo.Enabled = false;
            this.cmbEscopo.FormattingEnabled = true;
            this.cmbEscopo.Items.AddRange(new object[] {
            "Global",
            "Pessoal",
            "Disciplina"});
            this.cmbEscopo.Location = new System.Drawing.Point(268, 137);
            this.cmbEscopo.Name = "cmbEscopo";
            this.cmbEscopo.Size = new System.Drawing.Size(212, 21);
            this.cmbEscopo.TabIndex = 57;
            this.cmbEscopo.Text = "Global";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(195, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Capacidade:";
            // 
            // txtCapacidade
            // 
            this.txtCapacidade.Enabled = false;
            this.txtCapacidade.Location = new System.Drawing.Point(268, 243);
            this.txtCapacidade.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtCapacidade.Name = "txtCapacidade";
            this.txtCapacidade.Size = new System.Drawing.Size(120, 20);
            this.txtCapacidade.TabIndex = 55;
            this.txtCapacidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ckbImportante
            // 
            this.ckbImportante.AutoSize = true;
            this.ckbImportante.Enabled = false;
            this.ckbImportante.Location = new System.Drawing.Point(404, 245);
            this.ckbImportante.Name = "ckbImportante";
            this.ckbImportante.Size = new System.Drawing.Size(76, 17);
            this.ckbImportante.TabIndex = 54;
            this.ckbImportante.Text = "Importante";
            this.ckbImportante.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(236, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Fim:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(225, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Início:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(207, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Categoria:";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Enabled = false;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(268, 164);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(212, 21);
            this.cmbCategoria.TabIndex = 50;
            this.cmbCategoria.Text = "Outro";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(268, 111);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(212, 20);
            this.txtNome.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(224, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Nome:";
            // 
            // dtFim
            // 
            this.dtFim.Enabled = false;
            this.dtFim.Location = new System.Drawing.Point(268, 217);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(212, 20);
            this.dtFim.TabIndex = 47;
            // 
            // dtInicio
            // 
            this.dtInicio.Enabled = false;
            this.dtInicio.Location = new System.Drawing.Point(268, 191);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(212, 20);
            this.dtInicio.TabIndex = 46;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.eventosBindingSource1;
            this.listBox1.DisplayMember = "nome";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 111);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(165, 329);
            this.listBox1.TabIndex = 44;
            this.listBox1.ValueMember = "id";
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // eventosBindingSource1
            // 
            this.eventosBindingSource1.DataMember = "Eventos";
            this.eventosBindingSource1.DataSource = this.dbEventosDataSet;
            // 
            // btnInscricao
            // 
            this.btnInscricao.Location = new System.Drawing.Point(268, 308);
            this.btnInscricao.Name = "btnInscricao";
            this.btnInscricao.Size = new System.Drawing.Size(212, 23);
            this.btnInscricao.TabIndex = 61;
            this.btnInscricao.Text = "Inscrever-se";
            this.btnInscricao.UseVisualStyleBackColor = true;
            this.btnInscricao.Click += new System.EventHandler(this.btnInscricao_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Location = new System.Drawing.Point(219, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 62;
            this.label8.Text = "Vagas: ";
            // 
            // txtVagas
            // 
            this.txtVagas.Enabled = false;
            this.txtVagas.Location = new System.Drawing.Point(268, 272);
            this.txtVagas.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtVagas.Name = "txtVagas";
            this.txtVagas.ReadOnly = true;
            this.txtVagas.Size = new System.Drawing.Size(120, 20);
            this.txtVagas.TabIndex = 63;
            this.txtVagas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // VisualizarCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 452);
            this.Controls.Add(this.txtVagas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnInscricao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbDisciplina);
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
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.rdbMes);
            this.Controls.Add(this.rdbSemana);
            this.Controls.Add(this.rdbDia);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VisualizarCalendario";
            this.Text = "VisualizarCalendario";
            this.Load += new System.EventHandler(this.VisualizarCalendario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbEventosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCapacidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVagas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private dbEventosDataSet dbEventosDataSet;
        private dbEventosDataSetTableAdapters.EventosTableAdapter eventosTableAdapter1;
        private System.Windows.Forms.RadioButton rdbDia;
        private System.Windows.Forms.RadioButton rdbSemana;
        private System.Windows.Forms.RadioButton rdbMes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbDisciplina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbEscopo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown txtCapacidade;
        private System.Windows.Forms.CheckBox ckbImportante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource eventosBindingSource1;
        private System.Windows.Forms.Button btnInscricao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown txtVagas;
    }
}