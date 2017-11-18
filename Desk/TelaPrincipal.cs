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

            //Exibe o tipo de conta na label
            lblTipoConta.Text = u.tipo;

            //Categorias só podem ser manipuladas por administradores
            grpCategorias.Visible = false;
            if (u.tipo == "Administrador")
            {
                grpCategorias.Visible = true;
            }
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

        private void lnkCategoriaCad_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainPanel.Controls.Remove(embeddedForm);
            embeddedForm = new CadastroCategoria(currentUser);
            embeddedForm.TopLevel = false;
            embeddedForm.Visible = true;
            mainPanel.Controls.Add(embeddedForm);
            this.Invalidate();
        }

        private void lnkCalMen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainPanel.Controls.Remove(embeddedForm);
            embeddedForm = new VisualizarCalendario(currentUser, "mes");
            embeddedForm.TopLevel = false;
            embeddedForm.Visible = true;
            mainPanel.Controls.Add(embeddedForm);
            this.Invalidate();
        }

        private void lnkCalSem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainPanel.Controls.Remove(embeddedForm);
            embeddedForm = new VisualizarCalendario(currentUser, "semana");
            embeddedForm.TopLevel = false;
            embeddedForm.Visible = true;
            mainPanel.Controls.Add(embeddedForm);
            this.Invalidate();
        }

        private void lnkCalDia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainPanel.Controls.Remove(embeddedForm);
            embeddedForm = new VisualizarCalendario(currentUser, "dia");
            embeddedForm.TopLevel = false;
            embeddedForm.Visible = true;
            mainPanel.Controls.Add(embeddedForm);
            this.Invalidate();
        }

        private void lnkFeedback_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dbEventosEntities db = new dbEventosEntities();
            Evento t = new Evento();
            t.Id = 1;
           
            mainPanel.Controls.Remove(embeddedForm);
            embeddedForm = new formFeedback(currentUser);
            embeddedForm.TopLevel = false;
            embeddedForm.Visible = true;
            mainPanel.Controls.Add(embeddedForm);
            this.Invalidate();
        }
    }
}
