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
    public partial class CadastroCategoria : Form
    {
        Categoria categoria;

        public CadastroCategoria(Usuario u)
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            categoria = new Categoria();

            try
            {

                categoria.nome = txtNome.Text;

                if (!pnCategorias.Inserir(categoria))
                {
                    MessageBox.Show("Problema na inserção de categoria!");
                }
                else
                {
                    MessageBox.Show("Cadastro realizado com sucesso.");

                    this.categoriasTableAdapter.ClearBeforeFill = true;
                    this.categoriasTableAdapter.Fill(this.dbEventosDataSet.Categorias);

                }
            }

            catch (Exception ex)
            {
                //throw;
                MessageBox.Show(ex.ToString());
            }

        }

        private void CadastroCategoria_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbEventosDataSet.Categorias' table. You can move, or remove it, as needed.
            this.categoriasTableAdapter.Fill(this.dbEventosDataSet.Categorias);
            // TODO: This line of code loads data into the 'dbEventosDataSet.Evento' table. You can move, or remove it, as needed.
           

        }

        private void categoriasDataGridView_Leave(object sender, EventArgs e)
        {
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
            try
            {
                categoria = new Categoria();
                String nome = categoriasDataGridView.SelectedCells[0].Value.ToString();
                if (nome == "Outro")
                {
                    MessageBox.Show("Não é possível excluir essa categoria!");
                    return;
                }
                if (MessageBox.Show("Deseja realmente excuir?", "Excluir?", MessageBoxButtons.YesNo) == DialogResult.Yes )
                {
                    categoria.nome = nome;
                    pnCategorias.Excluir(categoria);

                    this.categoriasTableAdapter.ClearBeforeFill = true;
                    this.categoriasTableAdapter.Fill(this.dbEventosDataSet.Categorias);

                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //MessageBox.Show("É necessário selecionar um item");
            }
            
        }
    }
}
