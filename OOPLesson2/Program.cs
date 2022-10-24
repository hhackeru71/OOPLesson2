using OOPLesson2;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //משימה להגדיר מחלקה של בעלי חיים
            //להגדיר prop  לפי הקיצור דרך
            //שם החיה
            //גיל החיה

            //ליצור בנאי ראשון שמקבל את שם החיה ושם את הערך ב prop המתאים
            //ליצור בנאי שני שמקבל את גיל החיה ושם את הערך ב prop המתאים 

           // לאחר מכן להדפיס את שם החיה ואת הגיל של החיה 



            //בנאי 
            //constructor
            //ctor
            Time time = new Time();
            Console.WriteLine($"{time.Hour},{time.Minute}");//1,0
            Time time1 = new Time(1,2);
            Console.WriteLine($"{time1.Hour},{time1.Minute}");//1,2
















            //Person person = new Person
            //person.Print();
            //person.Name = "yarin";
            //person.Age = 40;
            ////Console.WriteLine($"{person.Age}");//0

            ////HW
            //Car car = new Car
            //{

            //};

            //Car car2 = new Car
            //{
            //    Brand = "SUBARU",
            //    CarNumber = "123456",
            //    Year = 1980
            //};


            //car.PrinYear();
            //car.PrintBrand();
            //car.PrintCarNumber();

            //car2.PrinYear();
            //car2.PrintBrand();
            //car2.PrintCarNumber();

            ////
            //Person person2 = new Person
            //{
            //    Age = 30,
            //    Name = "yarin"
            //};




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