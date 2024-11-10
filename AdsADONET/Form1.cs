using AdsADONET.Entities;
using AdsADONET.Repository;

namespace AdsADONET
{
    public partial class Form1 : Form
    {
        private ListingRepo listingRepo = new ListingRepo();
        private CategoryRepo categoryRepo = new CategoryRepo();
        private string sortBy;
        public Form1()
        {
            InitializeComponent();
            LoadCategories();
            labelLoginStatus.Text = "Not logged in.";
            buttonLogOut.Hide();
            buttonSaveUpdate.Hide();
            comboBoxCategory.Hide();
        }
        private void LoadCategories()
        {
            comboBoxSearchFilter.DisplayMember = "CategoryName";
            comboBoxSearchFilter.ValueMember = "CategoryID";
            comboBoxSearchFilter.DataSource = categoryRepo.GetCategories();
        }
        private bool IsUserLoggedIn()
        {
            if (UserRepo.GetAccountID() > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Must be logged in to create or edit listings");
                return false;
            }
        }
        public string GetSorting()
        {
            if (checkBoxSortByPrice.Checked)
            {
                return "Price";
            }
            else if (checkBoxSortByDate.Checked)
            {
                return "Date";
            }
            return null;
        }
        public void UnlockControlsForUpdate()
        {
            textBoxCategory.Hide();
            comboBoxCategory.Show();
            buttonUpdate.Hide();
            buttonSaveUpdate.Show();
            textBoxTitle.ReadOnly = false;
            textBoxDescription.ReadOnly = false;
            textBoxPrice.ReadOnly = false;
            labelListing.Text = "Update listing";
        }
        public void LockUpdateControls()
        {
            textBoxCategory.Show();
            comboBoxCategory.Hide();
            buttonUpdate.Show();
            buttonSaveUpdate.Hide();
            textBoxTitle.ReadOnly = true;
            textBoxDescription.ReadOnly = true;
            textBoxPrice.ReadOnly = true;
            labelListing.Text = "Listing";
        }
        public void ClearListBox()
        {
            listBoxResult.DataSource = null;
            listBoxResult.Items.Clear();
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            sortBy = GetSorting();
            listBoxResult.DisplayMember = "TitlePriceDate";
            listBoxResult.ValueMember = "ListingID";
            listBoxResult.DataSource = listingRepo.GetListings(textBoxSearch.Text, comboBoxSearchFilter.Text, sortBy);

            listBoxResult.SelectedIndex = -1;
        }

        private void listBoxResult_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBoxResult.SelectedItem is Listing selectedListing)
            {
                textBoxTitle.Text = selectedListing.Title;
                textBoxCategory.Text = selectedListing.Category.CategoryName.ToString();
                textBoxDescription.Text = selectedListing.ItemDescription;
                textBoxPrice.Text = selectedListing.Price.ToString();
                textBoxListingDate.Text = selectedListing.ListingDate.ToString();
                textBoxListedBy.Text = selectedListing.User.UserName.ToString();
            }
            else
            {
                textBoxTitle.Clear();
                textBoxCategory.Clear();
                textBoxDescription.Clear();
                textBoxPrice.Clear();
                textBoxListingDate.Clear();
                textBoxListedBy.Clear();
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (IsUserLoggedIn() == true)
            {
                FormCreateListing createListing = new FormCreateListing();
                createListing.ShowDialog();
                ClearListBox();
            }
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

            if (IsUserLoggedIn() == true)
            {
                labelLoginStatus.Text = $"Logged in as: {UserRepo.GetAccountName()}";
                buttonLogin.Hide();
                buttonLogOut.Show();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (IsUserLoggedIn() == true)
            {
                if (listBoxResult.SelectedItem is Listing selectedListing)
                {
                    bool accountIDMatch = listingRepo.DeleteListing(selectedListing.ListingID, selectedListing.User.UserID);
                    if (accountIDMatch == true)
                    {
                        sortBy = GetSorting();
                        listBoxResult.DataSource = listingRepo.GetListings(textBoxSearch.Text, comboBoxSearchFilter.Text, sortBy);
                        MessageBox.Show("Listing has been deleted.");
                        ClearListBox();
                    }
                    else
                    {
                        MessageBox.Show("You cannot delete other listings than your own.");
                    }
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (IsUserLoggedIn() == true)
            {
                UnlockControlsForUpdate();
                comboBoxCategory.DisplayMember = "CategoryName";
                comboBoxCategory.ValueMember = "CategoryID";
                comboBoxCategory.DataSource = categoryRepo.GetCategories();
            }
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            UserRepo.SetAccountIDToZero();
            labelLoginStatus.Text = "Not logged in.";
            buttonLogin.Show();
            buttonLogOut.Hide();
        }

        private void buttonSaveUpdate_Click(object sender, EventArgs e)
        {
            if (listBoxResult.SelectedItem is Listing selectedListing)
            {

                if (!string.IsNullOrEmpty(comboBoxCategory.Text) &&
                    !string.IsNullOrEmpty(textBoxTitle.Text) &&
                    !string.IsNullOrEmpty(textBoxDescription.Text) &&
                    !string.IsNullOrEmpty(textBoxPrice.Text))
                {
                    if (decimal.TryParse(textBoxPrice.Text, out decimal price))
                    {
                        int categoryID = categoryRepo.GetCategoryID(comboBoxCategory.Text);
                        bool accountIDMatch = listingRepo.UpdateListing(selectedListing.ListingID,
                                         textBoxTitle.Text, textBoxDescription.Text, price, categoryID, selectedListing.User.UserID);

                        if (accountIDMatch == true)
                        {
                            MessageBox.Show("Listing has been updated.");
                            ClearListBox();
                            LockUpdateControls();
                        }
                        else
                        {
                            MessageBox.Show("You cannot update other listings than your own.");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Price must be typed in numbers only.");
                    }
                }
                else
                {
                    MessageBox.Show("One or more textboxes are empty.");
                }

            }
        }
    }
}
