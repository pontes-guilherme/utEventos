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
    public partial class TelaPrincipal : Form
    {
        Usuario currentUser;
        Form embeddedForm;

        public TelaPrincipal(Usuario u)
        {
            InitializeComponent();
            currentUser = u;

            //default form 
            embeddedForm = new CadastroEventos(u);
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Sessão finalizada.");
            this.Hide();
            Login nextForm = new Login();
            nextForm.Closed += (s, args) => this.Close();
            nextForm.Show();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            embeddedForm.TopLevel = false;
            embeddedForm.Visible = true;
            mainPanel.Controls.Add(embeddedForm);
        }

        private void lnkVerPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainPanel.Controls.Remove(embeddedForm);

            embeddedForm = new VisualizarPerfil(currentUser);
            embeddedForm.TopLevel = false;
            embeddedForm.Visible = true;
            mainPanel.Controls.Add(embeddedForm);
            this.Invalidate();
        }

        private void lnkEditarPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainPanel.Controls.Remove(embeddedForm);
            embeddedForm = new EditarPerfil(currentUser);
            embeddedForm.TopLevel = false;
            embeddedForm.Visible = true;
            mainPanel.Controls.Add(embeddedForm);
            this.Invalidate();
        }

        private void lnkEvenNovo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainPanel.Controls.Remove(embeddedForm);
            embeddedForm = new CadastroEventos(currentUser);
            embeddedForm.TopLevel = false;
            embeddedForm.Visible = true;
            mainPanel.Controls.Add(embeddedForm);
            this.Invalidate();
        }

        private void lnkEvenPes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainPanel.Controls.Remove(embeddedForm);
            embeddedForm = new MeusEventos(currentUser);
            embeddedForm.TopLevel = false;
            embeddedForm.Visible = true;
            mainPanel.Controls.Add(embeddedForm);
            this.Invalidate();
        }
    }
}
