using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CarAppMike
{
    public class Car
    {
        public string Brand { get; set; }
        public string model { get; set; }
        public int Year { get; set; }
        public string color { get; set; }

        //konstruktør
        public Car(string brand, string model, int year, string color)
        {
            Brand = brand;
            this.model = model;
            Year = year;
            this.color = color;
        }


    }
}
