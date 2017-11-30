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

        public CadastroEventos(Usuario u)
        {
            InitializeComponent();
            currentUser = u;

            this.cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            int i = 0;
            lista_categorias.ForEach(delegate (Categoria c) {

                cmbCategoria.Items.Insert(i, c.nome.ToString());
                i++;
            });

        }

        private void CadastroEventos_Load(object sender, EventArgs e)
        {
            //seleciona o primeiro item das categorias por default
            cmbCategoria.SelectedIndex = 0;
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
                evento.importante = ckbImportante.Checked;
                evento.Categoria = c;
                evento.Categoria_nome = c.nome;
                //MODIFICAR ESCOPO
                evento.escopo = currentUser.tipo;

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
                throw;
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
