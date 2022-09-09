using System;
using System.Net;
using System.Text;
using System.Text.Json;

namespace photo_album
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine() ?? string.Empty;
                string output = Find(input);
                Console.Write(output);
            }
        }
        public static string Find(string input)
        {
            // Return if the input is not an int.
            if (!int.TryParse(input, out int value))
                return "albumID must be an int!";
            // Return if the input is not between 1 - 100.
            if (value > 100 || value < 1)
                return "albumID must be between 1 and 100!";

            string uri = "https://jsonplaceholder.typicode.com/photos?albumId=" + value.ToString();
            WebRequest webRequest = WebRequest.Create(uri);
            HttpWebResponse response = (HttpWebResponse)webRequest.GetResponse();
            if (response.StatusDescription == "OK")
            {
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();

                var doc = JsonDocument.Parse(responseFromServer);
                StringBuilder songStrings = new StringBuilder();
                foreach (var item in doc.RootElement.EnumerateArray())
                {
                    foreach (var property in item.EnumerateObject())
                        songStrings.Append(property.Value.ToString() + '\n');
                }
                return songStrings.ToString();
            }
            else
            {
                return "Could not make web request.";
            }
        }
    }
}