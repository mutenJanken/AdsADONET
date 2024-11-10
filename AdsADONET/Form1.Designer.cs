namespace AdsADONET
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            buttonSearch = new Button();
            buttonUpdate = new Button();
            textBoxSearch = new TextBox();
            comboBoxSearchFilter = new ComboBox();
            categoryRepoBindingSource1 = new BindingSource(components);
            listBoxResult = new ListBox();
            groupBox1 = new GroupBox();
            textBoxListedBy = new TextBox();
            label7 = new Label();
            label5 = new Label();
            buttonSaveUpdate = new Button();
            textBoxCategory = new TextBox();
            label6 = new Label();
            comboBoxCategory = new ComboBox();
            labelListing = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBoxListingDate = new TextBox();
            labelPrice = new Label();
            textBoxPrice = new TextBox();
            textBoxDescription = new TextBox();
            textBoxTitle = new TextBox();
            buttonDelete = new Button();
            buttonCreate = new Button();
            labelFilter = new Label();
            buttonLogin = new Button();
            buttonRegister = new Button();
            label1 = new Label();
            categoryRepoBindingSource = new BindingSource(components);
            labelLoginStatus = new Label();
            buttonLogOut = new Button();
            checkBoxSortByPrice = new CheckBox();
            checkBoxSortByDate = new CheckBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)categoryRepoBindingSource1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)categoryRepoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(259, 84);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(75, 24);
            buttonSearch.TabIndex = 0;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(184, 311);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(75, 23);
            buttonUpdate.TabIndex = 1;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(38, 84);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Search ads";
            textBoxSearch.Size = new Size(215, 23);
            textBoxSearch.TabIndex = 2;
            // 
            // comboBoxSearchFilter
            // 
            comboBoxSearchFilter.FormattingEnabled = true;
            comboBoxSearchFilter.Location = new Point(38, 134);
            comboBoxSearchFilter.Name = "comboBoxSearchFilter";
            comboBoxSearchFilter.Size = new Size(296, 23);
            comboBoxSearchFilter.TabIndex = 3;
            // 
            // categoryRepoBindingSource1
            // 
            categoryRepoBindingSource1.DataSource = typeof(Repository.CategoryRepo);
            // 
            // listBoxResult
            // 
            listBoxResult.FormattingEnabled = true;
            listBoxResult.ItemHeight = 15;
            listBoxResult.Location = new Point(38, 163);
            listBoxResult.Name = "listBoxResult";
            listBoxResult.Size = new Size(296, 304);
            listBoxResult.TabIndex = 4;
            listBoxResult.SelectedIndexChanged += listBoxResult_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxListedBy);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(buttonSaveUpdate);
            groupBox1.Controls.Add(textBoxCategory);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(comboBoxCategory);
            groupBox1.Controls.Add(labelListing);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxListingDate);
            groupBox1.Controls.Add(labelPrice);
            groupBox1.Controls.Add(textBoxPrice);
            groupBox1.Controls.Add(textBoxDescription);
            groupBox1.Controls.Add(textBoxTitle);
            groupBox1.Controls.Add(buttonDelete);
            groupBox1.Controls.Add(buttonUpdate);
            groupBox1.Location = new Point(375, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(285, 415);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Listing";
            // 
            // textBoxListedBy
            // 
            textBoxListedBy.Location = new Point(25, 365);
            textBoxListedBy.Name = "textBoxListedBy";
            textBoxListedBy.ReadOnly = true;
            textBoxListedBy.Size = new Size(136, 23);
            textBoxListedBy.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 351);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 17;
            label7.Text = "Listed by:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(103, 286);
            label5.Name = "label5";
            label5.Size = new Size(13, 15);
            label5.TabIndex = 16;
            label5.Text = "$";
            // 
            // buttonSaveUpdate
            // 
            buttonSaveUpdate.Location = new Point(184, 311);
            buttonSaveUpdate.Name = "buttonSaveUpdate";
            buttonSaveUpdate.Size = new Size(75, 23);
            buttonSaveUpdate.TabIndex = 15;
            buttonSaveUpdate.Text = "Save";
            buttonSaveUpdate.UseVisualStyleBackColor = true;
            buttonSaveUpdate.Click += buttonSaveUpdate_Click;
            // 
            // textBoxCategory
            // 
            textBoxCategory.Location = new Point(25, 110);
            textBoxCategory.Name = "textBoxCategory";
            textBoxCategory.ReadOnly = true;
            textBoxCategory.Size = new Size(234, 23);
            textBoxCategory.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 92);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 13;
            label6.Text = "Category";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(25, 110);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(234, 23);
            comboBoxCategory.TabIndex = 12;
            // 
            // labelListing
            // 
            labelListing.AutoSize = true;
            labelListing.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelListing.Location = new Point(103, 28);
            labelListing.Name = "labelListing";
            labelListing.Size = new Size(58, 20);
            labelListing.TabIndex = 12;
            labelListing.Text = "Listing";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 136);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 11;
            label4.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 47);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 10;
            label3.Text = "Titel";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 309);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 9;
            label2.Text = "Created:";
            // 
            // textBoxListingDate
            // 
            textBoxListingDate.Location = new Point(25, 324);
            textBoxListingDate.Name = "textBoxListingDate";
            textBoxListingDate.ReadOnly = true;
            textBoxListingDate.Size = new Size(136, 23);
            textBoxListingDate.TabIndex = 8;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(25, 265);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(36, 15);
            labelPrice.TabIndex = 7;
            labelPrice.Text = "Price:";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(25, 283);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.ReadOnly = true;
            textBoxPrice.Size = new Size(77, 23);
            textBoxPrice.TabIndex = 6;
            textBoxPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(25, 154);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.ReadOnly = true;
            textBoxDescription.Size = new Size(234, 105);
            textBoxDescription.TabIndex = 5;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(25, 65);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.ReadOnly = true;
            textBoxTitle.Size = new Size(234, 23);
            textBoxTitle.TabIndex = 4;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(184, 282);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(198, 476);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(136, 23);
            buttonCreate.TabIndex = 3;
            buttonCreate.Text = "Create new listing";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // labelFilter
            // 
            labelFilter.AutoSize = true;
            labelFilter.Location = new Point(38, 116);
            labelFilter.Name = "labelFilter";
            labelFilter.Size = new Size(33, 15);
            labelFilter.TabIndex = 6;
            labelFilter.Text = "Filter";
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(585, 27);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(75, 23);
            buttonLogin.TabIndex = 7;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(504, 27);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(75, 23);
            buttonRegister.TabIndex = 8;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 17);
            label1.Name = "label1";
            label1.Size = new Size(71, 32);
            label1.TabIndex = 9;
            label1.Text = "bBay";
            // 
            // categoryRepoBindingSource
            // 
            categoryRepoBindingSource.DataSource = typeof(Repository.CategoryRepo);
            // 
            // labelLoginStatus
            // 
            labelLoginStatus.AutoSize = true;
            labelLoginStatus.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLoginStatus.Location = new Point(375, 64);
            labelLoginStatus.Name = "labelLoginStatus";
            labelLoginStatus.Size = new Size(92, 17);
            labelLoginStatus.TabIndex = 10;
            labelLoginStatus.Text = "Not logged in";
            // 
            // buttonLogOut
            // 
            buttonLogOut.Location = new Point(585, 27);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(75, 23);
            buttonLogOut.TabIndex = 11;
            buttonLogOut.Text = "Log out";
            buttonLogOut.UseVisualStyleBackColor = true;
            buttonLogOut.Click += buttonLogOut_Click;
            // 
            // checkBoxSortByPrice
            // 
            checkBoxSortByPrice.AutoSize = true;
            checkBoxSortByPrice.Location = new Point(226, 112);
            checkBoxSortByPrice.Name = "checkBoxSortByPrice";
            checkBoxSortByPrice.Size = new Size(52, 19);
            checkBoxSortByPrice.TabIndex = 12;
            checkBoxSortByPrice.Text = "Price";
            checkBoxSortByPrice.UseVisualStyleBackColor = true;
            // 
            // checkBoxSortByDate
            // 
            checkBoxSortByDate.AutoSize = true;
            checkBoxSortByDate.Location = new Point(284, 112);
            checkBoxSortByDate.Name = "checkBoxSortByDate";
            checkBoxSortByDate.Size = new Size(50, 19);
            checkBoxSortByDate.TabIndex = 13;
            checkBoxSortByDate.Text = "Date";
            checkBoxSortByDate.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(173, 113);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 14;
            label8.Text = "Sort by:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 536);
            Controls.Add(label8);
            Controls.Add(checkBoxSortByDate);
            Controls.Add(checkBoxSortByPrice);
            Controls.Add(buttonLogOut);
            Controls.Add(labelLoginStatus);
            Controls.Add(label1);
            Controls.Add(buttonRegister);
            Controls.Add(buttonLogin);
            Controls.Add(labelFilter);
            Controls.Add(buttonCreate);
            Controls.Add(groupBox1);
            Controls.Add(listBoxResult);
            Controls.Add(comboBoxSearchFilter);
            Controls.Add(textBoxSearch);
            Controls.Add(buttonSearch);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)categoryRepoBindingSource1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)categoryRepoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSearch;
        private Button buttonUpdate;
        private TextBox textBoxSearch;
        private ComboBox comboBoxSearchFilter;
        private ListBox listBoxResult;
        private GroupBox groupBox1;
        private Label labelFilter;
        private Button buttonCreate;
        private Button buttonDelete;
        private Button buttonLogin;
        private Button buttonRegister;
        private Label labelPrice;
        private TextBox textBoxPrice;
        private TextBox textBoxDescription;
        private TextBox textBoxTitle;
        private Label label1;
        private BindingSource categoryRepoBindingSource1;
        private BindingSource categoryRepoBindingSource;
        private Label label2;
        private TextBox textBoxListingDate;
        private Label labelLoginStatus;
        private Button buttonLogOut;
        private Label labelListing;
        private Label label4;
        private Label label3;
        private TextBox textBoxCategory;
        private Label label6;
        private ComboBox comboBoxCategory;
        private Button buttonSaveUpdate;
        private Label label5;
        private TextBox textBoxListedBy;
        private Label label7;
        private CheckBox checkBoxSortByPrice;
        private CheckBox checkBoxSortByDate;
        private Label label8;
    }
}
