/*
Title       : Course Finder Application
Author      : BAVATHARANI P
Created at  : 31/Dec/2021
Reviewed by : AKSHAYA 
Updated at  : 11/Jan/2022
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseFinderApplication.MenuModule;
using CourseFinderApplication.UserModule;

//Collection of classess
namespace CourseFinderApplication
{
    //Main class
    class CourseFinder
    {
        //Main method
        public static void Main(string[] args)
        {
            //create the object for main menu
            MainMenu mainMenu = new MainMenu();
           
            //homepage method calling
            mainMenu.Homepage();

        }
    }
}
