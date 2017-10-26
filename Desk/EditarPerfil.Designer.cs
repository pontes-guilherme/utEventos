namespace Desk
{
    partial class EditarPerfil
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
            this.Nascimento = new System.Windows.Forms.Label();
            this.Senha = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtNascimento = new System.Windows.Forms.MaskedTextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(255, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(90, 18);
            this.title.TabIndex = 11;
            this.title.Text = "Editar Perfil";
            // 
            // Nascimento
            // 
            this.Nascimento.AutoSize = true;
            this.Nascimento.Location = new System.Drawing.Point(98, 181);
            this.Nascimento.Name = "Nascimento";
            this.Nascimento.Size = new System.Drawing.Size(63, 13);
            this.Nascimento.TabIndex = 17;
            this.Nascimento.Text = "Nascimento";
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.Location = new System.Drawing.Point(123, 155);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(38, 13);
            this.Senha.TabIndex = 16;
            this.Senha.Text = "Senha";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(126, 129);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 13);
            this.Nome.TabIndex = 14;
            this.Nome.Text = "Nome";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(359, 227);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 23;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtNascimento
            // 
            this.txtNascimento.Location = new System.Drawing.Point(167, 181);
            this.txtNascimento.Mask = "00/00/0000";
            this.txtNascimento.Name = "txtNascimento";
            this.txtNascimento.Size = new System.Drawing.Size(100, 20);
            this.txtNascimento.TabIndex = 22;
            this.txtNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(167, 155);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(267, 20);
            this.txtSenha.TabIndex = 21;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(167, 129);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(267, 20);
            this.txtNome.TabIndex = 19;
            // 
            // EditarPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 483);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtNascimento);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.Nascimento);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarPerfil";
            this.Text = "EditarPerfil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label Nascimento;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.MaskedTextBox txtNascimento;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtNome;
    }
}