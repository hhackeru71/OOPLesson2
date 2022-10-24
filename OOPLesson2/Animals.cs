using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLesson2
{
    internal class Animals
    {
        public string Name { get; set; }
        public int Age { get; set; }


        //ליצירת בנאי קיצור דרך 
        //ctor + tab tab 
        public Animals(string name)
        {
            Name = name;
        }

        public Animals(int age)
        {
            Age = age;
        }
    }
}
