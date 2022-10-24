using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLesson2
{
    internal class Person
    {
        //field
        private int age;
        private string name;

        //properties
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 30)
                    return;
                age = value;

            }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void Print()
        {
            Console.WriteLine($"{age},{name}");
        }

    }
}
