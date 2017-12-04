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
using System.Data.SqlClient;

namespace Desk
{
    public partial class MeusEventos : Form
    {
        Usuario current_user;
        string opc;

        List<Categoria> lista_categorias = pnCategorias.Listar();
        List<Disciplina> lista_disciplinas = pnDisciplinas.Listar();

        public MeusEventos(Usuario u, string opc)
        {
            InitializeComponent();
            this.current_user = u;
            this.opc = opc;

            this.cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbEscopo.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbDisciplina.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbPesquisar.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbPesquisar.SelectedIndex = 0;

            loadCmbCategorias();
            loadCmbDisciplinas();

            if (this.opc == "meus")
            {
                //eventosTableAdapter1.FillByEmail(eventoDT, current_user.email.ToString());
            }

            if (u.tipo != "Administrador")
            {
                cmbEscopo.Items.Remove("Global");
            }

        }

        private void MeusEventos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbEventosDataSet.Eventos' table. You can move, or remove it, as needed.
            this.eventosTableAdapter.FillByEmail(this.dbEventosDataSet.Eventos, current_user.email);
            //loadFromDb();
            //loadFromListToFields();
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadFromListToFields();
            //this.Refresh();
        }

        private void loadFromDb()
        {
            List<Evento> lista_eventos = pnEventos.Listar();


            try
            {
               

                listBox1.DataSource = lista_eventos;
 
               
            }catch
            {

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


        private void cmbEscopo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEscopo.SelectedIndex == 2)
            {
                cmbDisciplina.Visible = true;
                cmbDisciplina.SelectedIndex = 0;
            }
            else
            {
                cmbDisciplina.Visible = false;
            }
        }

        private void btnAlterar_Click_1(object sender, EventArgs e)
        {
            DateTime data_inicio = DateTime.Parse(dtInicio.Text);
            DateTime data_fim = DateTime.Parse(dtFim.Text);

            if (data_inicio > data_fim)
            {
                MessageBox.Show("Data fim deve ser maior ou igual à data início!");
                return;
            }

            if (txtNome.Text == "" || cmbCategoria.Text == "")
            {
                MessageBox.Show("Os campos devem ser corretament preenchidos!");
                return;
            }

            try
            {

                dbEventosEntities db = new dbEventosEntities();
                Evento evento = db.Eventoes.Find(listBox1.SelectedValue);

                Categoria c = db.Categorias.Find(cmbCategoria.Text);

                evento.criador = current_user.email;
                evento.nome = txtNome.Text;
                evento.data_inicio = DateTime.Parse(dtInicio.Text);
                evento.data_fim = DateTime.Parse(dtFim.Text);
                evento.capacidade = int.Parse(txtCapacidade.Value.ToString());
                evento.importante = ckbImportante.Checked;

                evento.Categoria = c;
                evento.Categoria_nome = c.nome;

                if (cmbEscopo.SelectedIndex == 2)
                {
                    Disciplina d = db.Disciplinas.Find(cmbDisciplina.SelectedItem);
                    evento.Disciplina = d;
                    evento.Disciplina_nome = d.nome;
                }

                evento.escopo = cmbEscopo.SelectedItem.ToString();

                if (!pnEventos.Alterar(evento, db))
                {
                    MessageBox.Show("Problema na inserção de evento!");
                }
                else
                {
                    MessageBox.Show("Cadastro realizado com sucesso.");
                    this.Hide();
                }


            }

            catch (Exception ex)
            {
                //throw;
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
