using AdsADONET.Entities;
using AdsADONET.Repository;

namespace AdsADONET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            ListingRepo repo = new ListingRepo();

            listBoxResult.DisplayMember = "Title";
            listBoxResult.ValueMember = "ListingID";
            listBoxResult.DataSource= repo.GetListings(textBoxSearch.Text, comboBoxFilter.Text);
        }
    }
}
