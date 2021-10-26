using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {

            Customlist<string> list = new Customlist<string>();
            list.Add("11");
            list[1] = "abc";
            list.Clear();
            list.IndexOf("11");
            list.LastIndexOf("11");
            list.Remove("11");
            Console.ReadLine();
        }

    }
}
