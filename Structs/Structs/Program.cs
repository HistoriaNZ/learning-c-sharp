using System;

namespace Structs
{
    public struct Customer
    {
        private int _id;
        private string _name;

        public int ID
        {
            get { return this._id; }
            set { this._id = value; }
        }

        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        public Customer(int Id, string name)
        {
            this._id = Id;
            this._name = name;
        }

        public void PrintDetails()
        {
            Console.WriteLine("ID: {0} \nName: {1}", this._id, this._name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer(505, "Mark Bell");
            C1.PrintDetails();
            //Object Initializer Syntax
            Customer C3 = new Customer
            {
                ID = 101,
                Name = "Mary Jones"
            };
            Console.ReadLine();
        }
    }
}
