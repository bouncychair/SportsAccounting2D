using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SendRequests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MONGODB CONNECTION CAUSE WHY NOT
            /*
             MongoClient dbClient = new MongoClient(connectionString);

             var database = dbClient.GetDatabase("ProjTest");
             var collection = database.GetCollection<BsonDocument>("MT940Parsed");

             var firstDocument = collection.Find(new BsonDocument()).FirstOrDefault();
             Console.WriteLine(firstDocument.ToString());
            */

            string fileToUpload = @"C:\\MainStuff\\MT940TXT.txt";
            string url = "http://127.0.0.1:122/api/uploadFile";
            using (var client = new WebClient())
            {
                byte[] result = client.UploadFile(url, fileToUpload);
                string responseAsString = Encoding.Default.GetString(result);
                Console.WriteLine(responseAsString);
            }
        }

        static async Task GetRequest()
        {
            using var client = new HttpClient();
            var content = await client.GetStringAsync("http://127.0.0.1:122/api/upload");

            Console.WriteLine(content);

        }
    }
}
