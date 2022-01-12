using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseFinderApplication.UserModule;
using CourseFinderApplication.MenuModule;
using CourseFinderApplication.CourseModule;

//collection of classes
namespace CourseFinderApplication.MenuModule
{
    //MainMenu class to collect its behaviour and properties
    class MainMenu
    {
        //create the list using user class to store the datas
        static List<User> userList = new List<User>();

        //create the object for userValidation class
        static UserValidation userValidation = new UserValidation();

        //create the object for admin menu and user menu
        AdminMenu adminMenu = new AdminMenu();
        UserMenu userMenu = new UserMenu();

        //create the object for courses class
        Courses courses = new Courses();
      
        ////create the object for UserBO class
        //UserBO userBO = new UserBO();

        ////Home page
        //method
        public void Homepage()
        {
            Console.Write(" ");
            Console.Write("\n\n*************** Welcome to YCDI Learning portal *********************");
            
            //Inside of the home page method - using do while loop 
            do
            {
                Console.Write("\n\nEnter your options: \n");
                Console.Write("Option 1. Register\nOption 2. Login\nOption 3. Exit\n");

                //get the user choice for registration or login using integer data type
                int choiceOfUser = 0;
                choiceOfUser = Convert.ToInt32(Console.ReadLine());

                //switch case
                switch (choiceOfUser)
                {
                    case 1: 
                        //For Registration 
                        Console.Write("\n****************** Welcome to Registration ******************\n");
                       
                        //Register - method(Used to get the user input)
                        register();

                        Console.Write("\n******* Registered Successfully ********");
                        break;
                        
                    case 2: 
                        //For Login
                        Console.Write("****************** Welcome to User login / Admin Login ******************\n");

                        Console.Write("[Admin login - Give the default username & password]\n[User login - Give the registered user name & password]\n");

                        //login - method(Used to get the user input)
                        login();


                        break;

                    case 3:
                        //Exit
                        //Use to end the execution of console application
                        Environment.Exit(0);
                        break;

                    default:
                        break;
                }
            } while (true);
        }


        //Login method
        private void login()
        {
            Console.Write("\nUser Name     : ");
            string userName = Console.ReadLine();
            Console.Write("Password      : ");
            string password = Console.ReadLine();
            foreach (User user in userList)
            {
                //checks the registered user name and login user name is same or not
                if ((userName.Equals("Bavatharani") && password.Equals("@Bava12345")) || (userName.Equals("Bavatharani123") && password.Equals("#Bava67890")))
                {
                    Console.Write("\nWelcome Admin to the YCDI Learning portal...\nSuccessfully Logged In\n");
                    //After login, it go to the admin menu page
                    adminMenu.adminLogin();
                    break;
                }
                //checks the registered user name and login user name is same or not
                else if (userName.Equals(user.UserName) && password.Equals(user.Password))
                {
                    Console.Write("\n\nSuccessfully Logged In\n");

                    do
                    {
                        Console.Write("\nEnter your options : \nPress 1 : User profile\nPress 2 : Available courses\nPress 3 : Exit\n");

                        int options = Convert.ToInt32(Console.ReadLine());

                        switch (options)
                        {

                            case 1:
                                //After user login, it go to the user menu page
                                userMenu.getUserProfile();
                                break;

                            case 2:
                                //After login, it show the courses
                                courses.availableCourses();
                                break;

                            case 3:
                                Environment.Exit(0);
                                break;
                            default:
                                break;
                        }
                        break;
                    } while (true);
                }
            }
        }

        //register method
        private void register()
        {
            //fields
            string  userName, stream, mailId, password;
            int uniqueId;
            DateTime dob;
            long phoneNumber;

            //get the user input
            Console.Write("Unique ID : ");
            uniqueId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Name      : ");
            userName = Console.ReadLine();
            Console.Write("Stream    : ");
            stream = Console.ReadLine();
            Console.Write("Mail ID   : ");
            mailId = Console.ReadLine();
            Console.Write("DOB       : ");
            dob =Convert.ToDateTime(Console.ReadLine());
            Console.Write("Mobile    : ");
            phoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.Write("Password  : ");
            password = Console.ReadLine();

            if(uniqueId!=0 && password != null)
            {
                //create the object for the user class
                User newUser = new User(userName, stream, mailId, password, uniqueId, dob, phoneNumber);
                User validUser = userValidation.validateUser(newUser);
                if (validUser!=null)
                {
                    //Adding the validate user details in the list
                    userList.Add(validUser);
                }
            }
        }
    }
}
