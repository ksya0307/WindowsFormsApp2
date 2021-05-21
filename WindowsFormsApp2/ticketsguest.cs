using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace WindowsFormsApp2
{
    public partial class ticketsguest : Form
    {
        int id_user;
        public ticketsguest(string iduser)
        {
            id_user = Int32.Parse(iduser);
            Console.WriteLine(iduser + "");
            InitializeComponent();
        }
        private void ticketsguest_Load(object sender, EventArgs e)
        {
            this.get_ticketTableAdapter.Fill(cinemaDataSet.get_ticket, id_user);
            reportViewer1.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
