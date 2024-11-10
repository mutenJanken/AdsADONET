using AdsADONET.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdsADONET
{
    public partial class FormCreateListing : Form
    {
        private CategoryRepo categoryRepo = new CategoryRepo();
        public FormCreateListing()
        {
            InitializeComponent();
            LoadCategories();
        }
        private void LoadCategories()
        {
            comboBoxFilter.DisplayMember = "CategoryName";
            comboBoxFilter.ValueMember = "CategoryID";
            comboBoxFilter.DataSource = categoryRepo.GetCategories();
        }
        private void buttonCreate_Click(object sender, EventArgs e)
        {

            ListingRepo repo = new ListingRepo();
            int categoryID = categoryRepo.GetCategoryID(comboBoxFilter.Text);
            bool isPriceInNumbers = repo.CreateListing(textBoxAddTitle.Text, textBoxAddDescription.Text, textBoxAddPrice.Text, categoryID);

            if (!string.IsNullOrEmpty(comboBoxFilter.Text) &&
               !string.IsNullOrEmpty(textBoxAddTitle.Text) &&
               !string.IsNullOrEmpty(textBoxAddDescription.Text) &&
               !string.IsNullOrEmpty(textBoxAddPrice.Text))
            {
                if (isPriceInNumbers == true)
                {
                    MessageBox.Show("Succesfully created a listing.");
                    this.Close();
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
