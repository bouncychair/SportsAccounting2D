using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        async Task GetRequest(string request)
        {
            string url;
            if (request == "balance")
            {
                url = "http://127.0.0.1:122/api/getBalance/63eccee5211dcc98b44e182a";
            }
            else if(request == "" ){
                url = "http://127.0.0.1:122/api/getTransactions";
            }
            else
            {
                url = "http://127.0.0.1:122/api/searchKeyword?transaction_id=63eccee5211dcc98b44e182a&element=" + request;
            }
            using var client = new HttpClient();
            
            var content = await client.GetStringAsync(url);

            richTextBox1.Text = content;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                richTextBox1.Text = file;
                PostRequest(file);
            }

        }

        void PostRequest(string fileToUpload)
        {
            string url = "http://127.0.0.1:122/api/uploadFile";
            using (var client = new WebClient())
            {
                byte[] result = client.UploadFile(url, fileToUpload);
                string responseAsString = Encoding.Default.GetString(result);
                richTextBox1.Text = responseAsString;
            }
        }
        private List<User> users = new List<User>();
        private void RegisterAccount(User user)
        {
            foreach (var registeredUser in this.users)
            {
                if (registeredUser.Equals(user))
                {
                    registerFeedbackBox.Text = "Account already exists";
                    return;
                }
            }
            this.users.Add(user);
            //add user to database
            registerFeedbackBox.Text = "Account registered";
            usernameBox.Text = "";
            firstNameBox.Text = "";
            lastNameBox.Text = "";
            emailBox.Text = "";
            passwordBox.Text = "";
            usernameBox.Text = "";
        }
        private void Login(String username, String password)
        {
            loginFeedbackBox.Text = "";
            foreach (var user in users)
            {
                if (username.Equals(user.getUsername()))
                {
                    loginFeedbackBox.Text += "Found same user\n";
                    if (user.verifyPassword(password))
                    {
                        loginFeedbackBox.Text += user.getFirstName() + " " + user.getLastName() + " has logged in.\n";
                    }
                    else { loginFeedbackBox.Text += "Password is wrong, not logged in\n"; }

                }
                else
                {
                    loginFeedbackBox.Text += "No username found\n";
                }
            }
            loginUsernameBox.Text = "";
            loginPasswordBox.Text = "";
        }
        private async void searchBtn_Click(object sender, EventArgs e)
        {
            string request = comboBox1.SelectedItem.ToString();
            await GetRequest(request);
        }

        private async void showTransac_Click(object sender, EventArgs e)
        {
            await GetRequest("");
        }

        private async void showBalance_Click(object sender, EventArgs e)
        {
            await GetRequest("balance");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.RegisterAccount(new User(usernameBox.Text, firstNameBox.Text, lastNameBox.Text, emailBox.Text,
                passwordBox.Text, userTypeBox.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Login(loginUsernameBox.Text, loginPasswordBox.Text);
        }
    }
}
