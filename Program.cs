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
            Console.Clear();
            bool a = true;
            while(a){
                callMenu();
                switch (Console.ReadLine()){
                case "1":
                    Console.Clear();
                    Console.WriteLine("a");
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("b");
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("c");
                    break;
                case "x":
                    a = false;
                    break;
                default:
                    Console.Clear();
                    break;
                }
            }
            Console.WriteLine("fim");
        } 


        public void callMenu(){
            Console.WriteLine("1- Criacionais");
            Console.WriteLine("2- Estruturais");
            Console.WriteLine("3- Comportamentais");
        }
    }
}