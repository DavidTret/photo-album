using System;

namespace photo_album
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public string Find(string input)
        {
            // Return if the input is not an int.
            if (!int.TryParse(input, out int value))
                return "albumID must be an int!";
            // Return if the input is not between 1 - 100.
            if (value > 100 || value < 1)
                return "albumID must be between 1 and 100!";
            throw new NotImplementedException();
        }
    }
}