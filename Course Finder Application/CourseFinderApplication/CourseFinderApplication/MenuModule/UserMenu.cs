using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseFinderApplication.UserModule;
using CourseFinderApplication.MenuModule;
using CourseFinderApplication.CourseModule;

//Collection of classes
namespace CourseFinderApplication.MenuModule
{
    //User menu class to collect its behaviour and properties
    public class UserMenu
    {
        string feedback;
        int option;

        Courses courses = new Courses();

        //my courses - view the course
        //leaderboard based on the courses are present in the my courses
        public void getUserProfile()
        {
            // User Menu
            do
            {
                Console.WriteLine("\nEnter your options: \nOption 1 -> Display the courses\nOption 2 -> View Profile \nOption 3 -> Edit \nOption 4 -> Delete\nOption 5 -> Feedback\nOption 6 -> Exit\n");

                int noOfchoice = Convert.ToInt32(Console.ReadLine());
                switch (noOfchoice)
                {
                    case 1:
                        courses.availableCourses();
                        break;
                    case 2:
                        viewProfile();
                        break;
                    case 3:
                        editProfile();
                        break;
                    case 4:
                        deleteProfile();
                        break;
                    case 5:
                        userFeedback();
                        break;
                    case 6:
                        //Exit
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            } while (true);

        }

        public void viewProfile()
        {
            Console.Write("Profile viewing....");

        }

        void editProfile()
        {
            Console.Write("\nEdit the profile");
            Console.Write("\nEnter the user mail ID : \n[Mail id should match the register mail id]\n");
            string mailID = Console.ReadLine();
            if(mailID.Equals(mailID = "bava@gmail.com"))
            {
                Console.Write("\nEmail is matches the existing account...");
                Console.Write("Enter your options: \nPress 1 -> Edit mobile number\nPress 2 -> Edit Stream\nPress 3 -> Exit\n");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Write("\nEdit your mobile number: ");

                        long mobileNumber = Convert.ToInt64(Console.ReadLine());

                        Console.Write("\nYour mobile number is changed successfully");

                        break;
                    case 2:
                        Console.Write("\nEdit your stream: ");

                        string stream = Console.ReadLine();

                        Console.Write("\nYour stream is changed successfully");

                        break;
                    case 3:
                        //Exit
                        getUserProfile();
                        break;
                    default:
                        break;
                }

            }
            else
            {
                Console.Write("\nEmail is not matches the existing account...");
            }
        }

        void deleteProfile()
        {
            Console.Write("\nProfile deleted successfully....\nThank you choosing the YCDI Learning portal");
        }

        void userFeedback()
        {
            Console.Write("\n******************** Thank you for using the YCDI Learning portal ********************" +
                "\n Share your valuable feedback......");

            Console.Write("\nEnter your options: \nPress 1 : Share Feedback\nPress 2 : View Feedback\nPress 3 : Exit\n");

            option = Convert.ToInt32(Console.ReadLine());

            switch (option) {
                case 1:
                    Console.Write("\nShare your feedback : \n[Below 100 characters]\n");
                    feedback = Console.ReadLine();

                    Console.Write("\n*************** Feedback added successfully ****************");
                    break;
                case 2:
                    Console.WriteLine("Feedback : " + feedback);
                    break;
                case 3:
                    //mainMenu.Homepage();
                    break;

            }
            

            Console.Write("\n________________ Thanks for your Feedback ___________________\n");

        }
    }
}
