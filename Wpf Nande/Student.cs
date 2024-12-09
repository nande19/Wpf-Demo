using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Nande
{
    public class Student
    {

        private string username;

        private string fullname;
       // private string surname;
        private string password;
        private string address;

        public string Username { get => username; set => username = value; }
        public string Fullname { get => fullname; set => fullname = value; }
       // public string Surname { get => surname; set => surname = value; }
        public string Password { get => password; set => password = value; }
        public string Address { get => address; set => address = value; }

        public Student()
        {

        }

        public Student(string username, string fullname, string password, string address)
        {
            this.username = username;
            this.fullname = fullname;
           // this.surname = surname;
            this.password = password;
            this.address = address;
        }
    }
 }
