using AdsADONET.Entities;
using AdsADONET.Repository;

namespace AdsADONET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadCategories();
            comboBoxFilter.Text = "";
        }
        private void LoadCategories()
        {
            CategoryRepo categoryRepo = new CategoryRepo();

            comboBoxFilter.DisplayMember = "CategoryName";
            comboBoxFilter.ValueMember = "CategoryID";
            comboBoxFilter.DataSource = categoryRepo.GetCategories();
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            ListingRepo listingRepo = new ListingRepo();


            listBoxResult.DisplayMember = "Title";
            listBoxResult.ValueMember = "ListingID";
            listBoxResult.DataSource = listingRepo.GetListings(textBoxSearch.Text, comboBoxFilter.Text);

            listBoxResult.SelectedIndex = -1;
        }

        private void listBoxResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxResult.SelectedItem is Listing selectedListing)
            {
                textBoxTitle.Text = selectedListing.Title;
                textBoxDescription.Text = selectedListing.ItemDescription;
                textBoxPrice.Text = "$" + selectedListing.Price.ToString();
            }
            else
            {
                textBoxTitle.Clear();
                textBoxDescription.Clear();
                textBoxPrice.Clear();
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            FormCreateListing createListing = new FormCreateListing();
            createListing.ShowDialog();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            FormRegisterAccount registerAccount = new FormRegisterAccount();
            registerAccount.ShowDialog();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
        }
    }
}
