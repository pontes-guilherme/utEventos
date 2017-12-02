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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fillByEmailToolStrip = new System.Windows.Forms.ToolStrip();
            this.emailToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.emailToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByEmailToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.eventosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbEventosDataSet = new Desk.dbEventosDataSet();
            this.eventosTableAdapter1 = new Desk.dbEventosDataSetTableAdapters.EventosTableAdapter();
            this.datacriacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datafimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datainicioDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.escopoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorianomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.fillByEmailToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEventosDataSet)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.capacidadeDataGridViewTextBoxColumn,
            this.categorianomeDataGridViewTextBoxColumn,
            this.escopoDataGridViewTextBoxColumn,
            this.datainicioDataGridViewCheckBoxColumn,
            this.datafimDataGridViewTextBoxColumn,
            this.importanteDataGridViewTextBoxColumn,
            this.datacriacaoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.eventosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(57, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(583, 372);
            this.dataGridView1.TabIndex = 13;
            // 
            // fillByEmailToolStrip
            // 
            this.fillByEmailToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emailToolStripLabel,
            this.emailToolStripTextBox,
            this.fillByEmailToolStripButton});
            this.fillByEmailToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByEmailToolStrip.Name = "fillByEmailToolStrip";
            this.fillByEmailToolStrip.Size = new System.Drawing.Size(697, 25);
            this.fillByEmailToolStrip.TabIndex = 14;
            this.fillByEmailToolStrip.Text = "fillByEmailToolStrip";
            this.fillByEmailToolStrip.Visible = false;
            // 
            // emailToolStripLabel
            // 
            this.emailToolStripLabel.Name = "emailToolStripLabel";
            this.emailToolStripLabel.Size = new System.Drawing.Size(39, 22);
            this.emailToolStripLabel.Text = "email:";
            // 
            // emailToolStripTextBox
            // 
            this.emailToolStripTextBox.Name = "emailToolStripTextBox";
            this.emailToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByEmailToolStripButton
            // 
            this.fillByEmailToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByEmailToolStripButton.Name = "fillByEmailToolStripButton";
            this.fillByEmailToolStripButton.Size = new System.Drawing.Size(68, 22);
            this.fillByEmailToolStripButton.Text = "FillByEmail";
            this.fillByEmailToolStripButton.Click += new System.EventHandler(this.fillByEmailToolStripButton_Click_6);
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
            // eventosTableAdapter1
            // 
            this.eventosTableAdapter1.ClearBeforeFill = true;
            // 
            // datacriacaoDataGridViewTextBoxColumn
            // 
            this.datacriacaoDataGridViewTextBoxColumn.DataPropertyName = "data_criacao";
            this.datacriacaoDataGridViewTextBoxColumn.HeaderText = "data_criacao";
            this.datacriacaoDataGridViewTextBoxColumn.Name = "datacriacaoDataGridViewTextBoxColumn";
            this.datacriacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // importanteDataGridViewTextBoxColumn
            // 
            this.importanteDataGridViewTextBoxColumn.DataPropertyName = "importante";
            this.importanteDataGridViewTextBoxColumn.HeaderText = "importante";
            this.importanteDataGridViewTextBoxColumn.Name = "importanteDataGridViewTextBoxColumn";
            this.importanteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datafimDataGridViewTextBoxColumn
            // 
            this.datafimDataGridViewTextBoxColumn.DataPropertyName = "data_fim";
            this.datafimDataGridViewTextBoxColumn.HeaderText = "data_fim";
            this.datafimDataGridViewTextBoxColumn.Name = "datafimDataGridViewTextBoxColumn";
            this.datafimDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datainicioDataGridViewCheckBoxColumn
            // 
            this.datainicioDataGridViewCheckBoxColumn.DataPropertyName = "data_inicio";
            this.datainicioDataGridViewCheckBoxColumn.HeaderText = "data_inicio";
            this.datainicioDataGridViewCheckBoxColumn.Name = "datainicioDataGridViewCheckBoxColumn";
            this.datainicioDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // escopoDataGridViewTextBoxColumn
            // 
            this.escopoDataGridViewTextBoxColumn.DataPropertyName = "escopo";
            this.escopoDataGridViewTextBoxColumn.HeaderText = "escopo";
            this.escopoDataGridViewTextBoxColumn.Name = "escopoDataGridViewTextBoxColumn";
            this.escopoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categorianomeDataGridViewTextBoxColumn
            // 
            this.categorianomeDataGridViewTextBoxColumn.DataPropertyName = "Categoria_nome";
            this.categorianomeDataGridViewTextBoxColumn.HeaderText = "Categoria_nome";
            this.categorianomeDataGridViewTextBoxColumn.Name = "categorianomeDataGridViewTextBoxColumn";
            this.categorianomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // capacidadeDataGridViewTextBoxColumn
            // 
            this.capacidadeDataGridViewTextBoxColumn.DataPropertyName = "capacidade";
            this.capacidadeDataGridViewTextBoxColumn.HeaderText = "capacidade";
            this.capacidadeDataGridViewTextBoxColumn.Name = "capacidadeDataGridViewTextBoxColumn";
            this.capacidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MeusEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 483);
            this.Controls.Add(this.fillByEmailToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MeusEventos";
            this.Text = "MeusEventos";
            this.Load += new System.EventHandler(this.MeusEventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.fillByEmailToolStrip.ResumeLayout(false);
            this.fillByEmailToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEventosDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private dbEventosDataSetTableAdapters.EventosTableAdapter eventosTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip fillByEmailToolStrip;
        private System.Windows.Forms.ToolStripLabel emailToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox emailToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByEmailToolStripButton;
        private System.Windows.Forms.BindingSource eventosBindingSource;
        private dbEventosDataSet dbEventosDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorianomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn escopoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn datainicioDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datafimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn importanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datacriacaoDataGridViewTextBoxColumn;
    }
}