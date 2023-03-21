namespace BaseApplication
{
    partial class Form1
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
            this.navigation = new System.Windows.Forms.TabControl();
            this.mainPage = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.keyword = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.showBalance = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.showTransac = new System.Windows.Forms.Button();
            this.registerPage = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.registerFeedbackBox = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.userTypeBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.loginPage = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.loginFeedbackBox = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.loginPasswordBox = new System.Windows.Forms.TextBox();
            this.loginUsernameBox = new System.Windows.Forms.TextBox();
            this.editTransaction = new System.Windows.Forms.TabPage();
            this.showTransaction = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.navigation.SuspendLayout();
            this.mainPage.SuspendLayout();
            this.registerPage.SuspendLayout();
            this.loginPage.SuspendLayout();
            this.editTransaction.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigation
            // 
            this.navigation.Controls.Add(this.mainPage);
            this.navigation.Controls.Add(this.registerPage);
            this.navigation.Controls.Add(this.loginPage);
            this.navigation.Controls.Add(this.editTransaction);
            this.navigation.Location = new System.Drawing.Point(1, 0);
            this.navigation.Name = "navigation";
            this.navigation.SelectedIndex = 0;
            this.navigation.Size = new System.Drawing.Size(801, 447);
            this.navigation.TabIndex = 0;
            // 
            // mainPage
            // 
            this.mainPage.Controls.Add(this.button1);
            this.mainPage.Controls.Add(this.comboBox1);
            this.mainPage.Controls.Add(this.keyword);
            this.mainPage.Controls.Add(this.searchBtn);
            this.mainPage.Controls.Add(this.showBalance);
            this.mainPage.Controls.Add(this.richTextBox1);
            this.mainPage.Controls.Add(this.showTransac);
            this.mainPage.Location = new System.Drawing.Point(4, 25);
            this.mainPage.Name = "mainPage";
            this.mainPage.Padding = new System.Windows.Forms.Padding(3);
            this.mainPage.Size = new System.Drawing.Size(793, 418);
            this.mainPage.TabIndex = 0;
            this.mainPage.Text = "Base";
            this.mainPage.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 43);
            this.button1.TabIndex = 14;
            this.button1.Text = "Add File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "available_balance",
            "final_opening_balance",
            "transactions",
            "transaction_reference"});
            this.comboBox1.Location = new System.Drawing.Point(202, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 24);
            this.comboBox1.TabIndex = 13;
            // 
            // keyword
            // 
            this.keyword.AutoSize = true;
            this.keyword.Location = new System.Drawing.Point(251, 52);
            this.keyword.Name = "keyword";
            this.keyword.Size = new System.Drawing.Size(62, 16);
            this.keyword.TabIndex = 12;
            this.keyword.Text = "Keyword:";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(238, 145);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 11;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // showBalance
            // 
            this.showBalance.Location = new System.Drawing.Point(13, 145);
            this.showBalance.Name = "showBalance";
            this.showBalance.Size = new System.Drawing.Size(147, 32);
            this.showBalance.TabIndex = 10;
            this.showBalance.Text = "Show Balance";
            this.showBalance.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(393, 14);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(387, 390);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // showTransac
            // 
            this.showTransac.Location = new System.Drawing.Point(13, 66);
            this.showTransac.Name = "showTransac";
            this.showTransac.Size = new System.Drawing.Size(147, 32);
            this.showTransac.TabIndex = 8;
            this.showTransac.Text = "Show Transactions";
            this.showTransac.UseVisualStyleBackColor = true;
            // 
            // registerPage
            // 
            this.registerPage.Controls.Add(this.label6);
            this.registerPage.Controls.Add(this.label5);
            this.registerPage.Controls.Add(this.label4);
            this.registerPage.Controls.Add(this.label3);
            this.registerPage.Controls.Add(this.label2);
            this.registerPage.Controls.Add(this.label1);
            this.registerPage.Controls.Add(this.registerFeedbackBox);
            this.registerPage.Controls.Add(this.button2);
            this.registerPage.Controls.Add(this.userTypeBox);
            this.registerPage.Controls.Add(this.passwordBox);
            this.registerPage.Controls.Add(this.emailBox);
            this.registerPage.Controls.Add(this.lastNameBox);
            this.registerPage.Controls.Add(this.firstNameBox);
            this.registerPage.Controls.Add(this.usernameBox);
            this.registerPage.Location = new System.Drawing.Point(4, 25);
            this.registerPage.Name = "registerPage";
            this.registerPage.Padding = new System.Windows.Forms.Padding(3);
            this.registerPage.Size = new System.Drawing.Size(793, 418);
            this.registerPage.TabIndex = 1;
            this.registerPage.Text = "Register";
            this.registerPage.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "User type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Email address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Last name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "First name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username";
            // 
            // registerFeedbackBox
            // 
            this.registerFeedbackBox.Location = new System.Drawing.Point(563, 19);
            this.registerFeedbackBox.Name = "registerFeedbackBox";
            this.registerFeedbackBox.Size = new System.Drawing.Size(179, 226);
            this.registerFeedbackBox.TabIndex = 7;
            this.registerFeedbackBox.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 329);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 65);
            this.button2.TabIndex = 6;
            this.button2.Text = "REGISTER";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // userTypeBox
            // 
            this.userTypeBox.Location = new System.Drawing.Point(7, 223);
            this.userTypeBox.Name = "userTypeBox";
            this.userTypeBox.Size = new System.Drawing.Size(100, 22);
            this.userTypeBox.TabIndex = 5;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(7, 182);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(100, 22);
            this.passwordBox.TabIndex = 4;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(7, 142);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(100, 22);
            this.emailBox.TabIndex = 3;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(7, 100);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(100, 22);
            this.lastNameBox.TabIndex = 2;
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(7, 59);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(100, 22);
            this.firstNameBox.TabIndex = 1;
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(7, 19);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(100, 22);
            this.usernameBox.TabIndex = 0;
            // 
            // loginPage
            // 
            this.loginPage.Controls.Add(this.label8);
            this.loginPage.Controls.Add(this.label7);
            this.loginPage.Controls.Add(this.loginFeedbackBox);
            this.loginPage.Controls.Add(this.button3);
            this.loginPage.Controls.Add(this.loginPasswordBox);
            this.loginPage.Controls.Add(this.loginUsernameBox);
            this.loginPage.Location = new System.Drawing.Point(4, 25);
            this.loginPage.Name = "loginPage";
            this.loginPage.Size = new System.Drawing.Size(793, 418);
            this.loginPage.TabIndex = 2;
            this.loginPage.Text = "Login";
            this.loginPage.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(132, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(132, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Username";
            // 
            // loginFeedbackBox
            // 
            this.loginFeedbackBox.Location = new System.Drawing.Point(602, 25);
            this.loginFeedbackBox.Name = "loginFeedbackBox";
            this.loginFeedbackBox.Size = new System.Drawing.Size(156, 169);
            this.loginFeedbackBox.TabIndex = 3;
            this.loginFeedbackBox.Text = "";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(17, 311);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 76);
            this.button3.TabIndex = 2;
            this.button3.Text = "LOGIN";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // loginPasswordBox
            // 
            this.loginPasswordBox.Location = new System.Drawing.Point(17, 73);
            this.loginPasswordBox.Name = "loginPasswordBox";
            this.loginPasswordBox.PasswordChar = '*';
            this.loginPasswordBox.Size = new System.Drawing.Size(100, 22);
            this.loginPasswordBox.TabIndex = 1;
            // 
            // loginUsernameBox
            // 
            this.loginUsernameBox.Location = new System.Drawing.Point(17, 25);
            this.loginUsernameBox.Name = "loginUsernameBox";
            this.loginUsernameBox.Size = new System.Drawing.Size(100, 22);
            this.loginUsernameBox.TabIndex = 0;
            // 
            // editTransaction
            // 
            this.editTransaction.Controls.Add(this.submitBtn);
            this.editTransaction.Controls.Add(this.showTransaction);
            this.editTransaction.Controls.Add(this.richTextBox2);
            this.editTransaction.Location = new System.Drawing.Point(4, 25);
            this.editTransaction.Name = "editTransaction";
            this.editTransaction.Size = new System.Drawing.Size(793, 418);
            this.editTransaction.TabIndex = 3;
            this.editTransaction.Text = "Edit Transaction";
            this.editTransaction.UseVisualStyleBackColor = true;
            // 
            // showTransaction
            // 
            this.showTransaction.Location = new System.Drawing.Point(555, 347);
            this.showTransaction.Name = "showTransaction";
            this.showTransaction.Size = new System.Drawing.Size(114, 40);
            this.showTransaction.TabIndex = 1;
            this.showTransaction.Text = "Transactions";
            this.showTransaction.UseVisualStyleBackColor = true;
            this.showTransaction.Click += new System.EventHandler(this.showTransaction_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(514, 20);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(209, 321);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(158, 353);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(87, 34);
            this.submitBtn.TabIndex = 2;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.navigation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.navigation.ResumeLayout(false);
            this.mainPage.ResumeLayout(false);
            this.mainPage.PerformLayout();
            this.registerPage.ResumeLayout(false);
            this.registerPage.PerformLayout();
            this.loginPage.ResumeLayout(false);
            this.loginPage.PerformLayout();
            this.editTransaction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl navigation;
        private System.Windows.Forms.TabPage mainPage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label keyword;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button showBalance;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button showTransac;
        private System.Windows.Forms.TabPage registerPage;
        private System.Windows.Forms.TabPage loginPage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox registerFeedbackBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox userTypeBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox loginFeedbackBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox loginPasswordBox;
        private System.Windows.Forms.TextBox loginUsernameBox;
        private System.Windows.Forms.TabPage editTransaction;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button showTransaction;
        private System.Windows.Forms.Button submitBtn;
    }
}

