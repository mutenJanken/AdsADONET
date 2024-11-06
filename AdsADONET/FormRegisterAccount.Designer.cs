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
            textBoxRegUsername = new TextBox();
            textBoxRegPassword = new TextBox();
            textBoxRegFullname = new TextBox();
            textBoxRegEmail = new TextBox();
            labelRegUsername = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            buttonCancel = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(54, 498);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(150, 46);
            buttonRegister.TabIndex = 0;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(buttonCancel);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(labelRegUsername);
            groupBox1.Controls.Add(textBoxRegEmail);
            groupBox1.Controls.Add(textBoxRegFullname);
            groupBox1.Controls.Add(textBoxRegPassword);
            groupBox1.Controls.Add(textBoxRegUsername);
            groupBox1.Controls.Add(buttonRegister);
            groupBox1.Location = new Point(61, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(536, 602);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "New account";
            // 
            // textBoxRegUsername
            // 
            textBoxRegUsername.Location = new Point(54, 150);
            textBoxRegUsername.Name = "textBoxRegUsername";
            textBoxRegUsername.Size = new Size(396, 39);
            textBoxRegUsername.TabIndex = 1;
            // 
            // textBoxRegPassword
            // 
            textBoxRegPassword.Location = new Point(54, 240);
            textBoxRegPassword.Name = "textBoxRegPassword";
            textBoxRegPassword.Size = new Size(396, 39);
            textBoxRegPassword.TabIndex = 2;
            // 
            // textBoxRegFullname
            // 
            textBoxRegFullname.Location = new Point(54, 333);
            textBoxRegFullname.Name = "textBoxRegFullname";
            textBoxRegFullname.Size = new Size(396, 39);
            textBoxRegFullname.TabIndex = 3;
            // 
            // textBoxRegEmail
            // 
            textBoxRegEmail.Location = new Point(54, 426);
            textBoxRegEmail.Name = "textBoxRegEmail";
            textBoxRegEmail.Size = new Size(396, 39);
            textBoxRegEmail.TabIndex = 4;
            // 
            // labelRegUsername
            // 
            labelRegUsername.AutoSize = true;
            labelRegUsername.Location = new Point(49, 115);
            labelRegUsername.Name = "labelRegUsername";
            labelRegUsername.Size = new Size(181, 32);
            labelRegUsername.TabIndex = 5;
            labelRegUsername.Text = "Enter username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 205);
            label2.Name = "label2";
            label2.Size = new Size(175, 32);
            label2.TabIndex = 6;
            label2.Text = "Enter password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 298);
            label3.Name = "label3";
            label3.Size = new Size(170, 32);
            label3.TabIndex = 7;
            label3.Text = "Enter fullname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 391);
            label4.Name = "label4";
            label4.Size = new Size(134, 32);
            label4.TabIndex = 8;
            label4.Text = "Enter email";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(300, 498);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(150, 46);
            buttonCancel.TabIndex = 9;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(114, 48);
            label1.Name = "label1";
            label1.Size = new Size(279, 50);
            label1.TabIndex = 10;
            label1.Text = "Create account";
            // 
            // FormRegisterAccount
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 699);
            Controls.Add(groupBox1);
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
        private Button buttonCancel;
        private Label label1;
    }
}