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
    public partial class MeusEventos : Form
    {
        public MeusEventos(Usuario u)
        {
            InitializeComponent();
            dbEventosDataSet.EventoDataTable eventoDT = new dbEventosDataSet.EventoDataTable();
            eventoTableAdapter.Fill(eventoDT);
            dataGridView1.DataSource = eventoDT;
            //((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = "criador = " + u.email;
        }

        private void MeusEventos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbEventosDataSet.Evento' table. You can move, or remove it, as needed.
            this.eventoTableAdapter.Fill(this.dbEventosDataSet.Evento);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.eventoTableAdapter.FillBy(this.dbEventosDataSet.Evento, emailToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
