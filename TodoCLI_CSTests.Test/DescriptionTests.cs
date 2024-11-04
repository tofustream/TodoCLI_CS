using TodoCLI_CS.Domain.VOs;

namespace TodoCLI_CSTests.Test
{
    [TestClass]
    public class DescriptionTests
    {
        [TestMethod]
        public void Constructor_ValidDescription_CreatesDescription()
        {
            string validDescription = "This is a valid description";

            var description = new Description(validDescription);

            Assert.IsNotNull(description);
            Assert.AreEqual(validDescription, description.Value);
        }

        [TestMethod]
        public void Constructor_DescriptionTooLong_ThrowsArgumentOutOfRangeException()
        {
            string longDescription = new string('a', 501);

            var exception = Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Description(longDescription));
            Assert.AreEqual("value", exception.ParamName);
            Assert.AreEqual("please keep the description under 500 characters (Parameter 'value')", exception.Message);
        }

        [TestMethod]
        public void Value_ReturnsCorrectDescription()
        {
            // Arrange
            string validDescription = "A valid description";
            var description = new Description(validDescription);

            // Act
            string result = description.Value;

            // Assert
            Assert.AreEqual(validDescription, result);
        }

        [TestMethod]
        public void ToString_ReturnsCorrectDescription()
        {
            // Arrange
            string validDescription = "ToString Test Description";
            var description = new Description(validDescription);

            // Act
            string result = description.ToString();

            // Assert
            Assert.AreEqual(validDescription, result);
        }
    }
}
