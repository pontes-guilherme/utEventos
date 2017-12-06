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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEventosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCapacidade)).BeginInit();
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
            this.txtCapacidade.Minimum = new decimal(new int[] {
            1,
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
            "Mês"});
            this.cmbPesquisar.Location = new System.Drawing.Point(34, 88);
            this.cmbPesquisar.Name = "cmbPesquisar";
            this.cmbPesquisar.Size = new System.Drawing.Size(58, 21);
            this.cmbPesquisar.TabIndex = 45;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(101, 20);
            this.textBox1.TabIndex = 46;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(34, 111);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(165, 21);
            this.btnPesquisar.TabIndex = 47;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // MeusEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 483);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPesquisar;
    }
}