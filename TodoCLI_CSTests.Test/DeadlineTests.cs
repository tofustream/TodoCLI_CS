using TodoCLI_CS.Domain.VOs;

namespace TodoCLI_CSTests.Test
{
    [TestClass]
    public class DeadlineTests
    {
        [TestMethod]
        public void Constructor_ValidDeadline_CreatesDeadline()
        {
            // Arrange
            var validDate = DateTime.UtcNow.AddDays(1);

            // Act
            var deadline = new Deadline(validDate);

            // Assert
            Assert.AreEqual(validDate, deadline.Value, "The deadline should match the input date.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_PastDeadline_ThrowsArgumentException()
        {
            // Arrange
            var pastDate = DateTime.UtcNow.AddDays(-1);

            // Act
            _ = new Deadline(pastDate); // Expected exception
        }

        [TestMethod]
        public void ToString_ReturnsFormattedDate_24HoursLater()
        {
            // Arrange
            var now = DateTime.UtcNow;
            var deadline = new Deadline(now.AddHours(24)); // 現在から24時間後の期限

            // Act
            var result = deadline.ToString();

            // Assert
            Assert.AreEqual(now.AddHours(24).ToString("yyyy-MM-dd HH:mm:ss"), result, "The date format should match 'yyyy-MM-dd HH:mm:ss'.");
        }
    }
}
