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
using Modelo;
using System.Data.Entity;

namespace Desk
{
    public partial class CadastroEventos : Form
    {
        Usuario currentUser;
        Evento evento;
       
        
        List<Categoria> lista_categorias = pnCategorias.Listar();
        List<Disciplina> lista_disciplinas = pnDisciplinas.Listar();

        public CadastroEventos(Usuario u)
        {
            InitializeComponent();
            currentUser = u;

            this.cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbEscopo.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbDisciplina.DropDownStyle = ComboBoxStyle.DropDownList;

            loadCmbDisciplinas();
            loadCmbCategorias();

            if (u.tipo != "Administrador")
            {
                cmbEscopo.Items.Remove("Global");
            }

        }
    
        private void loadCmbDisciplinas()
        {
            int i = 0;

            lista_disciplinas.ForEach(delegate (Disciplina d) {

                cmbDisciplina.Items.Insert(i, d.nome.ToString());
                i++;
            });

        }

        private void loadCmbCategorias ()
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

        private void CadastroEventos_Load(object sender, EventArgs e)
        {
            //seleciona o primeiro item das categorias por default
            try
            {
                cmbCategoria.SelectedIndex = 0;
            }
            catch
            {
                cmbCategoria.Items.Insert(0, "Outro");
                cmbCategoria.SelectedIndex = 0;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //var context = new EventContext();
            evento = new Evento();
            

            DateTime data_inicio = DateTime.Parse(dtInicio.Text);
            DateTime data_fim = DateTime.Parse(dtFim.Text);

            if (data_inicio > data_fim)
            {
                MessageBox.Show("Data fim deve ser maior ou igual à data início!");
                return;
            } 

            if (txtNome.Text == "" || cmbCategoria.Text=="")
            {
                MessageBox.Show("Os campos devem ser corretament preenchidos!");
                return;
            }

            try
            {

                dbEventosEntities db = new dbEventosEntities();
                
                Categoria c = db.Categorias.Find(cmbCategoria.Text);
                

                evento.criador = currentUser.email;
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
                
                if (!pnEventos.Inserir(evento, db))
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

        private void cmbEscopo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEscopo.SelectedIndex == 2)
            {
                cmbDisciplina.Visible = true;
                cmbDisciplina.SelectedIndex = 0;
            } else
            {
                cmbDisciplina.Visible = false;
            }
        }
    }
}
