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
    public partial class frmRecuperar : Form
    {
        public frmRecuperar()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == ""){
                MessageBox.Show("O campo email deve ser preenchido!");
            } else
            {
                Usuario u = pnUsuarios.Pesquisar(txtEmail.Text);
                if (u != null)
                {
                    if (pnUsuarios.sendMail(u))
                    {
                        MessageBox.Show("Email enviado!");

                        this.Hide();
                        Login f = new Login();
                        f.Closed += (s, args) => this.Close();
                        f.Show();

                    } else
                    {
                        MessageBox.Show("Erro ao enviar!");
                    }
                } else
                {
                    MessageBox.Show("O email não está registrado!");
                }
            }


        }

        private void lnkVoltar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login f = new Login();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEnviar_Click(this, new EventArgs());
            }
        }
    }
}
