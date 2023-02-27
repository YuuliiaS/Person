using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class Program
    {
        public class Person
        {
            private string fullName = "";
            private int age;
            public Person()
            {
                fullName = " Такой-то Person";
                age = 0;
            }
            public Person(int a, string s)
            {
                fullName = s;
                age = a;
            }
            public void move()
            {
                Console.Write(fullName);
                Console.Write(" двигается");
            }
            public void talk()
            {
                Console.Write(fullName);
                Console.Write(" говорит ");
            }
        }

        static void Main(string[] args)
        {
            Person firstPerson = new Person();
            Person secondPerson = new Person(18, " Виктория");
            firstPerson.move();
            firstPerson.talk();
            secondPerson.move();
            secondPerson.talk();
        }
    }
}
