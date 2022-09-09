using System;

namespace photo_album
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public class AlbumFinder
    {
        public string Find(string input)
        {
            if (!int.TryParse(input, out int value))
            {
                return "albumID must be an int!";
            }
            throw new NotImplementedException();
        }
    }
}