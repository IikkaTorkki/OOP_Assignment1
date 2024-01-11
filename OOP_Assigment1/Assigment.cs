using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assigment1
{
    public static class Calculator
    {
        //decimal offical documentation: https://learn.microsoft.com/en-us/dotnet/api/system.decimal?view=net-7.0

        public static decimal Sum(decimal a, decimal b)
        {
            //Assigment 1: Return the sum of a and b.
            return a + b;
        }

        public static decimal Divide(decimal a, decimal b)
        {
            //Assigment 2: Return the result of dividing a by b.
            //Note no need to check for divide by zero, but you can do if you want
            return a / b;
        }

        public static decimal Multiply(decimal a, decimal b)
        {
            //Assigment 3: Return the result of multiplying a by b.
            return a * b;
        }

        public static decimal Subtract(decimal a, decimal b)
        {
            //Assigment 4: Return the result of subtracting b from a.
            return a - b;
        }

        public static decimal ConvertPoundsToKg(decimal pounds)
        {
            //Assigment 5: Return the result of converting pounds to kg. Round to 2 decimals.
            return Math.Round(pounds * 0.45359237m, 2);
        }

        public static decimal ConvertFahreheitToCelcius(decimal fahrenheit)
        {
            //Assigment 6: Return the result of converting fahrenheit to celcius.  Round to 2 decimals.
            return Math.Round(5m / 9m * (fahrenheit - 32m), 2);
        }
    }

    public static class DateTimeHelper
    {

        public static int CalculateAge(DateTime birthTime)
        {
            //Assigment 7: Calculate the age of the person born using the birthTime parameter.
            DateTime now = DateTime.Now;
            
            return (int)((now - birthTime).TotalDays / 365);
            //return now.Year - birthTime.Year;
        }

        // The test does not call the correct function name.
        public static DateTime ConvertToDateTime(string date)
        //public static DateTime GetFirstDayOfMonth(string date)
        {
            //Assigment 8: Return the first day of the month of the date parameter.
            //The input string format is 2022-07-31
            var given = DateTime.Parse(date);
            return new DateTime(given.Year, given.Month, 1);
        }
        public static DateTime GetFirstDayOfMonth(DateTime date)
        {
            return new DateTime(date.Year, date.Month, 1);
        }


        public static bool IsLeapYear(DateTime date)
        {
            //Assigment 9: Return true if date is leap year
            return date.Year % 4 == 0;
        }

        public static int DaysUntilNextBirthday(DateTime birthDate)
        {
            //Assigment 10: Calculate the number of days until the next birthday.
            //Note that this is not easily unit tested because the result depends on the current date!!!
            //So this assignment is not tested in the unit tests.
            DateTime now = DateTime.Now;
            var diff = (birthDate - now).TotalDays;

            return (int)diff;
        }


        public static string GetCurrentDateTime()
        {
            //Assigment 11: Return the current date and time in the format: "yyyy-MM-dd HH:mm:ss".
            var now = DateTime.Now;

            return string.Format("{0:yyyy-MM-dd HH:mm:ss}", now);
        }

    }


    public static class RoleChecker
    {
        public enum Role
        {
            Admin,
            User,
            Guest
        }

        public static bool IsAdmin(Role role)
        {
            //Assigment 11: Return true if role is Admin, otherwise return false.
            return role == Role.Admin;
        }
       

        public static bool HasPrivligies(Role role, DateTime validUntill) 
        {
            //Assigment 12: Return true if role is Admin or User and validUntill is in the future, otherwise return false.
            DateTime now = DateTime.Now;
            return role == Role.Admin || validUntill.CompareTo(now) > 0;
        }

        public static string RoleToString(Role role)
        {
            //Assigment 13: Implement a method RoleToString(Role role) that converts the Role enum to its string representation.
            return role.ToString();
        }

        public static Role StringToRole(string roleString)
        {
            //Assigment 14: Write a method StringToRole(string roleString) that converts a string to the corresponding Role enum. 
            //If the string does not match any role, throw an appropriate exception.
            //Hint: Remember how conversion worked on ints (especially TryParse)
            if (Enum.TryParse<Role>(roleString, out Role role))
            {
                return role;
            }
            throw new ArgumentException($"'{roleString}' is not a valid variant of Role");
        }

    }
}
