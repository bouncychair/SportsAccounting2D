using ConsoleApp2;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.IO;
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
            assignCategoryHelper.Clear();
        }

        List<Dictionary<TextBox, TextBox>> assignCategoryHelper = new();


        async Task GetRequest(string request)
        {
            string url;
            if (request == "balance")
            {
                url = "http://127.0.0.1:122/api/getBalance/63eccee5211dcc98b44e182a";
            }
            else if (request == "")
            {
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

        void UploadToAPI(string fileToUpload)
        {
            string url = "http://127.0.0.1:122/api/uploadFile";
            using var client = new WebClient();
            byte[] result = client.UploadFile(url, fileToUpload);
            string responseAsString = Encoding.Default.GetString(result);
            richTextBox1.Text = responseAsString;
        }

        void updateCategories(NameValueCollection categories)
        {
            string url = "http://127.0.0.1:122/api/updateCategory";
            using var client = new WebClient();
            byte[] result = client.UploadValues(url, categories);
            string responseAsString = Encoding.Default.GetString(result);
            richTextBox2.Text = responseAsString;
        }
        void UploadToMongoDB(string fileToUpload)
        {
            string connectionString = "mongodb+srv://bigUser:bigPassword@project.0tii4ke.mongodb.net/?retryWrites=true&w=majority";
            MongoClient dbClient = new(connectionString);
            var database = dbClient.GetDatabase("ProjTest");
            var collection = database.GetCollection<BsonDocument>("MT940Raw");

            string content = File.ReadAllText(fileToUpload);
            var document = new BsonDocument { { "file", content } };
            collection.InsertOneAsync(document);
        }
        private List<User> users = new();
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

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                UploadToAPI(file);
                UploadToMongoDB(file);
            }
        }

        private async Task GetTransactionAsync()
        {
            int bRefX = 30;
            int categoryX = 180;
            int pointY = 40;

            string url = "http://127.0.0.1:122/api/getTransactions";
            navigation.SelectedIndex = 4;
            using var client = new HttpClient();

            string transactions = await client.GetStringAsync(url);
            string[] transactionList = transactions.Substring(1, transactions.Length - 3).Split(',');

            foreach (string bankReference in transactionList)
            {
                string bankReferenceTrim = bankReference.Trim(new Char[] { '[', ']', '"' });
                TextBox bRef = new()
                {
                    Text = bankReferenceTrim,
                    Location = new Point(bRefX, pointY)
                };
                editTransaction.Controls.Add(bRef);

                TextBox category = new()
                {
                    Location = new Point(categoryX, pointY)
                };
                editTransaction.Controls.Add(category);
                pointY += 25;

                assignCategoryHelper.Add(new Dictionary<TextBox, TextBox> { { bRef, category } });
            }


        }

        private async void showTransaction_Click(object sender, EventArgs e)
        {
            await GetTransactionAsync();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            foreach (Dictionary<TextBox, TextBox> dict in assignCategoryHelper)
            {
                foreach (KeyValuePair<TextBox, TextBox> pair in dict)
                {
                    NameValueCollection updatedCategories = new();
                    string bankReference = pair.Key.Text;
                    string category = pair.Value.Text;
                    updatedCategories.Add("bankReference", bankReference);
                    updatedCategories.Add("category", category);
                    updateCategories(updatedCategories);
                }
            }
        }
    }
}
