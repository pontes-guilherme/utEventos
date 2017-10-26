namespace Desk
{
    partial class Login
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
            this.Email = new System.Windows.Forms.Label();
            this.Senha = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.Entrar = new System.Windows.Forms.Button();
            this.Registrar = new System.Windows.Forms.Button();
            this.RecuperarSenha = new System.Windows.Forms.LinkLabel();
            this.utEventos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(26, 51);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 0;
            this.Email.Text = "Email";
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.Location = new System.Drawing.Point(20, 77);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(38, 13);
            this.Senha.TabIndex = 1;
            this.Senha.Text = "Senha";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(64, 48);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(266, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(64, 74);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(266, 20);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // Entrar
            // 
            this.Entrar.Location = new System.Drawing.Point(255, 100);
            this.Entrar.Name = "Entrar";
            this.Entrar.Size = new System.Drawing.Size(75, 23);
            this.Entrar.TabIndex = 4;
            this.Entrar.Text = "Entrar";
            this.Entrar.UseVisualStyleBackColor = true;
            this.Entrar.Click += new System.EventHandler(this.Entrar_Click);
            // 
            // Registrar
            // 
            this.Registrar.Location = new System.Drawing.Point(174, 100);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(75, 23);
            this.Registrar.TabIndex = 5;
            this.Registrar.Text = "Registrar";
            this.Registrar.UseVisualStyleBackColor = true;
            this.Registrar.Click += new System.EventHandler(this.Registrar_Click);
            // 
            // RecuperarSenha
            // 
            this.RecuperarSenha.AutoSize = true;
            this.RecuperarSenha.Location = new System.Drawing.Point(77, 105);
            this.RecuperarSenha.Name = "RecuperarSenha";
            this.RecuperarSenha.Size = new System.Drawing.Size(91, 13);
            this.RecuperarSenha.TabIndex = 6;
            this.RecuperarSenha.TabStop = true;
            this.RecuperarSenha.Text = "Recuperar Senha";
            // 
            // utEventos
            // 
            this.utEventos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.utEventos.AutoSize = true;
            this.utEventos.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utEventos.Location = new System.Drawing.Point(131, 9);
            this.utEventos.Name = "utEventos";
            this.utEventos.Size = new System.Drawing.Size(100, 23);
            this.utEventos.TabIndex = 7;
            this.utEventos.Text = "utEventos";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 145);
            this.Controls.Add(this.utEventos);
            this.Controls.Add(this.RecuperarSenha);
            this.Controls.Add(this.Registrar);
            this.Controls.Add(this.Entrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.Email);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button Entrar;
        private System.Windows.Forms.Button Registrar;
        private System.Windows.Forms.LinkLabel RecuperarSenha;
        private System.Windows.Forms.Label utEventos;
    }
}