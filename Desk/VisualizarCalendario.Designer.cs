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
            this.dgvEventos = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datainicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datafimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.escopoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importanteDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.criadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbEventosDataSet = new Desk.dbEventosDataSet();
            this.eventoTableAdapter = new Desk.dbEventosDataSetTableAdapters.EventoTableAdapter();
            this.fillByMONTH2ToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByMONTH2ToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEventosDataSet)).BeginInit();
            this.fillByMONTH2ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(287, 10);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(58, 18);
            this.title.TabIndex = 13;
            this.title.Text = "Mensal";
            // 
            // dgvEventos
            // 
            this.dgvEventos.AllowUserToAddRows = false;
            this.dgvEventos.AllowUserToDeleteRows = false;
            this.dgvEventos.AllowUserToResizeColumns = false;
            this.dgvEventos.AllowUserToResizeRows = false;
            this.dgvEventos.AutoGenerateColumns = false;
            this.dgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.datainicioDataGridViewTextBoxColumn,
            this.datafimDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.escopoDataGridViewTextBoxColumn,
            this.importanteDataGridViewCheckBoxColumn,
            this.criadorDataGridViewTextBoxColumn});
            this.dgvEventos.DataSource = this.eventoBindingSource;
            this.dgvEventos.Location = new System.Drawing.Point(12, 84);
            this.dgvEventos.Name = "dgvEventos";
            this.dgvEventos.ReadOnly = true;
            this.dgvEventos.Size = new System.Drawing.Size(643, 348);
            this.dgvEventos.TabIndex = 14;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datainicioDataGridViewTextBoxColumn
            // 
            this.datainicioDataGridViewTextBoxColumn.DataPropertyName = "data_inicio";
            this.datainicioDataGridViewTextBoxColumn.HeaderText = "data_inicio";
            this.datainicioDataGridViewTextBoxColumn.Name = "datainicioDataGridViewTextBoxColumn";
            this.datainicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datafimDataGridViewTextBoxColumn
            // 
            this.datafimDataGridViewTextBoxColumn.DataPropertyName = "data_fim";
            this.datafimDataGridViewTextBoxColumn.HeaderText = "data_fim";
            this.datafimDataGridViewTextBoxColumn.Name = "datafimDataGridViewTextBoxColumn";
            this.datafimDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "categoria";
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            this.categoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // escopoDataGridViewTextBoxColumn
            // 
            this.escopoDataGridViewTextBoxColumn.DataPropertyName = "escopo";
            this.escopoDataGridViewTextBoxColumn.HeaderText = "escopo";
            this.escopoDataGridViewTextBoxColumn.Name = "escopoDataGridViewTextBoxColumn";
            this.escopoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // importanteDataGridViewCheckBoxColumn
            // 
            this.importanteDataGridViewCheckBoxColumn.DataPropertyName = "importante";
            this.importanteDataGridViewCheckBoxColumn.HeaderText = "importante";
            this.importanteDataGridViewCheckBoxColumn.Name = "importanteDataGridViewCheckBoxColumn";
            this.importanteDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // criadorDataGridViewTextBoxColumn
            // 
            this.criadorDataGridViewTextBoxColumn.DataPropertyName = "criador";
            this.criadorDataGridViewTextBoxColumn.HeaderText = "criador";
            this.criadorDataGridViewTextBoxColumn.Name = "criadorDataGridViewTextBoxColumn";
            this.criadorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eventoBindingSource
            // 
            this.eventoBindingSource.DataMember = "Evento";
            this.eventoBindingSource.DataSource = this.dbEventosDataSet;
            // 
            // dbEventosDataSet
            // 
            this.dbEventosDataSet.DataSetName = "dbEventosDataSet";
            this.dbEventosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventoTableAdapter
            // 
            this.eventoTableAdapter.ClearBeforeFill = true;
            // 
            // fillByMONTH2ToolStrip
            // 
            this.fillByMONTH2ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByMONTH2ToolStripButton});
            this.fillByMONTH2ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByMONTH2ToolStrip.Name = "fillByMONTH2ToolStrip";
            this.fillByMONTH2ToolStrip.Size = new System.Drawing.Size(681, 25);
            this.fillByMONTH2ToolStrip.TabIndex = 15;
            this.fillByMONTH2ToolStrip.Text = "fillByMONTH2ToolStrip";
            this.fillByMONTH2ToolStrip.Visible = false;
            // 
            // fillByMONTH2ToolStripButton
            // 
            this.fillByMONTH2ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByMONTH2ToolStripButton.Name = "fillByMONTH2ToolStripButton";
            this.fillByMONTH2ToolStripButton.Size = new System.Drawing.Size(90, 22);
            this.fillByMONTH2ToolStripButton.Text = "FillByMONTH2";
            this.fillByMONTH2ToolStripButton.Click += new System.EventHandler(this.fillByMONTH2ToolStripButton_Click_1);
            // 
            // VisualizarCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 452);
            this.Controls.Add(this.fillByMONTH2ToolStrip);
            this.Controls.Add(this.dgvEventos);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VisualizarCalendario";
            this.Text = "VisualizarCalendario";
            this.Load += new System.EventHandler(this.VisualizarCalendario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEventosDataSet)).EndInit();
            this.fillByMONTH2ToolStrip.ResumeLayout(false);
            this.fillByMONTH2ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.DataGridView dgvEventos;
        private dbEventosDataSet dbEventosDataSet;
        private System.Windows.Forms.BindingSource eventoBindingSource;
        private dbEventosDataSetTableAdapters.EventoTableAdapter eventoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datainicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datafimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn escopoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn importanteDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn criadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillByMONTH2ToolStrip;
        private System.Windows.Forms.ToolStripButton fillByMONTH2ToolStripButton;
    }
}