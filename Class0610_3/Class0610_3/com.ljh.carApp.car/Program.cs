using Class0610_3.com.ljh.carApp.model;
using Class0610_3.com.ljh.carApp.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class0610_3
{
    class Program
    {
        static void Main(string[] args)
        {
            RandData r = new RandData();
            Customer[] cus = new Customer[10];

            for(int i=0; i < cus.Length; i++)
            { 
                cus[i] = new Customer(r.getName(), r.getTel(), r.getAddress(), new Car( r.getColor(), r.getYear(), r.getCompany(),r.getModel()));
                cus[i].printCustomerInfo();
            }
        }
    }
}
