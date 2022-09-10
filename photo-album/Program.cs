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
        static async Task Main(string[] args)
        {
            if (args.Length == 0)
            {
                while (true)
                {
                    string input = Console.ReadLine() ?? string.Empty;
                    if (string.IsNullOrEmpty(input))
                        break;
                    string output = await GetPhotos(input);
                    Console.Write(output);
                }
            }
            else
            {
                foreach (string arg in args)
                {
                    string output = await GetPhotos(arg);
                    Console.Write(output);
                }
            }
        }
        public static async Task<string> GetPhotos(string input)
        {
            // Return if the input is not an int.
            if (!int.TryParse(input, out int albumId))
                return "albumId must be an int!\n";
            // Return if the albumId is not between 1 - 100.
            if (albumId > 100 || albumId < 1)
                return "albumId must be between 1 and 100!\n";

            // Add the albumId to the base uri.
            string uri = "https://jsonplaceholder.typicode.com/photos?albumId=" + albumId.ToString();
            try
            {
                string response = await httpClient.GetStringAsync(uri);
                List<Photo> album = JsonSerializer.Deserialize<List<Photo>>(response) ?? new List<Photo>();
                // Use a string builder to create an output string as we loop over the album array.
                StringBuilder strPhotos = new StringBuilder();
                foreach (Photo photo in album)
                {
                    strPhotos.Append('[' + photo.id.ToString() + "] " + photo.title + '\n');
                }
                return strPhotos.ToString();
            }
            catch
            {
                return "Could not make web request.\n";
            }
        }
    }
    class Photo
    {
        public int id { get; set; }
        public string title { get; set; } = string.Empty;
    }
}