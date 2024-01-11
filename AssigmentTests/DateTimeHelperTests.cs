using OOP_Assigment1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentTests
{
    public class DateTimeHelperTests
    {   /*
        [Theory]
        [InlineData("2024-01-15", "2024-01-01")] // January 15, 2024 -> January 1, 2024
        [InlineData("2024-02-20", "2024-02-01")] // February 20, 2024 -> February 1, 2024
        public void GetFirstDayOfMonth_ReturnsFirstDay(DateTime input, DateTime expected)
        {
            var result = DateTimeHelper.GetFirstDayOfMonth(input);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("2024-01-15", "2024-01-31")] // January 15, 2024 -> January 31, 2024
        [InlineData("2024-02-20", "2024-02-29")] // February 20, 2024 (leap year) -> February 29, 2024
        public void GetDateTimeYear_ReturnsLastDay(DateTime input, DateTime expected)
        {
            var result = DateTimeHelper.GetDatimeYear(input);
            Assert.Equal(expected, result);
        }*/
        
        [Theory]
        [InlineData("2022-03-15", "2022-03-01")]
        [InlineData("2022-07-31", "2022-07-01")]
        [InlineData("2021-12-25", "2021-12-01")]
        public void ConvertToDateTime_ReturnsFirstDayOfMonth(string inputDate, string expectedDate)
        {
            // Arrange
            var expectedDateTime = DateTime.Parse(expectedDate);

            // Act
            var actualDateTime = DateTimeHelper.ConvertToDateTime(inputDate);

            // Assert
            Assert.Equal(expectedDateTime, actualDateTime);
        }

        [Theory]
        [InlineData("2000-01-01", 24)] // Assuming current year is 2024
        [InlineData("1980-12-31", 43)] // Assuming current year is 2024
        public void CalculateAge_ReturnsCorrectAge(DateTime birthDate, int expectedAge)
        {
            var age = DateTimeHelper.CalculateAge(birthDate);
            Assert.Equal(expectedAge, age);
        }

        [Fact]
        public void GetCurrentDateTime_ReturnsCurrentDateTime()
        {
            string expected = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string result = DateTimeHelper.GetCurrentDateTime();
            Assert.Equal(expected, result);
        }
    }
}
