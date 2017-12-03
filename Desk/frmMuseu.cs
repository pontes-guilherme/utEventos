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
    public partial class frmMuseu : Form
    {

        List<Categoria> lista_categorias = pnCategorias.Listar();
        List<Disciplina> lista_disciplinas = pnDisciplinas.Listar();

        public frmMuseu()
        {
            InitializeComponent();

            try
            {
                this.eventosTableAdapter.FillByEventosPassados(this.dbEventosDataSet.Eventos);
                loadCmbCategorias();
                loadCmbDisciplinas();
                loadFromListToFields();
            } catch
            {

            }
            
        }

        private void frmMuseu_Load(object sender, EventArgs e)
        {

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
            dbEventosEntities db = new dbEventosEntities();

            try
            {
                Evento evento = db.Eventoes.Find(listBox1.SelectedValue);

                txtNome.Text = evento.nome;
                txtCapacidade.Text = evento.capacidade.ToString();
                cmbCategoria.SelectedItem = evento.Categoria_nome;
                cmbEscopo.SelectedItem = evento.escopo;
                dtInicio.Value = evento.data_inicio;
                dtFim.Value = evento.data_fim;
                ckbImportante.Checked = evento.importante;
                if (evento.escopo == "Disciplina")
                {
                    cmbDisciplina.Visible = true;
                    cmbDisciplina.SelectedItem = evento.Disciplina_nome;
                }
                else
                {
                    cmbDisciplina.Visible = false;
                }

            }
            catch
            {

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadFromListToFields();
        }
    }
}
