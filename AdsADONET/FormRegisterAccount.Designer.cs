namespace AdsADONET
{
    partial class FormRegisterAccount
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
            buttonRegister = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            labelRegUsername = new Label();
            textBoxRegEmail = new TextBox();
            textBoxRegFullname = new TextBox();
            textBoxRegPassword = new TextBox();
            textBoxRegUsername = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(163, 234);
            buttonRegister.Margin = new Padding(2, 1, 2, 1);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(81, 22);
            buttonRegister.TabIndex = 0;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(labelRegUsername);
            groupBox1.Controls.Add(textBoxRegEmail);
            groupBox1.Controls.Add(textBoxRegFullname);
            groupBox1.Controls.Add(textBoxRegPassword);
            groupBox1.Controls.Add(textBoxRegUsername);
            groupBox1.Controls.Add(buttonRegister);
            groupBox1.Location = new Point(33, 22);
            groupBox1.Margin = new Padding(2, 1, 2, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 1, 2, 1);
            groupBox1.Size = new Size(289, 282);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "New account";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(61, 22);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(144, 25);
            label1.TabIndex = 10;
            label1.Text = "Create account";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 183);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 8;
            label4.Text = "Enter email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 140);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 7;
            label3.Text = "Enter fullname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 96);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 6;
            label2.Text = "Enter password";
            // 
            // labelRegUsername
            // 
            labelRegUsername.AutoSize = true;
            labelRegUsername.Location = new Point(26, 54);
            labelRegUsername.Margin = new Padding(2, 0, 2, 0);
            labelRegUsername.Name = "labelRegUsername";
            labelRegUsername.Size = new Size(89, 15);
            labelRegUsername.TabIndex = 5;
            labelRegUsername.Text = "Enter username";
            // 
            // textBoxRegEmail
            // 
            textBoxRegEmail.Location = new Point(29, 200);
            textBoxRegEmail.Margin = new Padding(2, 1, 2, 1);
            textBoxRegEmail.Name = "textBoxRegEmail";
            textBoxRegEmail.Size = new Size(215, 23);
            textBoxRegEmail.TabIndex = 4;
            // 
            // textBoxRegFullname
            // 
            textBoxRegFullname.Location = new Point(29, 156);
            textBoxRegFullname.Margin = new Padding(2, 1, 2, 1);
            textBoxRegFullname.Name = "textBoxRegFullname";
            textBoxRegFullname.Size = new Size(215, 23);
            textBoxRegFullname.TabIndex = 3;
            // 
            // textBoxRegPassword
            // 
            textBoxRegPassword.Location = new Point(29, 112);
            textBoxRegPassword.Margin = new Padding(2, 1, 2, 1);
            textBoxRegPassword.Name = "textBoxRegPassword";
            textBoxRegPassword.Size = new Size(215, 23);
            textBoxRegPassword.TabIndex = 2;
            // 
            // textBoxRegUsername
            // 
            textBoxRegUsername.Location = new Point(29, 70);
            textBoxRegUsername.Margin = new Padding(2, 1, 2, 1);
            textBoxRegUsername.Name = "textBoxRegUsername";
            textBoxRegUsername.Size = new Size(215, 23);
            textBoxRegUsername.TabIndex = 1;
            // 
            // FormRegisterAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 328);
            Controls.Add(groupBox1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "FormRegisterAccount";
            Text = "FormRegisterAccount";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonRegister;
        private GroupBox groupBox1;
        private TextBox textBoxRegEmail;
        private TextBox textBoxRegFullname;
        private TextBox textBoxRegPassword;
        private TextBox textBoxRegUsername;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label labelRegUsername;
        private Label label1;
    }
}