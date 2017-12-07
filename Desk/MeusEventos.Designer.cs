namespace Desk
{
    partial class MeusEventos
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.eventosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbEventosDataSet = new Desk.dbEventosDataSet();
            this.eventosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventosTableAdapter = new Desk.dbEventosDataSetTableAdapters.EventosTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
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
            this.cmbEscopo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDisciplina = new System.Windows.Forms.ComboBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.cmbPesquisar = new System.Windows.Forms.ComboBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.fillByNameToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.nomeToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.nomeToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.fillByNameToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.fillByMonthSearchToolStrip = new System.Windows.Forms.ToolStrip();
            this.mesToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.mesToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByMonthSearchToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillByNameAdminToolStrip = new System.Windows.Forms.ToolStrip();
            this.nomeToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nomeToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByNameAdminToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillByMonthAdminToolStrip = new System.Windows.Forms.ToolStrip();
            this.mesToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.mesToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.fillByMonthAdminToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillByClassAdminToolStrip = new System.Windows.Forms.ToolStrip();
            this.disciplinaToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.disciplinaToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByClassAdminToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEventosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCapacidade)).BeginInit();
            this.fillByNameToolStrip1.SuspendLayout();
            this.fillByMonthSearchToolStrip.SuspendLayout();
            this.fillByNameAdminToolStrip.SuspendLayout();
            this.fillByMonthAdminToolStrip.SuspendLayout();
            this.fillByClassAdminToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(287, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(106, 18);
            this.title.TabIndex = 12;
            this.title.Text = "Meus Eventos";
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.eventosBindingSource1;
            this.listBox1.DisplayMember = "nome";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(34, 138);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(165, 329);
            this.listBox1.TabIndex = 13;
            this.listBox1.ValueMember = "id";
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // eventosBindingSource1
            // 
            this.eventosBindingSource1.DataMember = "Eventos";
            this.eventosBindingSource1.DataSource = this.dbEventosDataSet;
            // 
            // dbEventosDataSet
            // 
            this.dbEventosDataSet.DataSetName = "dbEventosDataSet";
            this.dbEventosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventosBindingSource
            // 
            this.eventosBindingSource.DataMember = "Eventos";
            this.eventosBindingSource.DataSource = this.dbEventosDataSet;
            // 
            // eventosTableAdapter
            // 
            this.eventosTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Eventos Criados:";
            // 
            // dtInicio
            // 
            this.dtInicio.Location = new System.Drawing.Point(290, 165);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(212, 20);
            this.dtInicio.TabIndex = 29;
            // 
            // dtFim
            // 
            this.dtFim.Location = new System.Drawing.Point(290, 191);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(212, 20);
            this.dtFim.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(290, 85);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(212, 20);
            this.txtNome.TabIndex = 32;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(290, 138);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(212, 21);
            this.cmbCategoria.TabIndex = 33;
            this.cmbCategoria.Text = "Outro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Categoria:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Início:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Fim:";
            // 
            // ckbImportante
            // 
            this.ckbImportante.AutoSize = true;
            this.ckbImportante.Location = new System.Drawing.Point(426, 219);
            this.ckbImportante.Name = "ckbImportante";
            this.ckbImportante.Size = new System.Drawing.Size(76, 17);
            this.ckbImportante.TabIndex = 37;
            this.ckbImportante.Text = "Importante";
            this.ckbImportante.UseVisualStyleBackColor = true;
            // 
            // txtCapacidade
            // 
            this.txtCapacidade.Location = new System.Drawing.Point(290, 217);
            this.txtCapacidade.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtCapacidade.Name = "txtCapacidade";
            this.txtCapacidade.Size = new System.Drawing.Size(120, 20);
            this.txtCapacidade.TabIndex = 38;
            this.txtCapacidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Capacidade:";
            // 
            // cmbEscopo
            // 
            this.cmbEscopo.FormattingEnabled = true;
            this.cmbEscopo.Items.AddRange(new object[] {
            "Global",
            "Pessoal",
            "Disciplina"});
            this.cmbEscopo.Location = new System.Drawing.Point(290, 111);
            this.cmbEscopo.Name = "cmbEscopo";
            this.cmbEscopo.Size = new System.Drawing.Size(212, 21);
            this.cmbEscopo.TabIndex = 40;
            this.cmbEscopo.Text = "Global";
            this.cmbEscopo.SelectedIndexChanged += new System.EventHandler(this.cmbEscopo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Escopo:";
            // 
            // cmbDisciplina
            // 
            this.cmbDisciplina.FormattingEnabled = true;
            this.cmbDisciplina.Location = new System.Drawing.Point(508, 111);
            this.cmbDisciplina.Name = "cmbDisciplina";
            this.cmbDisciplina.Size = new System.Drawing.Size(166, 21);
            this.cmbDisciplina.TabIndex = 42;
            this.cmbDisciplina.Visible = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(290, 252);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(212, 23);
            this.btnAlterar.TabIndex = 44;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click_1);
            // 
            // cmbPesquisar
            // 
            this.cmbPesquisar.FormattingEnabled = true;
            this.cmbPesquisar.Items.AddRange(new object[] {
            "Nome",
            "Mês",
            "Disciplina"});
            this.cmbPesquisar.Location = new System.Drawing.Point(34, 88);
            this.cmbPesquisar.Name = "cmbPesquisar";
            this.cmbPesquisar.Size = new System.Drawing.Size(58, 21);
            this.cmbPesquisar.TabIndex = 45;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(98, 88);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(101, 20);
            this.txtPesquisar.TabIndex = 46;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(34, 111);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(165, 21);
            this.btnPesquisar.TabIndex = 47;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // fillByNameToolStrip1
            // 
            this.fillByNameToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nomeToolStripLabel1,
            this.nomeToolStripTextBox1,
            this.fillByNameToolStripButton1});
            this.fillByNameToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.fillByNameToolStrip1.Name = "fillByNameToolStrip1";
            this.fillByNameToolStrip1.Size = new System.Drawing.Size(697, 25);
            this.fillByNameToolStrip1.TabIndex = 49;
            this.fillByNameToolStrip1.Text = "fillByNameToolStrip1";
            this.fillByNameToolStrip1.Visible = false;
            // 
            // nomeToolStripLabel1
            // 
            this.nomeToolStripLabel1.Name = "nomeToolStripLabel1";
            this.nomeToolStripLabel1.Size = new System.Drawing.Size(41, 22);
            this.nomeToolStripLabel1.Text = "nome:";
            // 
            // nomeToolStripTextBox1
            // 
            this.nomeToolStripTextBox1.Name = "nomeToolStripTextBox1";
            this.nomeToolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByNameToolStripButton1
            // 
            this.fillByNameToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByNameToolStripButton1.Name = "fillByNameToolStripButton1";
            this.fillByNameToolStripButton1.Size = new System.Drawing.Size(71, 22);
            this.fillByNameToolStripButton1.Text = "FillByName";
            this.fillByNameToolStripButton1.Click += new System.EventHandler(this.fillByNameToolStripButton1_Click);
            // 
            // fillByMonthSearchToolStrip
            // 
            this.fillByMonthSearchToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mesToolStripLabel,
            this.mesToolStripTextBox,
            this.fillByMonthSearchToolStripButton});
            this.fillByMonthSearchToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByMonthSearchToolStrip.Name = "fillByMonthSearchToolStrip";
            this.fillByMonthSearchToolStrip.Size = new System.Drawing.Size(697, 25);
            this.fillByMonthSearchToolStrip.TabIndex = 50;
            this.fillByMonthSearchToolStrip.Text = "fillByMonthSearchToolStrip";
            this.fillByMonthSearchToolStrip.Visible = false;
            // 
            // mesToolStripLabel
            // 
            this.mesToolStripLabel.Name = "mesToolStripLabel";
            this.mesToolStripLabel.Size = new System.Drawing.Size(32, 22);
            this.mesToolStripLabel.Text = "mes:";
            // 
            // mesToolStripTextBox
            // 
            this.mesToolStripTextBox.Name = "mesToolStripTextBox";
            this.mesToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByMonthSearchToolStripButton
            // 
            this.fillByMonthSearchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByMonthSearchToolStripButton.Name = "fillByMonthSearchToolStripButton";
            this.fillByMonthSearchToolStripButton.Size = new System.Drawing.Size(110, 22);
            this.fillByMonthSearchToolStripButton.Text = "FillByMonthSearch";
            this.fillByMonthSearchToolStripButton.Click += new System.EventHandler(this.fillByMonthSearchToolStripButton_Click);
            // 
            // fillByNameAdminToolStrip
            // 
            this.fillByNameAdminToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nomeToolStripLabel,
            this.nomeToolStripTextBox,
            this.fillByNameAdminToolStripButton});
            this.fillByNameAdminToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByNameAdminToolStrip.Name = "fillByNameAdminToolStrip";
            this.fillByNameAdminToolStrip.Size = new System.Drawing.Size(697, 25);
            this.fillByNameAdminToolStrip.TabIndex = 51;
            this.fillByNameAdminToolStrip.Text = "fillByNameAdminToolStrip";
            this.fillByNameAdminToolStrip.Visible = false;
            // 
            // nomeToolStripLabel
            // 
            this.nomeToolStripLabel.Name = "nomeToolStripLabel";
            this.nomeToolStripLabel.Size = new System.Drawing.Size(41, 22);
            this.nomeToolStripLabel.Text = "nome:";
            // 
            // nomeToolStripTextBox
            // 
            this.nomeToolStripTextBox.Name = "nomeToolStripTextBox";
            this.nomeToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByNameAdminToolStripButton
            // 
            this.fillByNameAdminToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByNameAdminToolStripButton.Name = "fillByNameAdminToolStripButton";
            this.fillByNameAdminToolStripButton.Size = new System.Drawing.Size(107, 22);
            this.fillByNameAdminToolStripButton.Text = "FillByNameAdmin";
            this.fillByNameAdminToolStripButton.Click += new System.EventHandler(this.fillByNameAdminToolStripButton_Click);
            // 
            // fillByMonthAdminToolStrip
            // 
            this.fillByMonthAdminToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mesToolStripLabel1,
            this.mesToolStripTextBox1,
            this.fillByMonthAdminToolStripButton});
            this.fillByMonthAdminToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByMonthAdminToolStrip.Name = "fillByMonthAdminToolStrip";
            this.fillByMonthAdminToolStrip.Size = new System.Drawing.Size(697, 25);
            this.fillByMonthAdminToolStrip.TabIndex = 52;
            this.fillByMonthAdminToolStrip.Text = "fillByMonthAdminToolStrip";
            this.fillByMonthAdminToolStrip.Visible = false;
            // 
            // mesToolStripLabel1
            // 
            this.mesToolStripLabel1.Name = "mesToolStripLabel1";
            this.mesToolStripLabel1.Size = new System.Drawing.Size(32, 22);
            this.mesToolStripLabel1.Text = "mes:";
            // 
            // mesToolStripTextBox1
            // 
            this.mesToolStripTextBox1.Name = "mesToolStripTextBox1";
            this.mesToolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByMonthAdminToolStripButton
            // 
            this.fillByMonthAdminToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByMonthAdminToolStripButton.Name = "fillByMonthAdminToolStripButton";
            this.fillByMonthAdminToolStripButton.Size = new System.Drawing.Size(111, 22);
            this.fillByMonthAdminToolStripButton.Text = "FillByMonthAdmin";
            this.fillByMonthAdminToolStripButton.Click += new System.EventHandler(this.fillByMonthAdminToolStripButton_Click);
            // 
            // fillByClassAdminToolStrip
            // 
            this.fillByClassAdminToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disciplinaToolStripLabel,
            this.disciplinaToolStripTextBox,
            this.fillByClassAdminToolStripButton});
            this.fillByClassAdminToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByClassAdminToolStrip.Name = "fillByClassAdminToolStrip";
            this.fillByClassAdminToolStrip.Size = new System.Drawing.Size(697, 25);
            this.fillByClassAdminToolStrip.TabIndex = 53;
            this.fillByClassAdminToolStrip.Text = "fillByClassAdminToolStrip";
            this.fillByClassAdminToolStrip.Visible = false;
            // 
            // disciplinaToolStripLabel
            // 
            this.disciplinaToolStripLabel.Name = "disciplinaToolStripLabel";
            this.disciplinaToolStripLabel.Size = new System.Drawing.Size(60, 22);
            this.disciplinaToolStripLabel.Text = "disciplina:";
            // 
            // disciplinaToolStripTextBox
            // 
            this.disciplinaToolStripTextBox.Name = "disciplinaToolStripTextBox";
            this.disciplinaToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByClassAdminToolStripButton
            // 
            this.fillByClassAdminToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByClassAdminToolStripButton.Name = "fillByClassAdminToolStripButton";
            this.fillByClassAdminToolStripButton.Size = new System.Drawing.Size(102, 22);
            this.fillByClassAdminToolStripButton.Text = "FillByClassAdmin";
            this.fillByClassAdminToolStripButton.Click += new System.EventHandler(this.fillByClassAdminToolStripButton_Click);
            // 
            // MeusEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 487);
            this.Controls.Add(this.fillByNameToolStrip1);
            this.Controls.Add(this.fillByMonthSearchToolStrip);
            this.Controls.Add(this.fillByNameAdminToolStrip);
            this.Controls.Add(this.fillByMonthAdminToolStrip);
            this.Controls.Add(this.fillByClassAdminToolStrip);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.cmbPesquisar);
            this.Controls.Add(this.btnAlterar);
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
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MeusEventos";
            this.Text = "MeusEventos";
            this.Load += new System.EventHandler(this.MeusEventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEventosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCapacidade)).EndInit();
            this.fillByNameToolStrip1.ResumeLayout(false);
            this.fillByNameToolStrip1.PerformLayout();
            this.fillByMonthSearchToolStrip.ResumeLayout(false);
            this.fillByMonthSearchToolStrip.PerformLayout();
            this.fillByNameAdminToolStrip.ResumeLayout(false);
            this.fillByNameAdminToolStrip.PerformLayout();
            this.fillByMonthAdminToolStrip.ResumeLayout(false);
            this.fillByMonthAdminToolStrip.PerformLayout();
            this.fillByClassAdminToolStrip.ResumeLayout(false);
            this.fillByClassAdminToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.ListBox listBox1;
        private dbEventosDataSet dbEventosDataSet;
        private System.Windows.Forms.BindingSource eventosBindingSource;
        private dbEventosDataSetTableAdapters.EventosTableAdapter eventosTableAdapter;
        private System.Windows.Forms.Label label7;
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
        private System.Windows.Forms.ComboBox cmbEscopo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDisciplina;
        private System.Windows.Forms.BindingSource eventosBindingSource1;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.ComboBox cmbPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ToolStrip fillByNameToolStrip1;
        private System.Windows.Forms.ToolStripLabel nomeToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox nomeToolStripTextBox1;
        private System.Windows.Forms.ToolStripButton fillByNameToolStripButton1;
        private System.Windows.Forms.ToolStrip fillByMonthSearchToolStrip;
        private System.Windows.Forms.ToolStripLabel mesToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox mesToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByMonthSearchToolStripButton;
        private System.Windows.Forms.ToolStrip fillByNameAdminToolStrip;
        private System.Windows.Forms.ToolStripLabel nomeToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nomeToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByNameAdminToolStripButton;
        private System.Windows.Forms.ToolStrip fillByMonthAdminToolStrip;
        private System.Windows.Forms.ToolStripLabel mesToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox mesToolStripTextBox1;
        private System.Windows.Forms.ToolStripButton fillByMonthAdminToolStripButton;
        private System.Windows.Forms.ToolStrip fillByClassAdminToolStrip;
        private System.Windows.Forms.ToolStripLabel disciplinaToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox disciplinaToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByClassAdminToolStripButton;
    }
}