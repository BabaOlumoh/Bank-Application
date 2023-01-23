using System;
using System.Diagnostics;
using System.Drawing;

namespace Bank_Application
{
	public class Person
	{
        private string name { get; set; }
		private string surname { get; set; }
        private int yearOfBirth { get; set; }
        private string address { get; set; }

        public Person(string name, string surname, int yearOfBirth, string address)
        {
            this.name = name;
            this.surname = surname;
            this.yearOfBirth = yearOfBirth;
            this.address = address;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Full name: {name} {surname} ");
            Console.WriteLine();
            Console.WriteLine("Year of Birth: " + yearOfBirth);
            Console.WriteLine();
            Console.WriteLine("Adress: " + address);
            Console.WriteLine();
        }
    }
}

