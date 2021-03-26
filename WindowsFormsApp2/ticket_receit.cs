using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class ticket_receit : Form
    {
        int idticket;
        public ticket_receit(int id_ticket)
        {
            idticket = id_ticket;
            InitializeComponent();
        }
        private void ticket_receit_Load(object sender, EventArgs e)
        {
            this.ticket_receitTableAdapter.Fill(cinemaDataSet.ticket_receit, idticket);
            reportViewer1.RefreshReport();
        }
    }
}
