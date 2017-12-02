namespace Desk
{
    partial class frmRecuperar
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lnkVoltar = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // utEventos
            // 
            this.utEventos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.utEventos.AutoSize = true;
            this.utEventos.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utEventos.Location = new System.Drawing.Point(71, 9);
            this.utEventos.Name = "utEventos";
            this.utEventos.Size = new System.Drawing.Size(216, 23);
            this.utEventos.TabIndex = 10;
            this.utEventos.Text = "Recuperação de Senha";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(58, 62);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(266, 20);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(20, 65);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 8;
            this.Email.Text = "Email";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(223, 110);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(101, 23);
            this.btnEnviar.TabIndex = 11;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lnkVoltar
            // 
            this.lnkVoltar.AutoSize = true;
            this.lnkVoltar.Location = new System.Drawing.Point(20, 16);
            this.lnkVoltar.Name = "lnkVoltar";
            this.lnkVoltar.Size = new System.Drawing.Size(19, 13);
            this.lnkVoltar.TabIndex = 12;
            this.lnkVoltar.TabStop = true;
            this.lnkVoltar.Text = "<<";
            this.lnkVoltar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkVoltar_LinkClicked);
            // 
            // frmRecuperar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 145);
            this.Controls.Add(this.lnkVoltar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.utEventos);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.Email);
            this.Name = "frmRecuperar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRecuperar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label utEventos;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.LinkLabel lnkVoltar;
    }
}