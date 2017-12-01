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
using System.Security.Cryptography;

namespace Desk
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Por favor, informe o email");
            }
            else
            {

                //String passwordHash = pnUsuarios.CreateMD5(txtSenha.Text);

                if (pnUsuarios.Autenticar(txtEmail.Text, txtSenha.Text))
                {
                    Usuario u = pnUsuarios.Pesquisar(txtEmail.Text);

                    this.Hide();
                    TelaPrincipal nextForm = new TelaPrincipal(u);
                    nextForm.Closed += (s, args) => this.Close();
                    nextForm.Show();
                }
                else
                {
                    MessageBox.Show("Falha no Login!");
                }
            }

        }    
        
        private void Registrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastroUsuario nextForm = new CadastroUsuario();
            nextForm.Closed += (s, args) => this.Close();
            nextForm.Show();
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Entrar_Click(this, new EventArgs());
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Entrar_Click(this, new EventArgs());
            }
        }

        private void RecuperarSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmRecuperar f = new frmRecuperar();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }
    }
}
