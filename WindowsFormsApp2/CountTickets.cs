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
    public partial class CountTickets : Form
    {
        string start_date, end_date;
        public CountTickets(string startdate, string enddate)
        {
            start_date =startdate;
            end_date =enddate;
            InitializeComponent();
        }

        private void CountTickets_Load(object sender, EventArgs e)
        {
            string text = "с " + start_date + " по " + end_date;
            period.Text = text;
            this.getCountTicketsDatesTableAdapter.Fill(this.cinemaDataSet.getCountTicketsDates, start_date, end_date);
            this.reportViewer1.RefreshReport();
        }
    }
}
