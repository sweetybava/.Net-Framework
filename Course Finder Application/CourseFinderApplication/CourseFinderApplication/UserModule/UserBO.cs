using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using CourseFinderApplication.UserModule;

//collection of classes
namespace CourseFinderApplication.UserModule
{
    //UserBO class to collect its behaviour and properties
    public class UserBO
    {
        //Instance of uservalidation
        UserValidation userValidation = new UserValidation();

        //logical operations
        static List<User> userList = new List<User>();

        User user = new User();
        
       
    }
}
