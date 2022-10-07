using designPatterns.Factory;
using designPatterns.Prototype;

namespace designPatterns 
{
    public class Program
    {
        bool a2 = true;
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
            Console.WriteLine("x- Encerrar");
        }
        public void callMenuCriacionais()
        {
            a2 = true;
            while(a2){
                Console.WriteLine("--------------");
                Console.WriteLine("1- Criacionais");
                Console.WriteLine("--------------");
                Console.WriteLine("1- Singleton");
                Console.WriteLine("2- Prototype");
                Console.WriteLine("3- Factory Method");
                Console.WriteLine("x- Retornar");
                switch (Console.ReadLine()){
                case "1":
                    Console.Clear();
                    Singleton s = new();
                    s.inicio();
                    break;
                case "2":
                    Console.Clear();
                    Prototype.Prototype p = new();
                    p.inicio();
                    break;
                case "3":
                    Console.Clear();
                    Factory.Factory f = new();
                    f.inicio();
                    break;
                case "x":
                    a2 = false;
                    Console.Clear();
                    break;
                default:
                    Console.Clear();
                    break;
                }
            }
        }

        public void callMenuEstruturais()
        {
            a2 = true;
            while(a2){
                Console.WriteLine("--------------");
                Console.WriteLine("2- Estruturais");
                Console.WriteLine("--------------");
                Console.WriteLine("1- Adapter");
                Console.WriteLine("2- Bridge");
                Console.WriteLine("3- Composite");
                Console.WriteLine("x- Retornar");
                switch (Console.ReadLine()){
                case "1":
                    Console.Clear();
                    break;
                case "2":
                    Console.Clear();
                    break;
                case "3":
                    Console.Clear();
                    break;
                case "x":
                    a2 = false;
                    Console.Clear();
                    break;
                default:
                    Console.Clear();
                    break;
                }
            }
        }

        public void callMenuComportamentais()
        {
            a2 = true;
            while(a2){
                Console.WriteLine("------------------");
                Console.WriteLine("3- Comportamentais");
                Console.WriteLine("------------------");
                Console.WriteLine("1- Chain of Responsibility");
                Console.WriteLine("2- Memento");
                Console.WriteLine("3- Strategy");
                Console.WriteLine("x- Retornar");
                switch (Console.ReadLine()){
                case "1":
                    Console.Clear();
                    ChainOfResponsability.Chain c = new();
                    c.inicio();
                    break;
                case "2":
                    Console.Clear();
                    Memento.Memento m = new();
                    break;
                case "3":
                    Console.Clear();
                    break;
                case "x":
                    a2 = false;
                    Console.Clear();
                    break;
                default:
                    Console.Clear();
                    break;
                }
            }
        }
    }
}