using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseFinderApplication.MenuModule;
using CourseFinderApplication.UserModule;

//Collection of classes
namespace CourseFinderApplication.MenuModule
{
    //Admin class to collect its behaviour and properties
    public class AdminMenu
    {
        //List
        List<string> courseList = new List<string>();
        List<string> addCoursesList = new List<string>();

        //available course
        
        public void adminLogin()
        {
            // Admin Menu
            do
            {
                Console.WriteLine("\nEnter your options: \nOption 1 -> Add \nOption 2 -> Edit \nOption 3 -> Delete\nOption 4 -> Exit\n");

                int searchType = Convert.ToInt32(Console.ReadLine());
                switch (searchType)
                {
                    case 1:
                        addCourses();
                        break;
                    case 2:
                        editCourses();
                        break;
                    case 3:
                        deleteCourses();
                        break;
                    case 4:
                        //Exit
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine(" ");
                        break;
                }
            } while (true);
        }

        //add the course
        public void addCourses()
        {

            Console.WriteLine("Do you want Add the course in available courses? Press yes or no");
            string choice = Console.ReadLine();
            if (choice.Equals("yes"))
            {
                Console.Write("Type the course name to add available Courses");
                string courseName = Console.ReadLine();
                foreach (string course in courseList)
                {
                    if (courseList.Equals(courseName))
                    {
                        addCoursesList.Add(course);
                        Console.WriteLine("\nYour course added successfully!");
                    }
                }
            }
            Console.ReadLine();
        }

        //Update the course
        public void editCourses()
        {
            Console.Write("\nEdit the courses");
            Console.Write("\nEnter the admin name : \n[Admin name should match the register admin name]\n");
            string adminname = Console.ReadLine();
            if (adminname.Equals(adminname = "Bavatharani"))
            {
                Console.Write("\nAdmin Name is matched...");

                Console.Write("\nEnter the course name: \n");
                string newCourse = Console.ReadLine();

                Console.WriteLine("\nCourse Edited Successfully");
            }
            Console.ReadLine();
        }

        //remove the course
        public void deleteCourses()
        {
            Console.WriteLine("\nDeleted Successfully");
            Console.ReadLine();
        }
    }
}
