
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseFinderApplication.UserModule;

//collection of classes
namespace CourseFinderApplication.UserModule
{
    //User class to collect its behaviour and properties
    public class User
    {
        //fields
        //Declaring different data types
        private string userName, stream, mailId, password;
        private int uniqueId;
        private DateTime dob;
        private long phoneNumber;


        //Default constructor
        public User()
        {

        }

        //Parameterized constructor
        public User(string userName, string stream, string mailId, string password, int uniqueId, DateTime dob, long phoneNumber)
        {
            this.UserName = userName;
            this.Stream = stream;
            this.MailId = mailId;
            this.Password = password;
            this.UniqueId = uniqueId;
            this.Dob = dob;
            this.PhoneNumber = phoneNumber;
        }

        public string UserName { get => userName; set => userName = value; }
        public string Stream { get => stream; set => stream = value; }
        public string MailId { get => mailId; set => mailId = value; }
        public string Password { get => password; set => password = value; }
        public int UniqueId { get => uniqueId; set => uniqueId = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public long PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        //Compare to object based on Equals method
        public override bool Equals(object obj)
        {
            User tempUser = obj as User;
            return this.MailId.Equals(tempUser.MailId);
        }

        //
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        //Override the different data type values into string
        public override string ToString()
        {
            return string.Format(this.UniqueId + " " + this.UserName + " " + this.Stream + " " + this.MailId + " " + this.Password
                + " " + this.Dob + " " + this.PhoneNumber);
        }
    }
}
