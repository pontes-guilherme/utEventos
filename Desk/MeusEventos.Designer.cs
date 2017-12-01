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
            this.title = new System.Windows.Forms.Label();
            this.dbEventosDataSet1 = new Desk.dbEventosDataSet();
            this.eventosTableAdapter1 = new Desk.dbEventosDataSetTableAdapters.EventosTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fillByEmailToolStrip = new System.Windows.Forms.ToolStrip();
            this.emailToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.emailToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByEmailToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dbEventosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.fillByEmailToolStrip.SuspendLayout();
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
            // dbEventosDataSet1
            // 
            this.dbEventosDataSet1.DataSetName = "dbEventosDataSet";
            this.dbEventosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventosTableAdapter1
            // 
            this.eventosTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 75);
            this.dataGridView1.Name = "dataGridView1";
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
            this.emailToolStripTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // fillByEmailToolStripButton
            // 
            this.fillByEmailToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByEmailToolStripButton.Name = "fillByEmailToolStripButton";
            this.fillByEmailToolStripButton.Size = new System.Drawing.Size(68, 19);
            this.fillByEmailToolStripButton.Text = "FillByEmail";
            this.fillByEmailToolStripButton.Click += new System.EventHandler(this.fillByEmailToolStripButton_Click_6);
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
            ((System.ComponentModel.ISupportInitialize)(this.dbEventosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.fillByEmailToolStrip.ResumeLayout(false);
            this.fillByEmailToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private dbEventosDataSet dbEventosDataSet1;
        private dbEventosDataSetTableAdapters.EventosTableAdapter eventosTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip fillByEmailToolStrip;
        private System.Windows.Forms.ToolStripLabel emailToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox emailToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByEmailToolStripButton;
    }
}