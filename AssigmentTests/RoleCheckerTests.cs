using OOP_Assigment1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentTests
{
    public class RoleCheckerTests
    {
        [Theory]
        [InlineData(RoleChecker.Role.Admin, true)]
        [InlineData(RoleChecker.Role.User, false)]
        public void IsAdmin_ReturnsCorrectValue(RoleChecker.Role role, bool expectedResult)
        {
            var result = RoleChecker.IsAdmin(role);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(RoleChecker.Role.Admin, "2024-10-10", true)] // Assuming today is 2023-12-31
        [InlineData(RoleChecker.Role.User, "2023-11-30", false)] // Assuming today is 2023-12-31
        public void HasPrivileges_ReturnsCorrectValue(RoleChecker.Role role, DateTime validUntil, bool expectedResult)
        {
            var result = RoleChecker.HasPrivligies(role, validUntil);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(RoleChecker.Role.Admin, "Admin")]
        [InlineData(RoleChecker.Role.User, "User")]
        [InlineData(RoleChecker.Role.Guest, "Guest")]
        public void RoleToString_ReturnsCorrectString(RoleChecker.Role role, string expected)
        {
            // Act
            var result = RoleChecker.RoleToString(role);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("Admin", RoleChecker.Role.Admin)]
        [InlineData("User", RoleChecker.Role.User)]
        [InlineData("Guest", RoleChecker.Role.Guest)]
        public void StringToRole_ReturnsCorrectRole(string roleString, RoleChecker.Role expected)
        {
            // Act
            var result = RoleChecker.StringToRole(roleString);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void StringToRole_ThrowsExceptionForInvalidString()
        {
            // Act & Assert
            Assert.Throws<ArgumentException>(() => RoleChecker.StringToRole("InvalidRole"));
        }
    }
}
