using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo.DAO;
using Modelo.PN;


namespace Desk
{
    public partial class CadastroUsuario : Form
    {
        public CadastroUsuario()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login nextForm = new Login();
            nextForm.Closed += (s, args) => this.Close();
            nextForm.Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario u = new Usuario();

                u.email = txtEmail.Text;
                u.nome = txtNome.Text;
                u.senha = txtSenha.Text;
                u.data_nascimento = DateTime.Parse(txtNascimento.Text);
                u.tipo = "Estudante";

                if (!pnUsuarios.Inserir(u))
                {
                    MessageBox.Show("Problema na inserção de usuário!");
                }
                else
                {
                    MessageBox.Show("Cadastro realizado com sucesso.");
                    this.Hide();
                    Login nextForm = new Login();
                    nextForm.Closed += (s, args) => this.Close();
                    nextForm.Show();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Erro ao registrar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
