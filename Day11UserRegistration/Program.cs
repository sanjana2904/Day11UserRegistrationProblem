using Day11UserRegistration;
using System;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace Day11UserRegistration
{
   public class Program
    {

        public bool validateFirstName(string firstName)
        {
            string pattern = @"^[A-Z]\w{2,}$";
            bool result = Regex.IsMatch(firstName, pattern);
            return result;

            try

            {
                if (Regex.IsMatch(firstName, pattern))
                    return true;
                else
                    throw new UserRegistrationException(UserRegistration.ExceptionType.INVALID_FIRSTNAME, "Invalid first name")
            }
            catch (UserRegistrationException ex)
            {
                Console.WriteLine(ex.result);
                return false;
            }

        }
        public bool validateEmail(string name)
        {
            string pattern = @"^[\w]+@[a-zA-Z0-9]+.[a-zA-Z0-9]+";
            bool result = Regex.IsMatch(name, pattern);
            return result;
        }
        try

            {
                if (Regex.IsMatch(name, pattern))
                    return true;
                else
                    throw new UserRegistrationException(UserRegistration.ExceptionType.Invalid email, "Invalid email")
public Program()
        {
        }
    }
            catch (UserRegistrationException ex)
            {
                Console.WriteLine(ex.result);
                return false;
            }

            public bool validatePhoneNumber(string number)
            {
                string pattern = @"^\d{2}\s\d{10}$";
                bool result = Regex.IsMatch(number, pattern);
                return result;
            }
                try

                {
                    if (Regex.IsMatch(number, pattern))
                        return true;
                    else
                        throw new UserRegistrationException(UserRegistration.ExceptionType.Invalid number, "Invalid number")
                }
                catch (UserRegistrationException ex)
                {
                    Console.WriteLine(ex.result);
                    return false;
                }



                static void Main(string[] args)
                {
                Console.WriteLine("Welcome to User Registration Problem");
                Console.WriteLine("Welcome to unit testing of user registration");
                bool result;

                Program program = new Program();
                result = program.validateFirstName("Sanjana");
                Console.WriteLine("First name validation result: " + result);
                result = program.validateEmail("sanju@gmail.com");
                Console.WriteLine("Email name validation result: " + result);
                result = program.validatePhoneNumber("91 7708796223");
                Console.WriteLine("Phone Number validation result: " + result);
}







    