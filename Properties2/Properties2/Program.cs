using System;

namespace Properties2
{

    public class Student
    {
        private int _ID;
        private string _name;
        private int _passMark = 35;
        private string _city;
        private string _email;

        public int ID
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Student ID cannot be negative.");
                }
                this._ID = value;
            }
            get
            {
                return this._ID;
            }
        }

        public string name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be null or empty.");
                }
                this._name = value;
            }
            get
            {
                return string.IsNullOrEmpty(this._name) ? "No name" : this._name;
            }
        }

        public int passMark
        {
            get
            {
                return this._passMark;
            }
        }

        public string City
        {
            set
            {
                this._city = value;
            }
            get
            {
                return this._city;
            }
        }

        public string Email
        {
            set
            {
                this._email = value;
            }
            get
            {
                return this._email;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student C1 = new Student();
            C1.ID = 101;
            C1.name = "Thomas Quinn";
            C1.name = "Caitlin Sewell";
            C1.City = "Christchurch";
            C1.Email = "abcd@efgh.com";

            Console.WriteLine("Student ID: {0}", C1.ID);
            Console.WriteLine("Student Name: {0}", C1.name);
            Console.WriteLine("Pass Mark: {0}", C1.passMark);
            Console.WriteLine("City: {0}", C1.City);
            Console.WriteLine("E-mail: {0}", C1.Email);
            Console.ReadLine();
        }
    }
}

