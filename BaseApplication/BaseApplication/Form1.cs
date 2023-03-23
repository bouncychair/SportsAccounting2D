using ConsoleApp2;
using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using JsonConvert = Newtonsoft.Json.JsonConvert;

namespace BaseApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
            navigation.TabPages.Remove(editTransaction);
            navigation.TabPages.Remove(editDescription);
            navigation.TabPages.Remove(modules);

        }

        List<Dictionary<TextBox, TextBox>> assignCategoryHelper = new();
        private List<User> users = new();
        JObject modulesInformation = new();

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

        string UploadToAPI(string fileToUpload)
        {
            string url = "http://127.0.0.1:122/api/uploadFile";
            using var client = new WebClient();
            byte[] result = client.UploadFile(url, fileToUpload);
            return Encoding.Default.GetString(result);
            
        }

        void updateCategories(NameValueCollection categories)
        {
            string url = "http://127.0.0.1:122/api/updateCategory";
            using var client = new WebClient();
            client.UploadValues(url, categories);
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


        private async Task<string[]> GetTransactions()
        {
            string url = "http://127.0.0.1:122/api/getTransactions";
            using var client = new HttpClient();

            string transactions = await client.GetStringAsync(url);
            string[] transactionList = transactions.Substring(1, transactions.Length - 3).Split(',');

            return transactionList;
        }
        
        private async Task GetTransactionAsync()
        {
            assignCategoryHelper.Clear();

            int bRefX = 30;
            int categoryX = 180;
            int pointY = 40;

            string[] transactionList = await GetTransactions();

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
            EditTabs(false);
            navigation.SelectTab(mainPage);
            navigation.TabPages.Remove(editTransaction);
        }

        private async void addFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                string response = UploadToAPI(file);
                if (response.Equals("File uploaded"))
                {
                    MessageBox.Show("File uploaded. Please give each transaction a category");
                    //UploadToMongoDB(file);
                    navigation.TabPages.Add(editTransaction);
                    navigation.SelectTab(editTransaction);
                    EditTabs(true);
                    await GetTransactionAsync();
                }
                else if(response.Equals("Duplicate file"))
                {
                    MessageBox.Show("Duplicate file");
                }
                
            }
        }

        private void EditTabs(bool hide)
        {
            if (hide)
            {
                navigation.TabPages.Remove(mainPage);
                navigation.TabPages.Remove(registerPage);
                navigation.TabPages.Remove(loginPage);
            }
            else
            {
                navigation.TabPages.Add(mainPage);
                navigation.TabPages.Add(registerPage);
                navigation.TabPages.Add(loginPage);
            }
        }

        private async void updateBatBtn_Click(object sender, EventArgs e)
        {
            string url = "http://127.0.0.1:122/api/ModuleInfo/bar_information";
            using var client = new HttpClient();

            string content = await client.GetStringAsync(url);
            dynamic jsonObj = JsonConvert.DeserializeObject(content);
            barCostTxt.Text = jsonObj.bar_information.expense;
            barIncomeTxt.Text = jsonObj.bar_information.income;
            barTurnoverTxt.Text = jsonObj.bar_information.turnover;
        }

        private async void updateRental_Click(object sender, EventArgs e)
        {
            string url = "http://127.0.0.1:122/api/ModuleInfo/rental_information";
            using var client = new HttpClient();

            string content = await client.GetStringAsync(url);
            dynamic jsonObj = JsonConvert.DeserializeObject(content);
            rentalCostTxt.Text = jsonObj.rental_information.expense;
            rentalIncomeTxt.Text = jsonObj.rental_information.income;
            rentalTurnoverTxt.Text = jsonObj.rental_information.turnover;
        }

        private async void generateSummaryBtn_Click(object sender, EventArgs e)
        {
            string url = "http://127.0.0.1:122/api/ModulesSummary";
            using var client = new HttpClient();

            await client.GetStringAsync(url);
        }

        private void modulesInfoBtn_Click(object sender, EventArgs e)
        {
            navigation.TabPages.Add(modules);
            navigation.SelectTab(modules);
        }

        private async void goToEditDescBtn_Click(object sender, EventArgs e)
        {
            if (!navigation.TabPages.Contains(editDescription))
            {
                navigation.TabPages.Add(editDescription);
                string[] transactionList = await GetTransactions();

                foreach (string bankReference in transactionList)
                {
                    string bankReferenceTrim = bankReference.Trim(new Char[] { '[', ']', '"' });

                    bRefCBox.Items.Add(bankReferenceTrim);
                }
            }
            navigation.SelectTab(editDescription); 
        }

        private async void bRefCBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string bRef = bRefCBox.SelectedItem.ToString();
            bRefCBox.DropDownStyle = ComboBoxStyle.DropDownList;

            string url = "http://127.0.0.1:122/api/getTransactionDescription/"+ bRef;
            using var client = new HttpClient();

            string description = await client.GetStringAsync(url);
            string pattern = "[\"\\[\\]]|\n";
            string replacement = "";
            string descriptionTrim = Regex.Replace(description, pattern, replacement);
            richTextBox2.Text = descriptionTrim;
        }

        private async void updateDescBtn_Click(object sender, EventArgs e)
        {
            string description = richTextBox2.Text;
            string bRef = bRefCBox.SelectedItem.ToString();

            string url = $"http://127.0.0.1:122/api/updateTransactionDescription?customDetails={description}&bankReference={bRef}";
            using var client = new HttpClient();

            string response = await client.GetStringAsync(url);
            MessageBox.Show(response);

            navigation.TabPages.Remove(editDescription);
            navigation.SelectTab(mainPage);
        }
    }
}
