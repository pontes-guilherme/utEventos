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
    public partial class EditarPerfil : Form
    {
        Usuario currentUser;

        public EditarPerfil(Usuario u)
        {
            InitializeComponent();
            currentUser = u;

            if (currentUser != null)
            {
                txtNome.Text = currentUser.nome;
                txtNascimento.Text = currentUser.data_nascimento.ToString();
            }
            else
            {
                MessageBox.Show("Ops! Algo inesperado ocorreu.");
            }
        }

        private void EditarPerfil_Load(object sender, EventArgs e)
        {
        }
        

        private void btnEditar_Click(object sender, EventArgs e)
        {
            currentUser.email = currentUser.email;
            currentUser.nome = txtNome.Text;
            currentUser.senha = txtSenha.Text;
            currentUser.data_nascimento = DateTime.Parse(txtNascimento.Text);
            currentUser.tipo = currentUser.tipo;
                
            if (!pnUsuarios.Alterar(currentUser))
            {
                MessageBox.Show("Erro ao alterar perfil!");
            }
            else
            {
                MessageBox.Show("Perfil alterado com sucesso.");
            }
        }

        private void EditarPerfil_Load_1(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
           
           
        }

        private void txtNascimento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtNascimento_Leave(object sender, EventArgs e)
        {
            DateTime resultado = DateTime.MinValue;
            if (DateTime.TryParse(this.txtNascimento.Text.Trim(), out resultado))
            {
                MessageBox.Show("Data Válida.");
            }
            else
            {
                MessageBox.Show("Data Inválida.");
            }
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a exclusão?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                pnUsuarios.Excluir(currentUser);

                MessageBox.Show("Conta encerrada.");
                this.Hide();
                Login nextForm = new Login();
                nextForm.Closed += (s, args) => this.Close();
                nextForm.Show();
            }
        }
    }
}
