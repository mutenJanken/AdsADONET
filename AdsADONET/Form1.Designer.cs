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
            comboBoxFilter = new ComboBox();
            categoryRepoBindingSource1 = new BindingSource(components);
            listBoxResult = new ListBox();
            groupBox1 = new GroupBox();
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
            ((System.ComponentModel.ISupportInitialize)categoryRepoBindingSource1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)categoryRepoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(496, 314);
            buttonSearch.Margin = new Padding(6);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(139, 51);
            buttonSearch.TabIndex = 0;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(46, 518);
            buttonUpdate.Margin = new Padding(6);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(139, 49);
            buttonUpdate.TabIndex = 1;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(85, 314);
            textBoxSearch.Margin = new Padding(6);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Search ads";
            textBoxSearch.Size = new Size(396, 39);
            textBoxSearch.TabIndex = 2;
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.Location = new Point(85, 407);
            comboBoxFilter.Margin = new Padding(6);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(546, 40);
            comboBoxFilter.TabIndex = 3;
            // 
            // categoryRepoBindingSource1
            // 
            categoryRepoBindingSource1.DataSource = typeof(Repository.CategoryRepo);
            // 
            // listBoxResult
            // 
            listBoxResult.FormattingEnabled = true;
            listBoxResult.Location = new Point(85, 469);
            listBoxResult.Margin = new Padding(6);
            listBoxResult.Name = "listBoxResult";
            listBoxResult.Size = new Size(546, 420);
            listBoxResult.TabIndex = 4;
            listBoxResult.SelectedIndexChanged += listBoxResult_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelPrice);
            groupBox1.Controls.Add(textBoxPrice);
            groupBox1.Controls.Add(textBoxDescription);
            groupBox1.Controls.Add(textBoxTitle);
            groupBox1.Controls.Add(buttonDelete);
            groupBox1.Controls.Add(buttonUpdate);
            groupBox1.Location = new Point(711, 314);
            groupBox1.Margin = new Padding(6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6);
            groupBox1.Size = new Size(529, 580);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Listing";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(217, 444);
            labelPrice.Margin = new Padding(6, 0, 6, 0);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(70, 32);
            labelPrice.TabIndex = 7;
            labelPrice.Text = "Price:";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(295, 437);
            textBoxPrice.Margin = new Padding(6);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(182, 39);
            textBoxPrice.TabIndex = 6;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(46, 117);
            textBoxDescription.Margin = new Padding(6);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(431, 303);
            textBoxDescription.TabIndex = 5;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(46, 55);
            textBoxTitle.Margin = new Padding(6);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(431, 39);
            textBoxTitle.TabIndex = 4;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(338, 518);
            buttonDelete.Margin = new Padding(6);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(139, 49);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(378, 901);
            buttonCreate.Margin = new Padding(6);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(253, 49);
            buttonCreate.TabIndex = 3;
            buttonCreate.Text = "Create new listing";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // labelFilter
            // 
            labelFilter.AutoSize = true;
            labelFilter.Location = new Point(85, 369);
            labelFilter.Margin = new Padding(6, 0, 6, 0);
            labelFilter.Name = "labelFilter";
            labelFilter.Size = new Size(67, 32);
            labelFilter.TabIndex = 6;
            labelFilter.Text = "Filter";
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(1101, 252);
            buttonLogin.Margin = new Padding(6);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(139, 49);
            buttonLogin.TabIndex = 7;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(951, 252);
            buttonRegister.Margin = new Padding(6);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(139, 49);
            buttonRegister.TabIndex = 8;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(110, 90);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(141, 65);
            label1.TabIndex = 9;
            label1.Text = "bBay";
            // 
            // categoryRepoBindingSource
            // 
            categoryRepoBindingSource.DataSource = typeof(Repository.CategoryRepo);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 994);
            Controls.Add(label1);
            Controls.Add(buttonRegister);
            Controls.Add(buttonLogin);
            Controls.Add(labelFilter);
            Controls.Add(buttonCreate);
            Controls.Add(groupBox1);
            Controls.Add(listBoxResult);
            Controls.Add(comboBoxFilter);
            Controls.Add(textBoxSearch);
            Controls.Add(buttonSearch);
            Margin = new Padding(6);
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
        private ComboBox comboBoxFilter;
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
    }
}
