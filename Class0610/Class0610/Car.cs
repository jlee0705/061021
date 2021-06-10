using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class0610     //namespace = 자바 패키지
{
    class Car
    {
        //클래스 변수
        public const string JIJUM = "동대구 영업소";

        //인스턴스 변수
        private string company;
        private string color;
        private string model;
        private string price;

        public Car()            //특수한 method
        {
            company = "기아";
            color = "블랙";
            model = "K7";
            price = "4천만원";
        }

        public Car(string company, string color, string model, string price)
        {
            this.company = company;         //인스턴수 변수인것.
            this.color = color;
            this.model = model;
            this.price = price;
        }

        public void printCarInfo()
        {
            Console.WriteLine("제조사 : " + company);
            Console.WriteLine("색상 : " + color);
            Console.WriteLine("모델 : " + model);
            Console.WriteLine("가격 : " + price);
        }

        public void setModel(string model)
        {
            this.model = model;
        }

        public void setPrice(string price)
        {
            this.price= price;
        }

        public string getModel()
        {
            return model;
        }
        public string getPrice()
        {
            return price;
        }


    }
}
//카멜, 파스칼, 스네이크 = 소문자 대문자, 대문자 대문자, 문자 + 언더바