using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace OOPLesson2
{
    internal class Car
    {
        //field
        private string _brand;
        private string _carNumber;
        private int _year;

        //prop
        public string Brand
        {

            get { return _brand; }
            set { _brand = value; }
        }

        public string CarNumber
        {
            get { return _carNumber; }
            set { _carNumber = value; }
        }

        public int Year
        {
            get { return _year; }
            set
            {
                if (value < 1991)
                    return;
                _year = value;
            }
        }

        public void PrintBrand()
        {
            Console.WriteLine(_brand);
        }

        public void PrintCarNumber()
        {
            Console.WriteLine(_carNumber);
        }

        public void PrinYear()
        {
            Console.WriteLine(_year);
        }


    }
}
