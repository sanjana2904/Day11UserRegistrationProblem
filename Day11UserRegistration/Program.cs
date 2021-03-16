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
            public bool validatePassword(string password)
            {
                string pattern = @"^.{8,}$";
                bool result = Regex.IsMatch(password, pattern);
                return result;
            }
                try

                {
                    if (Regex.IsMatch(password, pattern))
                        return true;
                    else
                        throw new UserRegistrationException(UserRegistration.ExceptionType.Invalid number, "Invalid number")
                                }
                catch (UserRegistrationException ex)
                {
                    Console.WriteLine(ex.result);
                    return false;
                }
                public bool validateUppercase(string uppercase)
                {
                    string pattern = @"^(?=.*[A-Z]).{8,}$";
                    bool result = Regex.IsMatch(uppercase, pattern);
                    return result;
                }
                try

                {
                    if (Regex.IsMatch(uppercase, pattern))
                        return true;
                    else
                        throw new UserRegistrationException(UserRegistration.ExceptionType.Invalid uppercase, "Invalid uppercase")
                                                }
                catch (UserRegistrationException ex)
                {
                    Console.WriteLine(ex.result);
                    return false;
                }

                    public bool validateNumericcase(string name)
                    {
                        string pattern = @"^(?=.*[A-Z])(?=.*[0-9]).{8,}$";
                        bool result = Regex.IsMatch(name, pattern);
                        return result;
                    }
                    try

                    {
                        if (Regex.IsMatch(name, pattern))
                            return true;
                        else
                            throw new UserRegistrationException(UserRegistration.ExceptionType.Invalid Numeric case, "Invalid numeric case ")
                                                                    }
                    catch (UserRegistrationException ex)
                    {
                        Console.WriteLine(ex.result);
                        return false;
                    }

            public bool validateSpecialCharactercase(string name)
            {
                string pattern = @"^(?=.*[A-Z])(?=.*[0-9])(?=.*[@#$%^&-+=()]).{8,}$";
                bool result = Regex.IsMatch(name, pattern);
                return result;
            }

            try

            {
                if (Regex.IsMatch(name, pattern))
                    return true;
                else
                    throw new UserRegistrationException(UserRegistration.ExceptionType.Invalid Name, "Invalid name")
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
            result = program.validatePassword("sanjanaks");
            Console.WriteLine("Password validation result: " + result);
            result = program.validateUppercase("saNjanaks");
            Console.WriteLine("Uppercase validation result: " + result);
            result = program.validateNumericcase("sanjana5ks");
            Console.WriteLine("Numeric case validation result: " + result);
            result = program.validateSpecialCharactercase("sanJana5*Ks");
            Console.WriteLine("Special Character case validation result: " + result);
}

                
}







    