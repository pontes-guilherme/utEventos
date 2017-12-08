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
    public partial class frmParticipados : Form
    {
        Usuario current_user;
        List<Categoria> lista_categorias = pnCategorias.Listar();
        List<Disciplina> lista_disciplinas = pnDisciplinas.Listar();

        public frmParticipados(Usuario u)
        {
            InitializeComponent();

            loadCmbCategorias();
            loadCmbDisciplinas();

            this.current_user = u;
        }

        private void frmParticipados_Load(object sender, EventArgs e)
        {
            try
            {
                this.eventosTableAdapter1.FillByParticipado(this.dbEventosDataSet.Eventos, this.current_user.email);
                loadFromListToFields();
            }
            catch { }
        }

        private void loadCmbDisciplinas()
        {
            int i = 0;

            lista_disciplinas.ForEach(delegate (Disciplina d) {

                cmbDisciplina.Items.Insert(i, d.nome.ToString());
                i++;
            });

        }

        private void loadCmbCategorias()
        {
            int i = 0;
            try
            {
                lista_categorias.ForEach(delegate (Categoria c) {

                    cmbCategoria.Items.Insert(i, c.nome.ToString());
                    i++;
                });
            }
            catch
            {
                cmbCategoria.Items.Insert(0, "Outro");
            }
        }

        private void loadFromListToFields()
        {
            //dbEventosEntities db = new dbEventosEntities();

            try
            {
                Evento evento = pnEventos.Pesquisar(Int32.Parse(listBox1.SelectedValue.ToString()));

                txtNome.Text = evento.nome;
                txtCapacidade.Text = evento.capacidade.ToString();
                cmbCategoria.SelectedItem = evento.Categoria_nome;
                cmbEscopo.SelectedItem = evento.escopo;
                dtInicio.Value = evento.data_inicio;
                dtFim.Value = evento.data_fim;
                ckbImportante.Checked = evento.importante;
                if (evento.capacidade == 0)
                {
                    txtVagas.Visible = false;
                }
                else
                {
                    txtVagas.Value = (decimal)(evento.capacidade - evento.Inscricoes.Count());
                }
                if (evento.escopo == "Disciplina")
                {
                    cmbDisciplina.Visible = true;
                    cmbDisciplina.SelectedItem = evento.Disciplina_nome;
                }
                else
                {
                    cmbDisciplina.Visible = false;
                }

                //btnInscricao.Enabled = true;
                /* if (DateTime.Compare(evento.data_inicio, DateTime.Now) > 0)
                 {
                     if (pnInscricoes.Pesquisar(evento.Id, current_user.email) != null)
                     {
                         btnInscricao.Text = "Cancelar inscrição";
                     }
                     else if (evento.capacidade == 0 || evento.capacidade > evento.Inscricoes.Count())
                     {
                         btnInscricao.Text = "Inscrever-se";
                     }
                     else
                     {
                         btnInscricao.Text = "Vagas esgotadas";
                         btnInscricao.Enabled = false;
                     
            }
                else if (DateTime.Compare(evento.data_fim, DateTime.Now) > 0)
                {
                    if (pnCheckin.Pesquisar(evento.Id, current_user.email) != null)
                    {
                        btnInscricao.Text = "Cancelar checkin";
                    }
                    else
                    {
                        btnInscricao.Text = "Checkin";
                    }
                }
                else
                {
                    btnInscricao.Text = "Evento finalizado";
                    btnInscricao.Enabled = false;
                }}*/

            }
            catch
            {

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void ClearForm()
        {
            txtNome.Text = null;
            txtCapacidade.Text = null;
            cmbCategoria.SelectedItem = "Outro";
            cmbEscopo.SelectedItem = "Global";
            dtInicio.Value = DateTime.Now.Date;
            dtFim.Value = DateTime.Now.Date;
            ckbImportante.Checked = false;
            txtVagas.Value = 0;
            txtVagas.Visible = true;
            //btnInscricao.Enabled = true;
        }

        private void UpdateForm()
        {
            ClearForm();
            loadFromListToFields();
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.eventosTableAdapter1.FillBy1(this.dbEventosDataSet.Eventos);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
