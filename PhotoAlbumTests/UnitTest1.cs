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
            // Define test input and outputs.
            string input = "notAnInt";
            string output = "albumID must be an int!";
            // Run the method under the test.
            string programOutput = Program.Find(input);
            Assert.AreEqual(output, programOutput);
        }
        [TestMethod]
        public void LowInputTest()
        {
            // Define test input and outputs.
            string input = "0";
            string output = "albumID must be between 1 and 100!";
            // Run the method under the test.
            string programOutput = Program.Find(input);
            Assert.AreEqual(output, programOutput);
        }
        [TestMethod]
        public void HighInputTest()
        {
            // Define test input and outputs.
            string input = "101";
            string output = "albumID must be between 1 and 100!";
            // Run the method under the test.
            string programOutput = Program.Find(input);
            Assert.AreEqual(output, programOutput);
        }
        [TestMethod]
        public void ValidInputTest()
        {
            // Define test input and outputs.
            string input = "2";
            string output = 
                "[51] non sunt voluptatem placeat consequuntur rem incidunt\n" +
                "[52] eveniet pariatur quia nobis reiciendis laboriosam ea\n" +
                "[53] soluta et harum aliquid officiis ab omnis consequatur\n" +
                "[54] ut ex quibusdam dolore mollitia\n" +
                "[55] voluptatem consequatur totam qui aut iure est vel\n" +
                "[56] vel voluptatem esse consequuntur est officia quo aut quisquam\n" +
                "[57] vero est optio expedita quis ut molestiae\n" +
                "[58] rem pariatur facere eaque\n" +
                "[59] modi totam dolor eaque et ipsum est cupiditate\n" +
                "[60] ea enim temporibus asperiores placeat consectetur commodi ullam\n" +
                "[61] quia minus sed eveniet accusantium incidunt beatae odio\n" +
                "[62] dolorem cumque quo nihil inventore enim\n" +
                "[63] facere animi autem quod dolor\n" +
                "[64] doloremque culpa quia\n" +
                "[65] sed voluptatum enim eaque cumque qui sunt\n" +
                "[66] provident rerum voluptatem illo asperiores qui maiores\n" +
                "[67] veritatis labore ipsum unde aut quam dolores\n" +
                "[68] architecto aut quod qui ullam vitae expedita delectus\n" +
                "[69] et autem dolores aut porro est qui\n" +
                "[70] quam quos dolor eum ea in\n" +
                "[71] illo qui vel laboriosam vel fugit deserunt\n" +
                "[72] iusto sint enim nesciunt facilis exercitationem\n" +
                "[73] rerum exercitationem libero dolor\n" +
                "[74] eligendi quas consequatur aut consequuntur\n" +
                "[75] aut magni quibusdam cupiditate ea\n" +
                "[76] magni nulla et dolores\n" +
                "[77] ipsum consequatur vel omnis mollitia repellat dolores quasi\n" +
                "[78] aperiam aut est amet tenetur et dolorem\n" +
                "[79] est vel et laboriosam quo aspernatur distinctio molestiae\n" +
                "[80] et corrupti nihil cumque\n" +
                "[81] error magni fugiat dolorem impedit molestiae illo ullam debitis\n" +
                "[82] voluptate voluptas molestias vitae illo iusto\n" +
                "[83] quia quasi enim voluptatem repellat sit sint\n" +
                "[84] aliquam dolorem ut modi ratione et assumenda impedit\n" +
                "[85] ullam delectus architecto sint error\n" +
                "[86] qui vel ut odio consequuntur\n" +
                "[87] eos nihil sunt accusantium omnis\n" +
                "[88] inventore veritatis magnam enim quasi\n" +
                "[89] id at cum incidunt nulla dolor vero tenetur\n" +
                "[90] et quae eligendi vitae maxime in\n" +
                "[91] sunt quo laborum commodi porro consequatur nam delectus et\n" +
                "[92] quod non quae\n" +
                "[93] molestias et aliquam natus repellendus accusamus dolore\n" +
                "[94] et quisquam aspernatur\n" +
                "[95] magni odio non\n" +
                "[96] dolore esse a in eos sed\n" +
                "[97] labore magnam officiis nemo et\n" +
                "[98] sed commodi libero id nesciunt modi vitae\n" +
                "[99] magnam dolor sed enim vel optio consequuntur\n" +
                "[100] et qui rerum\n";
            // Run the method under the test.
            string programOutput = Program.Find(input);
            Assert.AreEqual(output, programOutput);
        }
    }
}