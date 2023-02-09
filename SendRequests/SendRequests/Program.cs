using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SendRequests
{
    internal class Program
    {

        static async Task Main(string[] args)
        {
            //MONGODB CONNECTION CAUSE WHY NOT
            /* string connectionString = "mongodb+srv://adman:qweasd123@projectdb.ud8fb4w.mongodb.net/?retryWrites=true&w=majority";

             MongoClient dbClient = new MongoClient(connectionString);

             var database = dbClient.GetDatabase("ProjTest");
             var collection = database.GetCollection<BsonDocument>("MT940Parsed");

             var firstDocument = collection.Find(new BsonDocument()).FirstOrDefault();
             //Console.WriteLine(firstDocument.ToString());*/

            /*string content = File.ReadAllText(@"C:\\MainStuff\\MT940 JSON.txt");
            //BsonDocument document = BsonDocument.Parse(json);*/


            string content = File.ReadAllText(@"C:\\MainStuff\\MT940 JSON.txt");

            var data = new StringContent(content, Encoding.UTF8, "application/json");

            var url = "http://127.0.0.1:122/api/upload";
            using var client = new HttpClient();

            var response = await client.PostAsync(url, data);

            var result = await response.Content.ReadAsStringAsync();
            Console.WriteLine(result);


        }

        //FUNCTIONS NOT WORK YET
        static async Task SendFilePOST(string document)
        {
            using var client = new HttpClient();
            var data = new StringContent(document, Encoding.UTF8, "application/json");
            var url = "http://127.0.0.1:122/api/upload";

            var response = await client.PostAsync(url, data);

            var result = await response.Content.ReadAsStringAsync();
            Console.WriteLine(result);

        }

        static async Task SendFileGET()
        {
            using var client = new HttpClient();
            var content = await client.GetStringAsync("http://127.0.0.1:122/api/upload");

            Console.WriteLine(content);

        }
    }
}
