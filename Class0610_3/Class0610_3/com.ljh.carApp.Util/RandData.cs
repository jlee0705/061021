using Class0610_3.com.ljh.carApp.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class0610_3.com.ljh.carApp.Util
{
    class RandData
    {
        static string[] name = { "홍길동", "김길동", "박길동", "이길동", "최길동" };
        static string[] tel = { "010-1234-5678", "010-4321-5678", "010-3478-1278", "010-4523-1978", "010-7890-2134" };
        static string[] address = { "대구시 동구 신암4동", "서울시 동구 신암4동", "부산시 동구 신암4동", "인천시 동구 신암4동", "광주시 동구 신암4동" };
        static string[] model = { "G바겐", "RS8", "M5 F90", "Cullinan", "Bentayga" };
        static string[] color = { "Red", "Beige", "Milk Cream", "SkyBlue", "Silver" };
        static int[] year = { 2017, 2018, 2019, 2020, 2021 };
        static string[] company = { "Mercedes Benz", "Audi", "BMW", "Rolls Royce", "Bentley" };

        Customer[] cs = new Customer[10];
        Random r = new Random();

        public string getName()
        {
            return name[r.Next(0, 5)];
        }

        public string getTel()
        {
            return tel[r.Next(0, 5)];
        }

        public string getAddress()
        {
            return address[r.Next(0, 5)];
        }

        public string getModel()
        {
            return model[r.Next(0, 5)];
        }

        public string getColor()
        {
            return color[r.Next(0, 5)];
        }

        public int getYear()
        {
            return year[r.Next(0, 5)];
        }

        public string getCompany()
        {
            return company[r.Next(0, 5)];
        }
    }
}
