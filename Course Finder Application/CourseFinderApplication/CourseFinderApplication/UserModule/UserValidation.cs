using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using CourseFinderApplication.UserModule;
using CourseFinderApplication.MenuModule;

//collection of classes
namespace CourseFinderApplication.UserModule
{
    //UserValidation class to collect its behaviour and properties
    class UserValidation
    {
        private User validUser;

        //Validate the user details and add the methods in validateUser method
        public User validateUser(User newUser)
        {
            this.validUser = newUser;
            validateUserName();
            validateUniqueId();
            validatePassword();
            validateMailId();
            return validUser;

        }

        //User name validation
        protected void validateUserName()
        {
            //Exception handling
            try
            {
                if (!validUser.UserName.Contains(" "))
                {
                    Console.Write("\nUser name is valid");
                    //validUser.UserName = userName;
                }
                else
                {
                    //Using throw keyword to throw the exception into the catch
                    throw new Exception();
                }
            }
            //User defined exception
            catch (Exception exceptionAtValidateuserName)
            {
                Console.Write("\nUser Name format mismatch\nEnter a valid User name :");
                validUser.UserName = Console.ReadLine();
                validateUserName();
            }
        }

        //Unique id validation
        protected void validateUniqueId()
        {
            //Exception handling
            //String uniqueId = null;
            try
            {
                if (validUser.UniqueId>100)
                {
                    Console.Write("\nUnique Id is valid");
                }
                else
                {
                    //It throws the exception
                    throw new Exception();
                }
            }
            //User defined exception
            catch (Exception exceptionAtValidateuniqueId)
            {
                Console.Write("\nException while entering unique Id, Check your input\nEnter a valid Unique Id :");
                validUser.UniqueId =Convert.ToInt32(Console.ReadLine());
                validateUniqueId();
            }
        }

        //password validation using regex
        protected void validatePassword()
        {
           // String password = null;

            //using regex method to check the password is match the expression or not
            Regex regex = new Regex("^(?=.*[a-z])(?=.*[0-9])(?=.*[A-Z])(?=.*[@#%$^&+=])(?=\\S+$).{8,}$");

            try
            {
                if (regex.IsMatch(validUser.Password))
                {
                    Console.Write("\nPassword is valid");
                }
                else
                {
                    //It throws the exception
                    throw new Exception();
                }
            }
            //User defined exception
            catch (Exception exceptionAtValidatePassword)
            {
                Console.Write("\nException while entering password, Check your input\nEnter a valid password : ");
                validUser.Password = Console.ReadLine();
                validatePassword();
            }
        }

        //Email validation using regex
        protected void validateMailId()
        {
            //String mailId = null;

            Regex regex = new Regex("^[a-z0-9!#$]@[a-z].[com]$");

            try
            {
                if (!regex.IsMatch(validUser.MailId))
                {
                    Console.Write("\nmailId is valid");
                }
                else
                {
                    //It throws the exception
                    throw new Exception();
                }
            }
            //User defined exception
            catch (Exception exceptionAtValidateMailId)
            {
                Console.Write("\nException while entering mail id, Check your input\nEnter a valid mail Id : ");
                validUser.MailId = Console.ReadLine();
                validateMailId();
            }
        }
    }
}
