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
    public partial class VisualizarCalendario : Form
    {
        //String filterBy;
        Usuario current_user;
        List<Categoria> lista_categorias = pnCategorias.Listar();
        List<Disciplina> lista_disciplinas = pnDisciplinas.Listar();

        public VisualizarCalendario(Usuario u)
        {
            InitializeComponent();

            loadCmbCategorias();
            loadCmbDisciplinas();

            this.current_user = u;
        }

        private void VisualizarCalendario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbEventosDataSet.Evento' table. You can move, or remove it, as needed.

            try
            {
                this.eventosTableAdapter1.FillByDay(this.dbEventosDataSet.Eventos);
                loadFromListToFields();
            }catch { }

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

                btnInscricao.Enabled = true;
                if (DateTime.Compare(evento.data_inicio, DateTime.Now) > 0)
                {
                    if (pnInscricoes.Pesquisar(evento.Id, current_user.email) != null)
                    {
                        btnInscricao.Text = "Cancelar inscrição";
                    }
                    else if(evento.capacidade == 0 || evento.capacidade > evento.Inscricoes.Count())
                    {
                        btnInscricao.Text = "Inscrever-se";
                    }
                    else
                    {
                        btnInscricao.Text = "Vagas esgotadas";
                        btnInscricao.Enabled = false;
                    }
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
                }

            }
            catch
            {

            }
        }

        private void rdbDia_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDia.Checked == true)
            {
                try
                {
                    this.eventosTableAdapter1.ClearBeforeFill = true;
                    this.eventosTableAdapter1.FillByDay(this.dbEventosDataSet.Eventos);
                    loadFromListToFields();
                }catch { }
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateForm();
            //loadFromListToFields();
        }

        private void rdbSemana_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSemana.Checked == true)
            {
                try
                {
                    this.eventosTableAdapter1.ClearBeforeFill = true;
                    this.eventosTableAdapter1.FillByWeek(this.dbEventosDataSet.Eventos);
                    loadFromListToFields();
                }catch { }
            }
        }

        private void rdbMes_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMes.Checked == true)
            {
                try
                {
                    this.eventosTableAdapter1.ClearBeforeFill = true;
                    this.eventosTableAdapter1.FillByMONTH2(this.dbEventosDataSet.Eventos);
                    loadFromListToFields();
                }catch { }
            }
        }

        private void btnInscricao_Click(object sender, EventArgs e)
        {
            //dbEventosEntities db = new dbEventosEntities();
            Inscricao i = new Inscricao();
            Evento evento = pnEventos.Pesquisar(Int32.Parse(listBox1.SelectedValue.ToString()));

            if (DateTime.Compare(evento.data_inicio, DateTime.Now) > 0)
            { 
                if (pnInscricoes.Pesquisar(evento.Id, current_user.email) != null)
                {
                    if (!pnInscricoes.Excluir(pnInscricoes.Pesquisar(evento.Id, current_user.email)))
                    {
                        MessageBox.Show("Erro ao realizar procedimento!");
                    }
                    else
                    {
                        MessageBox.Show("Cancelada!");
                        UpdateForm();
                    }
                }
                else
                {
                    if (!pnInscricoes.Inserir(evento.Id, current_user.email))
                    {
                        MessageBox.Show("Erro ao inscrever-se!");
                    }
                    else
                    {
                        MessageBox.Show("Inscrito!");
                        UpdateForm();
                    }
                }
             }
            else if (DateTime.Compare(evento.data_fim, DateTime.Now) > 0)
            {
                if (pnCheckin.Pesquisar(evento.Id, current_user.email) != null)
                {
                    if (!pnCheckin.Excluir(pnCheckin.Pesquisar(evento.Id, current_user.email)))
                    {
                        MessageBox.Show("Erro ao realizar procedimento!");
                    }
                    else
                    {
                        MessageBox.Show("Cancelado!");
                        UpdateForm();
                    }
                }
                else
                {
                    if (!pnCheckin.Inserir(evento.Id, current_user.email))
                    {
                        MessageBox.Show("Erro ao registrar presença!");
                    }
                    else
                    {
                        MessageBox.Show("Checked in!");
                        UpdateForm();
                    }
                }
            }
            else
            {

            }

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
            btnInscricao.Enabled = true;
        }

        private void UpdateForm()
        {
            ClearForm();
            loadFromListToFields();
        }
    }
}
