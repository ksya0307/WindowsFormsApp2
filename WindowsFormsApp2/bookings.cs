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
    public partial class bookings : Form
    {
        int id_user;
        public bookings(string iduser)
        {
            id_user = Int32.Parse(iduser);
            InitializeComponent();
        }

        private void bookings_Load(object sender, EventArgs e)
        {
            this.cinemaDataSet.EnforceConstraints = false;
            this.get_bookingTableAdapter.Fill(this.cinemaDataSet.get_booking, id_user);
            this.reportViewer1.RefreshReport();
        }

        private void openbuybook_Click(object sender, EventArgs e)
        {
            this.Close();
            buybook buybook = new buybook(id_user);
            buybook.ShowDialog();
        }

    }
}
