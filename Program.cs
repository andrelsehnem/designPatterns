using System;
using static System.Console;
using static System.Convert;

namespace designPatterns 
{
    public class Program
    {
        public static void Main()
        {
            
            new Program();
        }

        public Program(){
            Console.WriteLine("1- Criacionais");
            Console.WriteLine("2- Estruturais");
            Console.WriteLine("3- Comportamentais");
            bool a = true;
            while(a){
                switch (Console.ReadLine()){
                case "1":
                    Console.WriteLine("a");
                    break;
                case "2":
                    Console.WriteLine("b");
                    break;
                case "3":
                    Console.WriteLine("c");
                    break;
                default:
                    new Program();
                    break;
                }
            }
            Console.WriteLine("fim");
        } 
    }
}