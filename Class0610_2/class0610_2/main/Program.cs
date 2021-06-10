using class0610_2.model;
using class0610_2.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class0610_2.main
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] st = new Student[10];
            RandData rands = new RandData();
            
            for(int i=0; i<st.Length; i++)
            {
                st[i] = new Student(rands.getName(), rands.getAge(), rands.getGender(), rands.getAddress());        //배열에 들어갈 랜덤값을 넣어줌
                
            }
            st[9].Name = "전우치";                             //10번째 학생정보 입력
            st[9].Age= 24;
            st[9].Gender = '남';
            st[9].Address = "조선 한양인근 두메산골";
            
            for(int i =0; i<st.Length; i++)
            {
                Console.WriteLine(st[i]);                       // 입력후 다시 한번 for 반복돌려서 총 10개[1-9 랜덤, 10번째 전우치] 값 넣음.
            }
            
        }
    }
}
