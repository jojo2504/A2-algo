using System;

namespace ConsoleApplication1
{
    public class Person
    {
        private string firstname;
        private string lastname;
        private DateTime birthdate;
        private char sex;
        private string address;
        private string phone;

        public Person(string firstname, string lastname, DateTime birthdate, char sex, string address, string phone)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.birthdate = birthdate;
            this.sex = sex;
            this.address = address;
            this.phone = phone;
        }

        public int Age()
        {
            return DateTime.Now.Year - this.birthdate.Year;
        }

        public string Conctact()
        {
            return string.Format("Address : {0} \nPhone : {1}", address, phone);
        }
    }
}