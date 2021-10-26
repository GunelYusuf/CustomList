using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {

            MyList<string> list = new MyList<string>();
            list.Add("Gunell1");
            list.Add("Sabinaa2");
            list.Add("Emill3");
            list.Add("Elcinn4");
            list.Add("Rauff5");
            list.Add("Aysenn6");
            List<int> aa = new List<int>();
       
            //aa.Add(2);
            //aa.Add(3);
            //aa.Add(4);
          
            //Console.WriteLine(list[0]);
            //Console.WriteLine(list[1]);
            //Console.WriteLine(list[2]);
            //Console.WriteLine(list[3]);
            //Console.WriteLine(list[4]);
            //Console.WriteLine(list[5]);
            
            //Console.WriteLine(list.Remove("Sabinaa2"));
            Console.WriteLine(list.Count);
        }
    }
}
