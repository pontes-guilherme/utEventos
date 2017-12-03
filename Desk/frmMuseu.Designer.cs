namespace Desk
{
    partial class frmMuseu
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
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.eventosTableAdapter = new Desk.dbEventosDataSetTableAdapters.EventosTableAdapter();
            this.eventosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbEventosDataSet = new Desk.dbEventosDataSet();
            this.eventosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtCapacidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEventosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 61;
            this.label7.Text = "Eventos realizados:";
            // 
            // cmbDisciplina
            // 
            this.cmbDisciplina.Enabled = false;
            this.cmbDisciplina.FormattingEnabled = true;
            this.cmbDisciplina.Location = new System.Drawing.Point(488, 107);
            this.cmbDisciplina.Name = "cmbDisciplina";
            this.cmbDisciplina.Size = new System.Drawing.Size(166, 21);
            this.cmbDisciplina.TabIndex = 60;
            this.cmbDisciplina.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(218, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 59;
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
            this.cmbEscopo.Location = new System.Drawing.Point(270, 107);
            this.cmbEscopo.Name = "cmbEscopo";
            this.cmbEscopo.Size = new System.Drawing.Size(212, 21);
            this.cmbEscopo.TabIndex = 58;
            this.cmbEscopo.Text = "Global";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(197, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Capacidade:";
            // 
            // txtCapacidade
            // 
            this.txtCapacidade.Enabled = false;
            this.txtCapacidade.Location = new System.Drawing.Point(270, 213);
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
            this.txtCapacidade.TabIndex = 56;
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
            this.ckbImportante.Location = new System.Drawing.Point(406, 215);
            this.ckbImportante.Name = "ckbImportante";
            this.ckbImportante.Size = new System.Drawing.Size(76, 17);
            this.ckbImportante.TabIndex = 55;
            this.ckbImportante.Text = "Importante";
            this.ckbImportante.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(238, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Fim:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(227, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Início:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(209, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Categoria:";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Enabled = false;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(270, 134);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(212, 21);
            this.cmbCategoria.TabIndex = 51;
            this.cmbCategoria.Text = "Outro";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(270, 81);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(212, 20);
            this.txtNome.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(226, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Nome:";
            // 
            // dtInicio
            // 
            this.dtInicio.Enabled = false;
            this.dtInicio.Location = new System.Drawing.Point(270, 161);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(212, 20);
            this.dtInicio.TabIndex = 47;
            // 
            // eventosTableAdapter
            // 
            this.eventosTableAdapter.ClearBeforeFill = true;
            // 
            // eventosBindingSource
            // 
            this.eventosBindingSource.DataMember = "Eventos";
            this.eventosBindingSource.DataSource = this.dbEventosDataSet;
            // 
            // dbEventosDataSet
            // 
            this.dbEventosDataSet.DataSetName = "dbEventosDataSet";
            this.dbEventosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventosBindingSource1
            // 
            this.eventosBindingSource1.DataMember = "Eventos";
            this.eventosBindingSource1.DataSource = this.dbEventosDataSet;
            // 
            // dtFim
            // 
            this.dtFim.Enabled = false;
            this.dtFim.Location = new System.Drawing.Point(270, 187);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(212, 20);
            this.dtFim.TabIndex = 48;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.eventosBindingSource1;
            this.listBox1.DisplayMember = "nome";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(14, 81);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(165, 329);
            this.listBox1.TabIndex = 45;
            this.listBox1.ValueMember = "id";
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(284, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(136, 18);
            this.title.TabIndex = 44;
            this.title.Text = "Museu de Eventos";
            // 
            // frmMuseu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 444);
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
            this.Controls.Add(this.dtInicio);
            this.Controls.Add(this.dtFim);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMuseu";
            this.Text = "frmMuseu";
            this.Load += new System.EventHandler(this.frmMuseu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCapacidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEventosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.DateTimePicker dtInicio;
        private dbEventosDataSetTableAdapters.EventosTableAdapter eventosTableAdapter;
        private System.Windows.Forms.BindingSource eventosBindingSource;
        private dbEventosDataSet dbEventosDataSet;
        private System.Windows.Forms.BindingSource eventosBindingSource1;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label title;
    }
}