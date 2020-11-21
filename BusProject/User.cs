using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusProject
{
    class User
    {
        static public int userID = 0;
        public double userCredit { set; get; }
        enum userType { 0:elders,1:youth,2:kids under 5}


        public string userName { set; get; }
        int userAge { set; get; }
        string usreContact { set; get; }


        public User(string name, int age, string contact)
        {

            if (age < 5)
                userType = 2;
            else if (age > 60)
                userType = 0;
            else userType = 1;
            this.userName = name;
            this.usreContact = contact;
        }
        public User()
        {
            if (this.userAge < 5)
                userType = 2;
            else if (this.userAge > 60)
                userType = 0;
            else userType = 1;
        }
        public static User register(string name, int age, string contact)
        {
            User c;
            c.userAge = age;

            c.userName = name;
            c.usreContact = contact;

            return c;
        }


    }
}
