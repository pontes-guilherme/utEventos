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

        public MeusEventos(Usuario u, string opc)
        {
            InitializeComponent();
            this.current_user = u;
            this.opc = opc;

            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = false;

            dbEventosDataSet.EventosDataTable EventosDT = new dbEventosDataSet.EventosDataTable();
            var dataAdapter = new dbEventosDataSetTableAdapters.EventosTableAdapter();

            dataAdapter.FillByEmail(EventosDT, u.email);
            eventosBindingSource.DataSource = EventosDT;

            if (this.opc == "meus")
            {
                //eventosTableAdapter1.FillByEmail(eventoDT, current_user.email.ToString());
            }

        }

        private void MeusEventos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbEventosDataSet.Evento' table. You can move, or remove it, as needed.
            //this.eventoTableAdapter.Fill(this.dbEventosDataSet.Evento);
            // TODO: This line of code loads data into the 'dbEventosDataSet.Evento' table. You can move, or remove it, as needed.
            Console.WriteLine(current_user.email);
            

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.eventosTableAdapter1.FillByEmail(this.dbEventosDataSet1.Eventos, emailToolStripTextBox.Text);
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
                //this.eventosTableAdapter1.FillByEmail(this.dbEventosDataSet1.Eventos, emailToolStripTextBox.Text);
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
                //this.eventosTableAdapter1.FillByEmail(this.dbEventosDataSet1.Eventos, emailToolStripTextBox.Text);
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
                //this.eventosTableAdapter1.FillByEmail(this.dbEventosDataSet1.Eventos, emailToolStripTextBox.Text);
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
                //this.eventosTableAdapter1.FillByEmail(this.dbEventosDataSet1.Eventos, emailToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByDayToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.eventosTableAdapter1.FillByDay(this.dbEventosDataSet1.Eventos);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByEmailToolStripButton_Click_5(object sender, EventArgs e)
        {
            try
            {
                //this.eventosTableAdapter1.FillByEmail(this.dbEventosDataSet1.Eventos, emailToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByDayToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                //this.eventosTableAdapter1.FillByDay(this.dbEventosDataSet1.Eventos);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByMONTH2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.eventosTableAdapter1.FillByMONTH2(this.dbEventosDataSet1.Eventos);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByWeekToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.eventosTableAdapter1.FillByWeek(this.dbEventosDataSet1.Eventos);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByEmailToolStripButton_Click_6(object sender, EventArgs e)
        {
            try
            {
                //this.eventosTableAdapter1.FillByEmail(this.dbEventosDataSet1.Eventos, emailToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.eventosTableAdapter1.FillBy(this.dbEventosDataSet.Eventos);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
