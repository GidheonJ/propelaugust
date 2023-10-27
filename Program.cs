using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //staticmembers obj1 = new staticmembers();
            //staticmembers obj2 = new staticmembers();
            // obj1.count();
            //// obj1.count();
            // obj2.count();
            // obj2.count();
            // Console.WriteLine("num for obj1 " + obj1.getnum());
            // Console.WriteLine("num for obj2 " + obj2.getnum());
            //obj1.count();
            //obj2.count();
            //Console.WriteLine(obj1.num2);//instance var
            //Console.WriteLine(staticmembers.num);//const var

            //Console.WriteLine(staticmembers.num1);//static var

            //read only variable
            staticmembers obj = new staticmembers(20);
            // Console.WriteLine(staticmembers.num);//error because it is not static(static cannot access by classname)
            Console.WriteLine(obj.num);
            staticmembers obj1 = new staticmembers(10);
            Console.WriteLine(obj1.num);


            Console.ReadKey();
        }
       
    }
}
