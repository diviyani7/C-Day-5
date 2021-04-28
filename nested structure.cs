using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_5
{
    class class5
    {
        public struct employee
        {
            public string empName;
            public int empno;

        }
        public struct empdetail
        {
            public double empsalary;
            public string empdept;
            
        }

        static void Main(string[] args)
        {
            int total;
            Console.WriteLine("enter the number of employee:");
            total = Convert.ToInt32(Console.ReadLine());
            employee[] emp = new employee[total];
            for (int i = 0; i < total; i++)
            {
                Console.WriteLine("employee name:");
                string e = Console.ReadLine();
                emp[i].empName = e;
                Console.WriteLine("employee number:");
                int a =Convert.ToInt32(Console.ReadLine());
                emp[i].empno= a;
                Console.WriteLine("employee empsalary:");
                double b = Convert.ToDouble(Console.ReadLine());
               // emp[i].empsalary = b;
                //Console.WriteLine("employee empdept:");
                //string c = Convert.ToString(Console.ReadLine()); 
                //emp[i].empdept = c;

            }
        }


    }
}