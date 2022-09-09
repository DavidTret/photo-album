using Microsoft.VisualStudio.TestTools.UnitTesting;
using photo_album;

namespace PhotoAlbumTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BadInputTest()
        {
            // Create an instance to test.
            AlbumFinder albumFinder = new AlbumFinder();
            // Define test input and outputs.
            string input = "notAnInt";
            string output = "albumID must be an int!";
            // Run the method under the test.
            string programOutput = albumFinder.Find(input);
            Assert.AreEqual(output, programOutput);
        }
        [TestMethod]
        public void LowInputTest()
        {
            // Create an instance to test.
            AlbumFinder albumFinder = new AlbumFinder();
            // Define test input and outputs.
            string input = "0";
            string output = "albumID must be between 1 and 100!";
            // Run the method under the test.
            string programOutput = albumFinder.Find(input);
            Assert.AreEqual(output, programOutput);
        }
        [TestMethod]
        public void HighInputTest()
        {
            // Create an instance to test.
            AlbumFinder albumFinder = new AlbumFinder();
            // Define test input and outputs.
            string input = "101";
            string output = "albumID must be between 1 and 100!";
            // Run the method under the test.
            string programOutput = albumFinder.Find(input);
            Assert.AreEqual(output, programOutput);
        }
    }
}