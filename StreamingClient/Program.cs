using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Client
{
    class Program
    {
        //const string URL = "http://localhost/StreamingDemo/api/media";
        const string URL = "http://localhost:3574/api/media";

        static async Task GetMedia() {

            HttpClient client = new HttpClient();
            var stream = await client.GetStreamAsync(URL);

            byte[] buffer = new byte[1024 * 1024];
            while (stream.Read(buffer,0,buffer.Length) > 0)
            {
                Console.Write(".");
            }

            Console.WriteLine();
            Console.WriteLine("Fertig gelesen");

        }


        static async Task GetMediaViaPost()
        {
            HttpClient client = new HttpClient();

            var request = new HttpRequestMessage(HttpMethod.Post, URL);

            var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            
            var stream = await response.Content.ReadAsStreamAsync();

            Console.WriteLine("Got Stream!");

            byte[] buffer = new byte[1024 * 1024];
            while (stream.Read(buffer, 0, buffer.Length) > 0)
            {
                Console.Write(".");
            }

            Console.WriteLine();
            Console.WriteLine("Fertig gelesen");

        }

        static async Task SendMedia() {
            var fileName = @"C:\temp\media\big.zip";
            var fileStream = new FileStream(fileName, FileMode.Open);

            HttpClient client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Put, URL);
            request.Content = new StreamContent(fileStream, 1024 * 1024);
            var response = await client.SendAsync(request, HttpCompletionOption.ResponseContentRead);

            //var status = response.StatusCode;
            //var result = await response.Content.ReadAsStringAsync();

            //Console.WriteLine("Success: " + response.IsSuccessStatusCode);
            //Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Start: [ENTER]");
            Console.ReadLine();

            GetMedia().Wait();
            // GetMediaViaPost().Wait();
            // SendMedia().Wait();

            Console.WriteLine("Fertig!");
            Console.ReadLine();

        }
    }
}
