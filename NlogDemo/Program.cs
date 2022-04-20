using NLog;
using System;
using NlogDemo;
namespace NlogDemo
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("welcome to nlog!");
            AddNumber add = new AddNumber();
            add.Sum(1, 2);
    
    }
    }
}