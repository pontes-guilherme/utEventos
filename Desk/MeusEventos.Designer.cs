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
            this.dbEventosDataSet = new Desk.dbEventosDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.emailToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.emailToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByEmailToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillByEmailToolStrip = new System.Windows.Forms.ToolStrip();
            this.eventoTableAdapter = new Desk.dbEventosDataSetTableAdapters.EventoTableAdapter();
            this.eventoTableAdapter1 = new Modelo.DatabaseDataSetTableAdapters.EventoTableAdapter();
            this.dbEventosDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Desk.dbEventosDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dbEventosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.fillByEmailToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbEventosDataSetBindingSource)).BeginInit();
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
            // dbEventosDataSet
            // 
            this.dbEventosDataSet.DataSetName = "dbEventosDataSet";
            this.dbEventosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(643, 348);
            this.dataGridView1.TabIndex = 13;
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
            this.fillByEmailToolStripButton.Click += new System.EventHandler(this.fillByEmailToolStripButton_Click_3);
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
            // 
            // eventoTableAdapter
            // 
            this.eventoTableAdapter.ClearBeforeFill = true;
            // 
            // eventoTableAdapter1
            // 
            this.eventoTableAdapter1.ClearBeforeFill = true;
            // 
            // dbEventosDataSetBindingSource
            // 
            this.dbEventosDataSetBindingSource.DataSource = this.dbEventosDataSet;
            this.dbEventosDataSetBindingSource.Position = 0;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriasTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Desk.dbEventosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            ((System.ComponentModel.ISupportInitialize)(this.dbEventosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.fillByEmailToolStrip.ResumeLayout(false);
            this.fillByEmailToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbEventosDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private dbEventosDataSet dbEventosDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripLabel emailToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox emailToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByEmailToolStripButton;
        private System.Windows.Forms.ToolStrip fillByEmailToolStrip;
        private dbEventosDataSetTableAdapters.EventoTableAdapter eventoTableAdapter;
        private Modelo.DatabaseDataSetTableAdapters.EventoTableAdapter eventoTableAdapter1;
        private System.Windows.Forms.BindingSource dbEventosDataSetBindingSource;
        private dbEventosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}