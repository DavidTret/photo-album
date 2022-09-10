using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace photo_album
{
    public class Program
    {
        private static readonly HttpClient httpClient = new HttpClient();
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                while (true)
                {
                    string input = Console.ReadLine() ?? string.Empty;
                    if (string.IsNullOrEmpty(input))
                        break;
                    string output = Find(input);
                    Console.Write(output);
                }
            }
            else
            {
                foreach (string arg in args)
                {
                    string output = Find(arg);
                    Console.Write(output);
                }
            }
        }
        public static string Find(string input)
        {
            // Return if the input is not an int.
            if (!int.TryParse(input, out int value))
                return "albumID must be an int!\n";
            // Return if the input is not between 1 - 100.
            if (value > 100 || value < 1)
                return "albumID must be between 1 and 100!\n";

            // Add the album id to the base uri.
            string uri = "https://jsonplaceholder.typicode.com/photos?albumId=" + value.ToString();

            try
            {
                var task = httpClient.GetAsync(uri);
                task.Wait();
                var response = task.Result;
                HttpContent content = response.Content;
                string responseFromServer = content.ReadAsStringAsync().Result;
                // Parse the data stream as a Json document.
                var doc = JsonDocument.Parse(responseFromServer);
                // Use a string builder to create output string as we loop over the Json array.
                StringBuilder songStrings = new StringBuilder();
                foreach (var item in doc.RootElement.EnumerateArray())
                {
                    foreach (var property in item.EnumerateObject())
                    {
                        if (property.NameEquals("id"))
                            songStrings.Append('[' + property.Value.ToString() + ']');
                        else if (property.NameEquals("title"))
                            songStrings.Append(' ' + property.Value.ToString() + '\n');
                    }
                }
                return songStrings.ToString();
            }
            catch
            {
                return "Could not make web request.\n";
            }
        }
    }
}