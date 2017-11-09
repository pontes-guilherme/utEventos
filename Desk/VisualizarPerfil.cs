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
    public partial class VisualizarPerfil : Form
    {
        Usuario currentUser;

        public VisualizarPerfil(Usuario u)
        {
            InitializeComponent();
            currentUser = u;
        }

        private void VisualizarPerfil_Load(object sender, EventArgs e)
        {
            if (currentUser != null)
            {
                lblNome.Text = currentUser.nome;
                lblEmail.Text = currentUser.email;
                lblTipo.Text = currentUser.tipo;
                lblNasc.Text = currentUser.data_nascimento.ToString();
            }
            else
            {
                MessageBox.Show("Ops! Algo inesperado ocorreu.");
            }
        }
    }
}
