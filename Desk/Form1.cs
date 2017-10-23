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
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();

            u.email = txtEmail.Text;
            u.nome = txtNome.Text;
            u.senha = txtSenha.Text;
            u.data_nascimento = DateTime.Parse(mtxtNascimento.Text);

            if (!pnUsuarios.Inserir(u))
            {
                MessageBox.Show("Problema na inserção de usuário!");
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();

            u = pnUsuarios.Pesquisar(txtEmail.Text);

            if (u != null)
            {
                txtNome.Text = u.nome;
                txtSenha.Text = u.senha;
                mtxtNascimento.Text = u.data_nascimento.ToString();
            }
            else {
                MessageBox.Show("E-mail não existente");
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();

            u.email = txtEmail.Text;
            u.nome = txtNome.Text;
            u.senha = txtSenha.Text;
            u.data_nascimento = DateTime.Parse(mtxtNascimento.Text);

            if (MessageBox.Show("Confirma a exclusão?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                pnUsuarios.Excluir(u);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();

            u.email = txtEmail.Text;
            u.nome = txtNome.Text;
            u.senha = txtSenha.Text;
            u.data_nascimento = DateTime.Parse(mtxtNascimento.Text);
            
            if (!pnUsuarios.Alterar(u))
            {
                MessageBox.Show("Erro ao alterar usuário!");
            }
        }
    }
}
