using designPatterns;

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
            bool a2 = true;
            while(a2){
                Console.WriteLine("1- Singleton");
                Console.WriteLine("2- Prototype");
                Console.WriteLine("3- Factory Method");
                switch (Console.ReadLine()){
                case "1":
                    Console.Clear();
                    Singleton s = new();
                    s.inicio();
                    break;
                case "2":
                    Console.Clear();
                    Prototype p = new();
                    p.inicio();
                    break;
                case "3":
                    Console.Clear();
                    break;
                case "x":
                    a2 = false;
                    break;
                default:
                    Console.Clear();
                    break;
                }
            }
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