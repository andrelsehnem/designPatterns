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
                    callMenuCriacionais();
                    break;
                case "2":
                    Console.Clear();
                    callMenuEstruturais();
                    break;
                case "3":
                    Console.Clear();
                    callMenuComportamentais();
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

        public void callMenuCriacionais()
        {
            Console.WriteLine("1- Criacionais");
            Console.WriteLine("1- Singleton");
            Console.WriteLine("2- Prototype");
            Console.WriteLine("3- Factory Method");
        }

        public void callMenuEstruturais()
        {
            Console.WriteLine("2- Estruturais");
            Console.WriteLine("1- ");
            Console.WriteLine("2- ");
            Console.WriteLine("3- ");
        }

        public void callMenuComportamentais()
        {
            Console.WriteLine("3- Comportamentais");
            Console.WriteLine("1- ");
            Console.WriteLine("2- ");
            Console.WriteLine("3- ");
        }
    }
}