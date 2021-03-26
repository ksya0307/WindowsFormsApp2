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
    public partial class reportbuytick : Form
    {
        DateTime date;
        public reportbuytick(string getdate)
        {
            date = Convert.ToDateTime(getdate);
            InitializeComponent();
        }

        private void reportbuytick_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinemaDataSet.report_buy_tickets". При необходимости она может быть перемещена или удалена.
            this.report_buy_ticketsTableAdapter.Fill(this.cinemaDataSet.report_buy_tickets, date);

            this.reportViewer1.RefreshReport();
        }
    }
}
