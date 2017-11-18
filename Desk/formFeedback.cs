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
    public partial class formFeedback : Form
    {
        Feedback fb = new Feedback();
        Usuario user;

        public formFeedback(Usuario u)
        {
            InitializeComponent();
            this.user = u;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            dbEventosEntities db = new dbEventosEntities();

            try
            {

                fb.titulo = txtTitulo.Text;
                fb.descricao = txtDescricao.Text;
                fb.Usuario = this.user;
                //fb.Evento = this.evento;

                if (!pnFeedback.Inserir(fb))
                {
                    MessageBox.Show("Problema no envio de feedback!");
                }
                else
                {
                    MessageBox.Show("Feedback enviado.");
                    this.Hide();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
