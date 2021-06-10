using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class0610_3.com.ljh.carApp.model
{
    class Car
    {
       private string color;
       private int year;
       private string company;
       private string model;


        public Car(string color, int year, string company, string model)
        {
            this.color = color;
            this.year = year;
            this.company = company;
            this.model = model;
        }

        public string Color { get => color; set => color = value; }
        public int Year { get => year; set => year = value; }
        public string Company { get => company; set => company = value; }

        public void printCarInfo()
        {
            Console.WriteLine("색상 : " + color);
            Console.WriteLine("연식 : " + year);
            Console.WriteLine("회사 : " + company);
            Console.WriteLine("모델 : " + model);
            Console.WriteLine("=================");
        }

    }



}
