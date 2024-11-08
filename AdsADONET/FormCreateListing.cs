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
        public FormCreateListing()
        {
            InitializeComponent();
            LoadCategories();
        }
        private void LoadCategories()
        {
            CategoryRepo categoryRepo = new CategoryRepo();

            comboBoxFilter.DisplayMember = "CategoryName";
            comboBoxFilter.ValueMember = "CategoryID";
            comboBoxFilter.DataSource = categoryRepo.GetCategories();
        }
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            ListingRepo repo = new ListingRepo();

            repo.CreateListing(textBoxAddTitle.Text, textBoxAddDescription.Text, textBoxAddPrice.Text, comboBoxFilter.Text);
        }
    }
}
