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
        String filterBy;
        public VisualizarCalendario(Usuario u, String filterBy)
        {
            InitializeComponent();
            this.filterBy = filterBy;
        }

        private void VisualizarCalendario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbEventosDataSet.Evento' table. You can move, or remove it, as needed.
            if (this.filterBy == "mes")
            {
                this.title.Text = "Mensal";
                this.eventoTableAdapter.FillByMONTH2(this.dbEventosDataSet.Evento);
            } else if (this.filterBy == "semana")
            {
                this.title.Text = "Semanal";
                this.eventoTableAdapter.FillByWeek(this.dbEventosDataSet.Evento);
            } else if (this.filterBy == "dia")
            {
                this.title.Text = "Diário";
                this.eventoTableAdapter.FillByDay(this.dbEventosDataSet.Evento);
            }
            

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByMonthToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.eventoTableAdapter.FillByMonth(this.dbEventosDataSet.Evento);
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
                this.eventoTableAdapter.FillByMONTH2(this.dbEventosDataSet.Evento);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByMONTH2ToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.eventoTableAdapter.FillByMONTH2(this.dbEventosDataSet.Evento);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByMONTH2ToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.eventoTableAdapter.FillByMONTH2(this.dbEventosDataSet.Evento);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByMONTH2ToolStripButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.eventoTableAdapter.FillByMONTH2(this.dbEventosDataSet.Evento);
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
                //this.eventoTableAdapter.FillByEmail(this.dbEventosDataSet.Evento, emailToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
