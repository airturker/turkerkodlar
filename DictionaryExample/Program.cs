using System;
using System.Collections.Generic;

namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> isimler = new MyDictionary<int, string>();
            isimler.Add(101, "Engin");
            isimler.Add(102, "Kerem");
            isimler.Add(103, "Türker");
            isimler.Add(104, "Selami");

            

        }
    }
}
