﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class0610_2.util
{
    class RandData
    {
        static string[] name = { "홍길동", "김길동", "박길동", "이길동", "최길동" };
        static int[] age = { 20, 25, 30, 35, 40 };
        static char[] gender = { 'M', 'F' };
        static string[] address = { "대구시 동구 신암4동", "서울시 동구 신암4동", "부산시 동구 신암4동", "인천시 동구 신암4동", "광주시 동구 신암4동" };

        Random r = new Random();

        public string getName()
        {
            return name[r.Next(0, 5)];
        }

        public int getAge()
        {
            return age[r.Next(0, 5)];
        }

        public char getGender()
        {
            return gender[r.Next(0, 2)];
        }

        public string getAddress()
        {
            return address[r.Next(0, 5)];
        }
    }
}
