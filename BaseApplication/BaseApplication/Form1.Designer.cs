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
            this.modulesInfoBtn = new System.Windows.Forms.Button();
            this.goToEditDescBtn = new System.Windows.Forms.Button();
            this.addFileBtn = new System.Windows.Forms.Button();
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
            this.categoryLbl = new System.Windows.Forms.Label();
            this.bankRefLbl = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.modules = new System.Windows.Forms.TabPage();
            this.generateSummaryBtn = new System.Windows.Forms.Button();
            this.turnoverLbl = new System.Windows.Forms.Label();
            this.incomeLbl = new System.Windows.Forms.Label();
            this.costsLbl = new System.Windows.Forms.Label();
            this.updateRental = new System.Windows.Forms.Button();
            this.updateBatBtn = new System.Windows.Forms.Button();
            this.rentalinfoLbl = new System.Windows.Forms.Label();
            this.rentalTurnoverTxt = new System.Windows.Forms.TextBox();
            this.rentalIncomeTxt = new System.Windows.Forms.TextBox();
            this.rentalCostTxt = new System.Windows.Forms.TextBox();
            this.barTurnoverTxt = new System.Windows.Forms.TextBox();
            this.barIncomeTxt = new System.Windows.Forms.TextBox();
            this.barCostTxt = new System.Windows.Forms.TextBox();
            this.barinfoLbl = new System.Windows.Forms.Label();
            this.editDescription = new System.Windows.Forms.TabPage();
            this.updateDescBtn = new System.Windows.Forms.Button();
            this.descLbl = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.bankRefEditLbl = new System.Windows.Forms.Label();
            this.bRefCBox = new System.Windows.Forms.ComboBox();
            this.searchKeyword = new System.Windows.Forms.TabPage();
            this.searchTableCBox = new System.Windows.Forms.ComboBox();
            this.searchColumnCBox = new System.Windows.Forms.ComboBox();
            this.keywordSeach = new System.Windows.Forms.TextBox();
            this.seachTableLbl = new System.Windows.Forms.Label();
            this.searchColumnLbl = new System.Windows.Forms.Label();
            this.searchKeywordLbl = new System.Windows.Forms.Label();
            this.searchKeywordBtn = new System.Windows.Forms.Button();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.searchKWordBtn = new System.Windows.Forms.Button();
            this.navigation.SuspendLayout();
            this.mainPage.SuspendLayout();
            this.registerPage.SuspendLayout();
            this.loginPage.SuspendLayout();
            this.editTransaction.SuspendLayout();
            this.modules.SuspendLayout();
            this.editDescription.SuspendLayout();
            this.searchKeyword.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigation
            // 
            this.navigation.Controls.Add(this.mainPage);
            this.navigation.Controls.Add(this.registerPage);
            this.navigation.Controls.Add(this.loginPage);
            this.navigation.Controls.Add(this.editTransaction);
            this.navigation.Controls.Add(this.modules);
            this.navigation.Controls.Add(this.editDescription);
            this.navigation.Controls.Add(this.searchKeyword);
            this.navigation.Location = new System.Drawing.Point(1, 0);
            this.navigation.Name = "navigation";
            this.navigation.SelectedIndex = 0;
            this.navigation.Size = new System.Drawing.Size(801, 447);
            this.navigation.TabIndex = 0;
            // 
            // mainPage
            // 
            this.mainPage.Controls.Add(this.searchKWordBtn);
            this.mainPage.Controls.Add(this.modulesInfoBtn);
            this.mainPage.Controls.Add(this.goToEditDescBtn);
            this.mainPage.Controls.Add(this.addFileBtn);
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
            // modulesInfoBtn
            // 
            this.modulesInfoBtn.Location = new System.Drawing.Point(13, 280);
            this.modulesInfoBtn.Name = "modulesInfoBtn";
            this.modulesInfoBtn.Size = new System.Drawing.Size(156, 32);
            this.modulesInfoBtn.TabIndex = 16;
            this.modulesInfoBtn.Text = "Modules Info";
            this.modulesInfoBtn.UseVisualStyleBackColor = true;
            this.modulesInfoBtn.Click += new System.EventHandler(this.modulesInfoBtn_Click);
            // 
            // goToEditDescBtn
            // 
            this.goToEditDescBtn.Location = new System.Drawing.Point(201, 280);
            this.goToEditDescBtn.Name = "goToEditDescBtn";
            this.goToEditDescBtn.Size = new System.Drawing.Size(156, 32);
            this.goToEditDescBtn.TabIndex = 15;
            this.goToEditDescBtn.Text = "Edit/Add Description";
            this.goToEditDescBtn.UseVisualStyleBackColor = true;
            this.goToEditDescBtn.Click += new System.EventHandler(this.goToEditDescBtn_Click);
            // 
            // addFileBtn
            // 
            this.addFileBtn.Location = new System.Drawing.Point(13, 345);
            this.addFileBtn.Name = "addFileBtn";
            this.addFileBtn.Size = new System.Drawing.Size(156, 32);
            this.addFileBtn.TabIndex = 14;
            this.addFileBtn.Text = "Add file";
            this.addFileBtn.UseVisualStyleBackColor = true;
            this.addFileBtn.Click += new System.EventHandler(this.addFileBtn_Click);
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
            this.searchBtn.Location = new System.Drawing.Point(238, 149);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 11;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // showBalance
            // 
            this.showBalance.Location = new System.Drawing.Point(13, 140);
            this.showBalance.Name = "showBalance";
            this.showBalance.Size = new System.Drawing.Size(156, 32);
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
            this.showTransac.Size = new System.Drawing.Size(156, 32);
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
            this.editTransaction.Controls.Add(this.categoryLbl);
            this.editTransaction.Controls.Add(this.bankRefLbl);
            this.editTransaction.Controls.Add(this.submitBtn);
            this.editTransaction.Location = new System.Drawing.Point(4, 25);
            this.editTransaction.Name = "editTransaction";
            this.editTransaction.Size = new System.Drawing.Size(793, 418);
            this.editTransaction.TabIndex = 3;
            this.editTransaction.Text = "Edit Transaction";
            this.editTransaction.UseVisualStyleBackColor = true;
            // 
            // categoryLbl
            // 
            this.categoryLbl.AutoSize = true;
            this.categoryLbl.Location = new System.Drawing.Point(276, 23);
            this.categoryLbl.Name = "categoryLbl";
            this.categoryLbl.Size = new System.Drawing.Size(62, 16);
            this.categoryLbl.TabIndex = 4;
            this.categoryLbl.Text = "Category";
            // 
            // bankRefLbl
            // 
            this.bankRefLbl.AutoSize = true;
            this.bankRefLbl.Location = new System.Drawing.Point(42, 23);
            this.bankRefLbl.Name = "bankRefLbl";
            this.bankRefLbl.Size = new System.Drawing.Size(104, 16);
            this.bankRefLbl.TabIndex = 3;
            this.bankRefLbl.Text = "Bank Reference";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(158, 331);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(87, 34);
            this.submitBtn.TabIndex = 2;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // modules
            // 
            this.modules.Controls.Add(this.generateSummaryBtn);
            this.modules.Controls.Add(this.turnoverLbl);
            this.modules.Controls.Add(this.incomeLbl);
            this.modules.Controls.Add(this.costsLbl);
            this.modules.Controls.Add(this.updateRental);
            this.modules.Controls.Add(this.updateBatBtn);
            this.modules.Controls.Add(this.rentalinfoLbl);
            this.modules.Controls.Add(this.rentalTurnoverTxt);
            this.modules.Controls.Add(this.rentalIncomeTxt);
            this.modules.Controls.Add(this.rentalCostTxt);
            this.modules.Controls.Add(this.barTurnoverTxt);
            this.modules.Controls.Add(this.barIncomeTxt);
            this.modules.Controls.Add(this.barCostTxt);
            this.modules.Controls.Add(this.barinfoLbl);
            this.modules.Location = new System.Drawing.Point(4, 25);
            this.modules.Name = "modules";
            this.modules.Padding = new System.Windows.Forms.Padding(3);
            this.modules.Size = new System.Drawing.Size(793, 418);
            this.modules.TabIndex = 4;
            this.modules.Text = "Modules";
            this.modules.UseVisualStyleBackColor = true;
            // 
            // generateSummaryBtn
            // 
            this.generateSummaryBtn.Location = new System.Drawing.Point(312, 293);
            this.generateSummaryBtn.Name = "generateSummaryBtn";
            this.generateSummaryBtn.Size = new System.Drawing.Size(121, 52);
            this.generateSummaryBtn.TabIndex = 14;
            this.generateSummaryBtn.Text = "Generate Summary";
            this.generateSummaryBtn.UseVisualStyleBackColor = true;
            this.generateSummaryBtn.Click += new System.EventHandler(this.generateSummaryBtn_Click);
            // 
            // turnoverLbl
            // 
            this.turnoverLbl.AutoSize = true;
            this.turnoverLbl.Location = new System.Drawing.Point(465, 75);
            this.turnoverLbl.Name = "turnoverLbl";
            this.turnoverLbl.Size = new System.Drawing.Size(64, 16);
            this.turnoverLbl.TabIndex = 12;
            this.turnoverLbl.Text = "Turnover:";
            // 
            // incomeLbl
            // 
            this.incomeLbl.AutoSize = true;
            this.incomeLbl.Location = new System.Drawing.Point(347, 75);
            this.incomeLbl.Name = "incomeLbl";
            this.incomeLbl.Size = new System.Drawing.Size(54, 16);
            this.incomeLbl.TabIndex = 11;
            this.incomeLbl.Text = "Income:";
            // 
            // costsLbl
            // 
            this.costsLbl.AutoSize = true;
            this.costsLbl.Location = new System.Drawing.Point(229, 75);
            this.costsLbl.Name = "costsLbl";
            this.costsLbl.Size = new System.Drawing.Size(44, 16);
            this.costsLbl.TabIndex = 10;
            this.costsLbl.Text = "Costs:";
            // 
            // updateRental
            // 
            this.updateRental.Location = new System.Drawing.Point(588, 166);
            this.updateRental.Name = "updateRental";
            this.updateRental.Size = new System.Drawing.Size(116, 27);
            this.updateRental.TabIndex = 9;
            this.updateRental.Text = "Update Rental";
            this.updateRental.UseVisualStyleBackColor = true;
            this.updateRental.Click += new System.EventHandler(this.updateRental_Click);
            // 
            // updateBatBtn
            // 
            this.updateBatBtn.Location = new System.Drawing.Point(588, 110);
            this.updateBatBtn.Name = "updateBatBtn";
            this.updateBatBtn.Size = new System.Drawing.Size(116, 27);
            this.updateBatBtn.TabIndex = 8;
            this.updateBatBtn.Text = "Update Bar";
            this.updateBatBtn.UseVisualStyleBackColor = true;
            this.updateBatBtn.Click += new System.EventHandler(this.updateBatBtn_Click);
            // 
            // rentalinfoLbl
            // 
            this.rentalinfoLbl.AutoSize = true;
            this.rentalinfoLbl.Location = new System.Drawing.Point(66, 177);
            this.rentalinfoLbl.Name = "rentalinfoLbl";
            this.rentalinfoLbl.Size = new System.Drawing.Size(117, 16);
            this.rentalinfoLbl.TabIndex = 7;
            this.rentalinfoLbl.Text = "Rental Information:";
            // 
            // rentalTurnoverTxt
            // 
            this.rentalTurnoverTxt.Location = new System.Drawing.Point(445, 170);
            this.rentalTurnoverTxt.Name = "rentalTurnoverTxt";
            this.rentalTurnoverTxt.Size = new System.Drawing.Size(100, 22);
            this.rentalTurnoverTxt.TabIndex = 6;
            // 
            // rentalIncomeTxt
            // 
            this.rentalIncomeTxt.Location = new System.Drawing.Point(322, 170);
            this.rentalIncomeTxt.Name = "rentalIncomeTxt";
            this.rentalIncomeTxt.Size = new System.Drawing.Size(100, 22);
            this.rentalIncomeTxt.TabIndex = 5;
            // 
            // rentalCostTxt
            // 
            this.rentalCostTxt.Location = new System.Drawing.Point(201, 171);
            this.rentalCostTxt.Name = "rentalCostTxt";
            this.rentalCostTxt.Size = new System.Drawing.Size(100, 22);
            this.rentalCostTxt.TabIndex = 4;
            // 
            // barTurnoverTxt
            // 
            this.barTurnoverTxt.Location = new System.Drawing.Point(445, 112);
            this.barTurnoverTxt.Name = "barTurnoverTxt";
            this.barTurnoverTxt.Size = new System.Drawing.Size(100, 22);
            this.barTurnoverTxt.TabIndex = 3;
            // 
            // barIncomeTxt
            // 
            this.barIncomeTxt.Location = new System.Drawing.Point(322, 112);
            this.barIncomeTxt.Name = "barIncomeTxt";
            this.barIncomeTxt.Size = new System.Drawing.Size(100, 22);
            this.barIncomeTxt.TabIndex = 2;
            // 
            // barCostTxt
            // 
            this.barCostTxt.Location = new System.Drawing.Point(201, 112);
            this.barCostTxt.Name = "barCostTxt";
            this.barCostTxt.Size = new System.Drawing.Size(100, 22);
            this.barCostTxt.TabIndex = 1;
            // 
            // barinfoLbl
            // 
            this.barinfoLbl.AutoSize = true;
            this.barinfoLbl.Location = new System.Drawing.Point(67, 115);
            this.barinfoLbl.Name = "barinfoLbl";
            this.barinfoLbl.Size = new System.Drawing.Size(99, 16);
            this.barinfoLbl.TabIndex = 0;
            this.barinfoLbl.Text = "Bar Information:";
            // 
            // editDescription
            // 
            this.editDescription.Controls.Add(this.updateDescBtn);
            this.editDescription.Controls.Add(this.descLbl);
            this.editDescription.Controls.Add(this.richTextBox2);
            this.editDescription.Controls.Add(this.bankRefEditLbl);
            this.editDescription.Controls.Add(this.bRefCBox);
            this.editDescription.Location = new System.Drawing.Point(4, 25);
            this.editDescription.Name = "editDescription";
            this.editDescription.Padding = new System.Windows.Forms.Padding(3);
            this.editDescription.Size = new System.Drawing.Size(793, 418);
            this.editDescription.TabIndex = 5;
            this.editDescription.Text = "Edit Description";
            this.editDescription.UseVisualStyleBackColor = true;
            // 
            // updateDescBtn
            // 
            this.updateDescBtn.Location = new System.Drawing.Point(311, 279);
            this.updateDescBtn.Name = "updateDescBtn";
            this.updateDescBtn.Size = new System.Drawing.Size(102, 47);
            this.updateDescBtn.TabIndex = 7;
            this.updateDescBtn.Text = "Update Description";
            this.updateDescBtn.UseVisualStyleBackColor = true;
            this.updateDescBtn.Click += new System.EventHandler(this.updateDescBtn_Click);
            // 
            // descLbl
            // 
            this.descLbl.AutoSize = true;
            this.descLbl.Location = new System.Drawing.Point(291, 25);
            this.descLbl.Name = "descLbl";
            this.descLbl.Size = new System.Drawing.Size(149, 16);
            this.descLbl.TabIndex = 6;
            this.descLbl.Text = "Transaction Description";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(277, 44);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(174, 214);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "";
            // 
            // bankRefEditLbl
            // 
            this.bankRefEditLbl.AutoSize = true;
            this.bankRefEditLbl.Location = new System.Drawing.Point(96, 25);
            this.bankRefEditLbl.Name = "bankRefEditLbl";
            this.bankRefEditLbl.Size = new System.Drawing.Size(104, 16);
            this.bankRefEditLbl.TabIndex = 4;
            this.bankRefEditLbl.Text = "Bank Reference";
            // 
            // bRefCBox
            // 
            this.bRefCBox.FormattingEnabled = true;
            this.bRefCBox.Location = new System.Drawing.Point(70, 44);
            this.bRefCBox.Name = "bRefCBox";
            this.bRefCBox.Size = new System.Drawing.Size(166, 24);
            this.bRefCBox.TabIndex = 0;
            this.bRefCBox.SelectionChangeCommitted += new System.EventHandler(this.bRefCBox_SelectionChangeCommitted);
            // 
            // searchKeyword
            // 
            this.searchKeyword.Controls.Add(this.richTextBox3);
            this.searchKeyword.Controls.Add(this.searchKeywordBtn);
            this.searchKeyword.Controls.Add(this.searchKeywordLbl);
            this.searchKeyword.Controls.Add(this.searchColumnLbl);
            this.searchKeyword.Controls.Add(this.seachTableLbl);
            this.searchKeyword.Controls.Add(this.keywordSeach);
            this.searchKeyword.Controls.Add(this.searchColumnCBox);
            this.searchKeyword.Controls.Add(this.searchTableCBox);
            this.searchKeyword.Location = new System.Drawing.Point(4, 25);
            this.searchKeyword.Name = "searchKeyword";
            this.searchKeyword.Padding = new System.Windows.Forms.Padding(3);
            this.searchKeyword.Size = new System.Drawing.Size(793, 418);
            this.searchKeyword.TabIndex = 6;
            this.searchKeyword.Text = "Search Keyword";
            this.searchKeyword.UseVisualStyleBackColor = true;
            // 
            // searchTableCBox
            // 
            this.searchTableCBox.FormattingEnabled = true;
            this.searchTableCBox.Location = new System.Drawing.Point(72, 105);
            this.searchTableCBox.Name = "searchTableCBox";
            this.searchTableCBox.Size = new System.Drawing.Size(135, 24);
            this.searchTableCBox.TabIndex = 0;
            this.searchTableCBox.SelectionChangeCommitted += new System.EventHandler(this.searchTableCBox_SelectionChangeCommitted);
            // 
            // searchColumnCBox
            // 
            this.searchColumnCBox.FormattingEnabled = true;
            this.searchColumnCBox.Location = new System.Drawing.Point(243, 105);
            this.searchColumnCBox.Name = "searchColumnCBox";
            this.searchColumnCBox.Size = new System.Drawing.Size(183, 24);
            this.searchColumnCBox.TabIndex = 1;
            // 
            // keywordSeach
            // 
            this.keywordSeach.Location = new System.Drawing.Point(474, 105);
            this.keywordSeach.Name = "keywordSeach";
            this.keywordSeach.Size = new System.Drawing.Size(135, 22);
            this.keywordSeach.TabIndex = 2;
            // 
            // seachTableLbl
            // 
            this.seachTableLbl.AutoSize = true;
            this.seachTableLbl.Location = new System.Drawing.Point(88, 86);
            this.seachTableLbl.Name = "seachTableLbl";
            this.seachTableLbl.Size = new System.Drawing.Size(101, 16);
            this.seachTableLbl.TabIndex = 3;
            this.seachTableLbl.Text = "Table to search";
            // 
            // searchColumnLbl
            // 
            this.searchColumnLbl.AutoSize = true;
            this.searchColumnLbl.Location = new System.Drawing.Point(277, 84);
            this.searchColumnLbl.Name = "searchColumnLbl";
            this.searchColumnLbl.Size = new System.Drawing.Size(110, 16);
            this.searchColumnLbl.TabIndex = 4;
            this.searchColumnLbl.Text = "Column to search";
            // 
            // searchKeywordLbl
            // 
            this.searchKeywordLbl.AutoSize = true;
            this.searchKeywordLbl.Location = new System.Drawing.Point(474, 84);
            this.searchKeywordLbl.Name = "searchKeywordLbl";
            this.searchKeywordLbl.Size = new System.Drawing.Size(135, 16);
            this.searchKeywordLbl.TabIndex = 5;
            this.searchKeywordLbl.Text = "Keyword to search for";
            // 
            // searchKeywordBtn
            // 
            this.searchKeywordBtn.Location = new System.Drawing.Point(661, 103);
            this.searchKeywordBtn.Name = "searchKeywordBtn";
            this.searchKeywordBtn.Size = new System.Drawing.Size(75, 23);
            this.searchKeywordBtn.TabIndex = 6;
            this.searchKeywordBtn.Text = "Search";
            this.searchKeywordBtn.UseVisualStyleBackColor = true;
            this.searchKeywordBtn.Click += new System.EventHandler(this.searchKeywordBtn_Click);
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(105, 269);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(613, 96);
            this.richTextBox3.TabIndex = 7;
            this.richTextBox3.Text = "";
            // 
            // searchKWordBtn
            // 
            this.searchKWordBtn.Location = new System.Drawing.Point(201, 345);
            this.searchKWordBtn.Name = "searchKWordBtn";
            this.searchKWordBtn.Size = new System.Drawing.Size(156, 32);
            this.searchKWordBtn.TabIndex = 17;
            this.searchKWordBtn.Text = "Search keyword";
            this.searchKWordBtn.UseVisualStyleBackColor = true;
            this.searchKWordBtn.Click += new System.EventHandler(this.searchKWordBtn_Click);
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
            this.editTransaction.PerformLayout();
            this.modules.ResumeLayout(false);
            this.modules.PerformLayout();
            this.editDescription.ResumeLayout(false);
            this.editDescription.PerformLayout();
            this.searchKeyword.ResumeLayout(false);
            this.searchKeyword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl navigation;
        private System.Windows.Forms.TabPage mainPage;
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
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label categoryLbl;
        private System.Windows.Forms.Label bankRefLbl;
        private System.Windows.Forms.Button addFileBtn;
        private System.Windows.Forms.TabPage modules;
        private System.Windows.Forms.Label turnoverLbl;
        private System.Windows.Forms.Label incomeLbl;
        private System.Windows.Forms.Label costsLbl;
        private System.Windows.Forms.Button updateRental;
        private System.Windows.Forms.Button updateBatBtn;
        private System.Windows.Forms.Label rentalinfoLbl;
        private System.Windows.Forms.TextBox rentalTurnoverTxt;
        private System.Windows.Forms.TextBox rentalIncomeTxt;
        private System.Windows.Forms.TextBox rentalCostTxt;
        private System.Windows.Forms.TextBox barTurnoverTxt;
        private System.Windows.Forms.TextBox barIncomeTxt;
        private System.Windows.Forms.TextBox barCostTxt;
        private System.Windows.Forms.Label barinfoLbl;
        private System.Windows.Forms.Button generateSummaryBtn;
        private System.Windows.Forms.TabPage editDescription;
        private System.Windows.Forms.ComboBox bRefCBox;
        private System.Windows.Forms.Button goToEditDescBtn;
        private System.Windows.Forms.Button updateDescBtn;
        private System.Windows.Forms.Label descLbl;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label bankRefEditLbl;
        private System.Windows.Forms.Button modulesInfoBtn;
        private System.Windows.Forms.TabPage searchKeyword;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Button searchKeywordBtn;
        private System.Windows.Forms.Label searchKeywordLbl;
        private System.Windows.Forms.Label searchColumnLbl;
        private System.Windows.Forms.Label seachTableLbl;
        private System.Windows.Forms.TextBox keywordSeach;
        private System.Windows.Forms.ComboBox searchColumnCBox;
        private System.Windows.Forms.ComboBox searchTableCBox;
        private System.Windows.Forms.Button searchKWordBtn;
    }
}

