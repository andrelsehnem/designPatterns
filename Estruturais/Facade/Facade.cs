namespace designPatterns.Facade{
    public class Facade{
        private Cliente cliente;
        private double valor;
        private MeuFacade concedeCredito;
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
            concedeCredito = new();
            Console.WriteLine("Digite o nome do cliente");
            string nome = Console.ReadLine();
            cliente = new(nome);
            Console.WriteLine("Digite o valor de crédito a solicitar");
            valor = Convert.ToDouble(Console.ReadLine());   
            Console.Clear();
            Console.WriteLine("Empréstimos Facade");
            Console.WriteLine($"Liberação de crédito para o cliente {cliente.nome}");
            Console.WriteLine($"Total solicitado: R$ {valor}");
            Console.WriteLine("\n \n");
            if(concedeCredito.ConcederEmprestimo(cliente, valor)){
                Console.WriteLine("Crédito concedido!!");
            }
            else Console.WriteLine("Crédito negado!!");
            Console.WriteLine("\n \n");
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