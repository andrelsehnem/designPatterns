namespace designPatterns.Facade{
    public class Facade{
        
        public void Inicio(){
            Console.Clear();
            bool b = true;
            while(b){
                Console.WriteLine(" --   --   -- ");
                Console.WriteLine(" -- Facade -- ");
                Console.WriteLine(" --   --   -- ");
                b = Menu();
            }
        }

         private bool Menu(){
            Console.WriteLine("Digite o nome do cliente");

            Console.WriteLine("Digite o valor de crédito a solicitar");

            Console.WriteLine("Realizar nova consulta?");
            Console.WriteLine("S = SIM");
            if (Console.ReadLine() == "s"){
                return true;
            }
            else{
                return false;
            }
         }



        public static int Randomize(){
            var random = new Random();
            random.Next();
            int b = random.Next(2);
            return b;
        }
    }
}