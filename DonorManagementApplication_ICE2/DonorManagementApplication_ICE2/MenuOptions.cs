using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace DonorManagementApplication_ICE2
{
    public partial class MenuOptions : Form
    {
        public MenuOptions(string name, string surname, string phone, string email)
        {
            InitializeComponent();
            
        }
        public MenuOptions()
        {
            InitializeComponent();

        }

        private void MenuOptions_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Donate_Click(object sender, EventArgs e)
        {
            AddDonations donation = new AddDonations();
            this.Hide();
            donation.Show();
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            ViewDonations view = new ViewDonations();
            this.Hide();
            view.Show();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SearchDonation search = new SearchDonation();
            this.Hide();
            search.Show();
        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            DisplayDonation display = new DisplayDonation();
            this.Hide();
            display.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form1 donor = new Form1();
            this.Hide();
            donor.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
