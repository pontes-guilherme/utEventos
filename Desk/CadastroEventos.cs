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
    public partial class CadastroEventos : Form
    {
        Usuario currentUser;
        Evento evento;

        public CadastroEventos(Usuario u)
        {
            InitializeComponent();
            currentUser = u;

            this.cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void CadastroEventos_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

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

                evento.criador = currentUser.email;
                evento.nome = txtNome.Text;
                evento.data_inicio = DateTime.Parse(dtInicio.Text);
                evento.data_fim = DateTime.Parse(dtFim.Text);
                evento.importante = ckbImportante.Checked;
                evento.categoria = cmbCategoria.Text;
                //MODIFICAR ESCOPO
                evento.escopo = currentUser.tipo;

                if (!pnEventos.Inserir(evento))
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
