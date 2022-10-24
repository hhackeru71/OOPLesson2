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
            //Animals cat1 = new Animals();




            Animals cat1 = new Animals("ewtre", 2);
            Console.WriteLine($"{cat1.Name},{cat1.Age},{cat1.Number}");


            Animals cat2 = new Animals("yarin",30,1);
            Console.WriteLine($"{cat2.Name},{cat2.Age},{cat2.Number}");

            //Animals cat3 = new Animals(cat1);
            Console.WriteLine($"{cat2.Name},{cat2.Age},{cat2.Number}");



            //Console.WriteLine(cat.Age);
            //Animals dog = new Animals();
            //Console.WriteLine(dog.Name);


            //בנאי 
            //constructor
            ////ctor
            //Time time = new Time(1,12);
            //Console.WriteLine($"{time.Hour},{time.Minute}");//1,0
            //Time time1 = new Time(1,2);
            //Console.WriteLine($"{time1.Hour},{time1.Minute}");//1,2
















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