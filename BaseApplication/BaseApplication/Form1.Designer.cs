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
            this.showTransac = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.showBalance = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.keyword = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showTransac
            // 
            this.showTransac.Location = new System.Drawing.Point(12, 79);
            this.showTransac.Name = "showTransac";
            this.showTransac.Size = new System.Drawing.Size(147, 32);
            this.showTransac.TabIndex = 0;
            this.showTransac.Text = "Show Transactions";
            this.showTransac.UseVisualStyleBackColor = true;
            this.showTransac.Click += new System.EventHandler(this.showTransac_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(392, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(387, 390);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // showBalance
            // 
            this.showBalance.Location = new System.Drawing.Point(12, 158);
            this.showBalance.Name = "showBalance";
            this.showBalance.Size = new System.Drawing.Size(147, 32);
            this.showBalance.TabIndex = 2;
            this.showBalance.Text = "Show Balance";
            this.showBalance.UseVisualStyleBackColor = true;
            this.showBalance.Click += new System.EventHandler(this.showBalance_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(237, 158);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // keyword
            // 
            this.keyword.AutoSize = true;
            this.keyword.Location = new System.Drawing.Point(250, 65);
            this.keyword.Name = "keyword";
            this.keyword.Size = new System.Drawing.Size(62, 16);
            this.keyword.TabIndex = 5;
            this.keyword.Text = "Keyword:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "available_balance",
            "final_opening_balance",
            "transactions",
            "transaction_reference"});
            this.comboBox1.Location = new System.Drawing.Point(201, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 43);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.keyword);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.showBalance);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.showTransac);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showTransac;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button showBalance;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label keyword;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}

