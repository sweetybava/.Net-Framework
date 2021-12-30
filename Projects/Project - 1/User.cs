using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project01
{
    class User
    {

        //fields
        private string username;
        private string mailid;
        private string password;

        //default constructor
        public User()
        {

        }

        //
        public User(string username, string mailid, string password)
        {
            this.username = username;
            this.mailid = mailid;
            this.password = password;
        }

        //properties
        public string Username { get => username; set => username = value; }
        public string Mailid { get => mailid; set => mailid = value; }
        public string Password { get => password; set => password = value; }

       
        public override string ToString()
        {
            return String.Format("Username: {0}\nMail Id: {1}\nPassword: {2}",Username,Mailid,Password);
        }

        //Equals method
        public override bool Equals(object obj)
        {
            User obj_user = (User)obj;
            return this.username.Equals(obj_user.username);
            //  return base.Equals(obj);
        }


        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
