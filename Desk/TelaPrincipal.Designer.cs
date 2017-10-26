namespace Desk
{
    partial class TelaPrincipal
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
            this.utEventos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lnkSair = new System.Windows.Forms.LinkLabel();
            this.lnkEPerfil = new System.Windows.Forms.LinkLabel();
            this.lnkVPerfil = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // utEventos
            // 
            this.utEventos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.utEventos.AutoSize = true;
            this.utEventos.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utEventos.Location = new System.Drawing.Point(36, 9);
            this.utEventos.Name = "utEventos";
            this.utEventos.Size = new System.Drawing.Size(100, 23);
            this.utEventos.TabIndex = 9;
            this.utEventos.Text = "utEventos";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.utEventos);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 522);
            this.panel1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lnkVPerfil);
            this.groupBox1.Controls.Add(this.lnkEPerfil);
            this.groupBox1.Controls.Add(this.lnkSair);
            this.groupBox1.Location = new System.Drawing.Point(3, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conta";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(3, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(171, 100);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eventos";
            // 
            // lnkSair
            // 
            this.lnkSair.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.lnkSair.AutoSize = true;
            this.lnkSair.LinkColor = System.Drawing.Color.Black;
            this.lnkSair.Location = new System.Drawing.Point(20, 27);
            this.lnkSair.Name = "lnkSair";
            this.lnkSair.Size = new System.Drawing.Size(25, 13);
            this.lnkSair.TabIndex = 0;
            this.lnkSair.TabStop = true;
            this.lnkSair.Text = "Sair";
            this.lnkSair.VisitedLinkColor = System.Drawing.Color.Black;
            this.lnkSair.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lnkEPerfil
            // 
            this.lnkEPerfil.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.lnkEPerfil.AutoSize = true;
            this.lnkEPerfil.LinkColor = System.Drawing.Color.Black;
            this.lnkEPerfil.Location = new System.Drawing.Point(20, 74);
            this.lnkEPerfil.Name = "lnkEPerfil";
            this.lnkEPerfil.Size = new System.Drawing.Size(60, 13);
            this.lnkEPerfil.TabIndex = 1;
            this.lnkEPerfil.TabStop = true;
            this.lnkEPerfil.Text = "Editar Perfil";
            this.lnkEPerfil.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // lnkVPerfil
            // 
            this.lnkVPerfil.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.lnkVPerfil.AutoSize = true;
            this.lnkVPerfil.LinkColor = System.Drawing.Color.Black;
            this.lnkVPerfil.Location = new System.Drawing.Point(20, 51);
            this.lnkVPerfil.Name = "lnkVPerfil";
            this.lnkVPerfil.Size = new System.Drawing.Size(77, 13);
            this.lnkVPerfil.TabIndex = 2;
            this.lnkVPerfil.TabStop = true;
            this.lnkVPerfil.Text = "Visualizar Perfil";
            this.lnkVPerfil.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 522);
            this.Controls.Add(this.panel1);
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaPrincipal";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label utEventos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel lnkEPerfil;
        private System.Windows.Forms.LinkLabel lnkSair;
        private System.Windows.Forms.LinkLabel lnkVPerfil;
    }
}