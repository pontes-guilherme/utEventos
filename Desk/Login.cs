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
            if (txtEmail.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Por favor, informe email e senha.");
            }
            else
            {
                if (pnUsuarios.Autenticar(txtEmail.Text, txtSenha.Text))
                {
                    MessageBox.Show("Login com sucesso!");
                    this.Hide();
                    TelaPrincipal nextForm = new TelaPrincipal();
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
    }
}
