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

        List<Evento> lista_eventos = pnEventos.ListarAnteriores();

        public formFeedback(Usuario u)
        {
            InitializeComponent();
            this.user = u;

            this.cmbEventos.DropDownStyle = ComboBoxStyle.DropDownList;
            int i = 0;
            try
            {
                lista_eventos.ForEach(delegate (Evento ev) {

                    cmbEventos.Items.Insert(i, ev.nome.ToString());
                    i++;
                });
            }
            catch
            {
                btnEnviar.Enabled = false;
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            dbEventosEntities db = new dbEventosEntities();

            try
            {

                Usuario atual = db.Usuarios.Find(this.user.email);
                Evento evento = db.Eventoes.First(ev => ev.nome == cmbEventos.Text);

                fb.titulo = txtTitulo.Text;
                fb.descricao = txtDescricao.Text;
                fb.Usuario = atual;
                fb.Evento = evento;
                fb.EventoId = evento.Id;
                fb.Usuario_email = atual.email;

                if (!pnFeedback.Inserir(fb, db))
                {
                    MessageBox.Show("Problema no envio de feedback!");
                }
                else
                {
                    MessageBox.Show("Feedback enviado!");

                    this.txtDescricao.Clear();
                    this.txtTitulo.Clear();
                    this.Hide();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void formFeedback_Load(object sender, EventArgs e)
        {

        }
    }
}
