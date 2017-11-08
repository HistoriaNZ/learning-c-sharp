using System;

namespace Properties
{

    public class Student
    {
        private int _ID;
        private string _name;
        private int _passMark = 35;

        public void setID(int id)
        {
            if (id <= 0)
            {
                throw new Exception("Student ID cannot be negative.");
            }
            this._ID = id;
        }

        public int getID()
        {
            return this._ID;
        }

        public void setName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("Name cannot be null or empty.");
            }
            this._name = name;
        }

        public string getName()
        {
            if (string.IsNullOrEmpty(this._name))
            {
                return "No Name";
            }
            else
            {
                return this._name;
            }
        }

        public int getPassMark()
        {
            return this._passMark;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student C1 = new Student();
            C1.setID(101);
            C1.setName("Thomas Quinn");
            C1.setName("Caitlin Sewell");

            Console.WriteLine("Student ID: {0}", C1.getID());
            Console.WriteLine("Student Name: {0}", C1.getName());
            Console.WriteLine("Pass Mark: {0}", C1.getPassMark());
            Console.ReadLine();
        }
    }
}
