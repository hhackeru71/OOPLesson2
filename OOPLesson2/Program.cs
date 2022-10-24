using OOPLesson2;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "yarin";
            person.Age = 40;
            //Console.WriteLine($"{person.Age}");//0

            //HW
            Car car = new Car
            {
                Brand = "TOYOTA",
                CarNumber = "123456",
                Year = 1991
            };

            Car car2 = new Car
            {
                Brand = "SUBARU",
                CarNumber = "123456",
                Year = 1980
            };


            car.PrinYear();
            car.PrintBrand();
            car.PrintCarNumber();

            car2.PrinYear();
            car2.PrintBrand();
            car2.PrintCarNumber();

            //
            Person person2 = new Person
            {
                Age = 30,
                Name = "yarin"
            };

            


            //person.Age = 30;
            //person.Print();
            //Console.WriteLine(person.Age);
            //int.TryParse(Console.ReadLine(), out int num1 );
            //person.name = "yarin";
            //person.age = num1;
            //person.Print();

            //Person person2= new Person();
            //person2.age = 60;
            //person2.name = "yoav";
            //person2.Print();


        }
    }
}