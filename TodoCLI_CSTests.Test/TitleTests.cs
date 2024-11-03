using TodoCLI_CS.Domain.VOs;

namespace TodoCLI_CSTests.Test
{
    [TestClass]
    public class TitleTests
    {
        [TestMethod]
        public void Constructor_ValidTitle_CreatesTitle()
        {
            string validTitle = "This is a valid title";

            var title = new Title(validTitle);

            Assert.IsNotNull(title);
            Assert.AreEqual(validTitle, title.Value);
        }

        [TestMethod]
        public void Constructor_EmptyTitle_ThrowsArgumentException()
        {
            string emptyTitle = "";

            var exception = Assert.ThrowsException<ArgumentException>(() => new Title(emptyTitle));
            Assert.AreEqual("title must not be empty", exception.Message);
        }

        [TestMethod]
        public void Constructor_WhitespaceTitle_ThrowsArgumentException()
        {
            string whitespaceTitle = "    ";

            var exception = Assert.ThrowsException<ArgumentException>(() => new Title(whitespaceTitle));
            Assert.AreEqual("title must not be empty", exception.Message);
        }

        [TestMethod]
        public void Constructor_TitleTooLong_ThrowsArgumentOutOfRangeException()
        {
            string longTitle = new string('a', 101); // 101•¶Žš‚Ìƒ^ƒCƒgƒ‹

            var exception = Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Title(longTitle));
            Assert.AreEqual("value", exception.ParamName);
            Assert.AreEqual("please keep the title under 100 characters (Parameter 'value')", exception.Message);
        }

        [TestMethod]
        public void Value_ReturnsCorrectTitle()
        {
            // Arrange
            string validTitle = "A valid title";
            var title = new Title(validTitle);

            // Act
            string result = title.Value;

            // Assert
            Assert.AreEqual(validTitle, result);
        }

        [TestMethod]
        public void ToString_ReturnsCorrectTitle()
        {
            // Arrange
            string validTitle = "ToString Test Title";
            var title = new Title(validTitle);

            // Act
            string result = title.ToString();

            // Assert
            Assert.AreEqual(validTitle, result);
        }
    }
}
