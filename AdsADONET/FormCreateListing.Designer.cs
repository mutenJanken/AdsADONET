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
            labelPrice = new Label();
            textBoxAddPrice = new TextBox();
            textBoxAddDescription = new TextBox();
            textBoxAddTitle = new TextBox();
            buttonCreate = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelPrice);
            groupBox1.Controls.Add(textBoxAddPrice);
            groupBox1.Controls.Add(textBoxAddDescription);
            groupBox1.Controls.Add(textBoxAddTitle);
            groupBox1.Controls.Add(buttonCreate);
            groupBox1.Location = new Point(70, 38);
            groupBox1.Margin = new Padding(6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6);
            groupBox1.Size = new Size(529, 590);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Create listing";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(213, 440);
            labelPrice.Margin = new Padding(6, 0, 6, 0);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(70, 32);
            labelPrice.TabIndex = 7;
            labelPrice.Text = "Price:";
            // 
            // textBoxAddPrice
            // 
            textBoxAddPrice.Location = new Point(295, 437);
            textBoxAddPrice.Margin = new Padding(6);
            textBoxAddPrice.Name = "textBoxAddPrice";
            textBoxAddPrice.PlaceholderText = "Add price...";
            textBoxAddPrice.Size = new Size(182, 39);
            textBoxAddPrice.TabIndex = 6;
            // 
            // textBoxAddDescription
            // 
            textBoxAddDescription.Location = new Point(46, 117);
            textBoxAddDescription.Margin = new Padding(6);
            textBoxAddDescription.Multiline = true;
            textBoxAddDescription.Name = "textBoxAddDescription";
            textBoxAddDescription.PlaceholderText = "Add description...";
            textBoxAddDescription.Size = new Size(431, 303);
            textBoxAddDescription.TabIndex = 5;
            // 
            // textBoxAddTitle
            // 
            textBoxAddTitle.Location = new Point(46, 55);
            textBoxAddTitle.Margin = new Padding(6);
            textBoxAddTitle.Name = "textBoxAddTitle";
            textBoxAddTitle.PlaceholderText = "Add title...";
            textBoxAddTitle.Size = new Size(431, 39);
            textBoxAddTitle.TabIndex = 4;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(338, 488);
            buttonCreate.Margin = new Padding(6);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(139, 49);
            buttonCreate.TabIndex = 3;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // FormCreateListing
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 664);
            Controls.Add(groupBox1);
            Name = "FormCreateListing";
            Text = "FormCreateListing";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label labelPrice;
        private TextBox textBoxAddPrice;
        private TextBox textBoxAddDescription;
        private TextBox textBoxAddTitle;
        private Button buttonCreate;
    }
}