using System;
using System.Collections.Generic;

namespace MyDictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1727,"Yusuf KOÇAK");
            myDictionary.Add(1728, "Melike KOÇAK");
            myDictionary.Add(1729, "Mesut KOÇAK");
            myDictionary.Add(1730, "Özlem KOÇAK");
            Console.WriteLine(myDictionary.Count);


        }
    }
}
