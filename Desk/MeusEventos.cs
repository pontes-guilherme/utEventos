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
        Usuario current_user;
        public MeusEventos(Usuario u)
        {
            InitializeComponent();
            this.current_user = u;
            dbEventosDataSet.EventoDataTable eventoDT = new dbEventosDataSet.EventoDataTable();
            eventoTableAdapter.Fill(eventoDT);
            dataGridView1.DataSource = eventoDT;
            //((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = "criador = " + u.email;
        }

        private void MeusEventos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbEventosDataSet.Evento' table. You can move, or remove it, as needed.
            //this.eventoTableAdapter.Fill(this.dbEventosDataSet.Evento);
            // TODO: This line of code loads data into the 'dbEventosDataSet.Evento' table. You can move, or remove it, as needed.
            Console.WriteLine(current_user.email);
            this.eventoTableAdapter.FillByEmail(this.dbEventosDataSet.Evento, current_user.email.ToString());

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.eventoTableAdapter.FillByEmail(this.dbEventosDataSet.Evento, emailToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByEmailToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByEmailToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.eventoTableAdapter.FillByEmail(this.dbEventosDataSet.Evento, emailToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByEmailToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                //this.eventoTableAdapter.FillByEmail(this.dbEventosDataSet.Evento, emailToolStripTextBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByEmailToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.eventoTableAdapter.FillByEmail(this.dbEventosDataSet.Evento, emailToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByEmailToolStripButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                //this.eventoTableAdapter.FillByEmail(this.dbEventosDataSet.Evento, emailToolStripTextBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByEmailToolStripButton_Click_3(object sender, EventArgs e)
        {
            try
            {
                this.eventoTableAdapter.FillByEmail(this.dbEventosDataSet.Evento, emailToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByEmailToolStripButton_Click_4(object sender, EventArgs e)
        {
            try
            {
                this.eventoTableAdapter.FillByEmail(this.dbEventosDataSet.Evento, emailToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
