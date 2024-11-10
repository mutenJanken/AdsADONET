namespace AdsADONET
{
    partial class FormCreateListing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label1 = new Label();
            comboBoxFilter = new ComboBox();
            labelPrice = new Label();
            textBoxAddPrice = new TextBox();
            textBoxAddDescription = new TextBox();
            textBoxAddTitle = new TextBox();
            buttonCreate = new Button();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBoxFilter);
            groupBox1.Controls.Add(labelPrice);
            groupBox1.Controls.Add(textBoxAddPrice);
            groupBox1.Controls.Add(textBoxAddDescription);
            groupBox1.Controls.Add(textBoxAddTitle);
            groupBox1.Controls.Add(buttonCreate);
            groupBox1.Location = new Point(35, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(285, 311);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Create listing";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 48);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 9;
            label1.Text = "Category";
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.Location = new Point(25, 65);
            comboBoxFilter.Margin = new Padding(2, 1, 2, 1);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(234, 23);
            comboBoxFilter.TabIndex = 8;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(115, 244);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(36, 15);
            labelPrice.TabIndex = 7;
            labelPrice.Text = "Price:";
            // 
            // textBoxAddPrice
            // 
            textBoxAddPrice.Location = new Point(159, 243);
            textBoxAddPrice.Name = "textBoxAddPrice";
            textBoxAddPrice.PlaceholderText = "Add price...";
            textBoxAddPrice.Size = new Size(100, 23);
            textBoxAddPrice.TabIndex = 6;
            // 
            // textBoxAddDescription
            // 
            textBoxAddDescription.Location = new Point(25, 93);
            textBoxAddDescription.Multiline = true;
            textBoxAddDescription.Name = "textBoxAddDescription";
            textBoxAddDescription.PlaceholderText = "Add description...";
            textBoxAddDescription.Size = new Size(234, 144);
            textBoxAddDescription.TabIndex = 5;
            // 
            // textBoxAddTitle
            // 
            textBoxAddTitle.Location = new Point(25, 26);
            textBoxAddTitle.Name = "textBoxAddTitle";
            textBoxAddTitle.PlaceholderText = "Add title...";
            textBoxAddTitle.Size = new Size(234, 23);
            textBoxAddTitle.TabIndex = 4;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(182, 267);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(75, 23);
            buttonCreate.TabIndex = 3;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(96, 31);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(171, 25);
            label2.TabIndex = 11;
            label2.Text = "Create new listing";
            // 
            // FormCreateListing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 398);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "FormCreateListing";
            Text = "FormCreateListing";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label labelPrice;
        private TextBox textBoxAddPrice;
        private TextBox textBoxAddDescription;
        private TextBox textBoxAddTitle;
        private Button buttonCreate;
        private ComboBox comboBoxFilter;
        private Label label1;
        private Label label2;
    }
}