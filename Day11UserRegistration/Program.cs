using System;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace Day11UserRegistration
{
    class Program
    {

        public bool validateFirstName(string firstName)
        {
            string pattern = @"^[A-Z]\w{2,}$";
            bool result = Regex.IsMatch(firstName, pattern);

            try
            {
                if (Regex.IsMatch(firstName, pattern))
                    return result;
                else
                    throw new UserRegistrationException(UserRegistration.ExceptionType.INVALID_FIRSTNAME, "Invalid first name")
            }
            catch (UserRegistrationException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Problem");
            Console.WriteLine("Welcome to unit testing of user registration");
            bool result;

            Program program = new Program();
            result = program.validateFirstName("Sanjana");
            Console.WriteLine("First name validation result: " + result);
        }
    }
}




    