using Xunit;

namespace GradeBook.Tests
{
    public class BookTest
    {
        [Fact]
        public void Test()
        {
            // Arrange
            var book = new Book("New Book");
            book.AddGrade(50);
            book.AddGrade(60.50);
            book.AddGrade(70.90);
            book.AddGrade(80.50);
            book.AddGrade(90.10);

            // Act
            var result = book.GetStatistics();

            // Assert
            Assert.Equal(70.40, result.Average, 2);
            Assert.Equal(50, result.Low);
            Assert.Equal(90.10, result.High);
        }
    }
}
