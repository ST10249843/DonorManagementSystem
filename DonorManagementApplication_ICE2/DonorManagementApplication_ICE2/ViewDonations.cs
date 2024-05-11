using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonorManagementApplication_ICE2
{
    public partial class ViewDonations : Form
    {
        public ViewDonations()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuOptions menu = new MenuOptions();
            this.Hide();
            menu.Show();
        }
    }
}
