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
            buttonCreate = new Button();
            buttonDelete = new Button();
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
            buttonSearch.Location = new Point(267, 147);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(75, 24);
            buttonSearch.TabIndex = 0;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(6, 243);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(75, 23);
            buttonUpdate.TabIndex = 1;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(46, 147);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Search ads";
            textBoxSearch.Size = new Size(215, 23);
            textBoxSearch.TabIndex = 2;
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.Location = new Point(46, 191);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(296, 23);
            comboBoxFilter.TabIndex = 3;
            // 
            // categoryRepoBindingSource1
            // 
            categoryRepoBindingSource1.DataSource = typeof(Repository.CategoryRepo);
            // 
            // listBoxResult
            // 
            listBoxResult.FormattingEnabled = true;
            listBoxResult.ItemHeight = 15;
            listBoxResult.Location = new Point(46, 220);
            listBoxResult.Name = "listBoxResult";
            listBoxResult.Size = new Size(296, 199);
            listBoxResult.TabIndex = 4;
            listBoxResult.SelectedIndexChanged += listBoxResult_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelPrice);
            groupBox1.Controls.Add(textBoxPrice);
            groupBox1.Controls.Add(textBoxDescription);
            groupBox1.Controls.Add(textBoxTitle);
            groupBox1.Controls.Add(buttonCreate);
            groupBox1.Controls.Add(buttonDelete);
            groupBox1.Controls.Add(buttonUpdate);
            groupBox1.Location = new Point(383, 147);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(285, 272);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Listing";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(117, 208);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(36, 15);
            labelPrice.TabIndex = 7;
            labelPrice.Text = "Price:";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(159, 205);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(100, 23);
            textBoxPrice.TabIndex = 6;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(25, 55);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(234, 144);
            textBoxDescription.TabIndex = 5;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(25, 26);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(234, 23);
            textBoxTitle.TabIndex = 4;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(204, 243);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(75, 23);
            buttonCreate.TabIndex = 3;
            buttonCreate.Text = "Create ad";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(105, 243);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // labelFilter
            // 
            labelFilter.AutoSize = true;
            labelFilter.Location = new Point(46, 173);
            labelFilter.Name = "labelFilter";
            labelFilter.Size = new Size(33, 15);
            labelFilter.TabIndex = 6;
            labelFilter.Text = "Filter";
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(593, 118);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(75, 23);
            buttonLogin.TabIndex = 7;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(512, 118);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(75, 23);
            buttonRegister.TabIndex = 8;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(59, 42);
            label1.Name = "label1";
            label1.Size = new Size(71, 32);
            label1.TabIndex = 9;
            label1.Text = "bBay";
            // 
            // categoryRepoBindingSource
            // 
            categoryRepoBindingSource.DataSource = typeof(Repository.CategoryRepo);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 466);
            Controls.Add(label1);
            Controls.Add(buttonRegister);
            Controls.Add(buttonLogin);
            Controls.Add(labelFilter);
            Controls.Add(groupBox1);
            Controls.Add(listBoxResult);
            Controls.Add(comboBoxFilter);
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
