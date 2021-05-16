using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            Book book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);
            double expectedAverage = 85.6;
            double expectedHigh = 90.5;
            double expectedLow = 77.3;

            Statistics result = book.GetStatistics();

            Assert.Equal(expectedAverage, result.Average, 1);
            Assert.Equal(expectedHigh, result.High, 1);
            Assert.Equal(expectedLow, result.Low, 1);
        }
    }
}
