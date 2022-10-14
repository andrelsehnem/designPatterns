namespace designPatterns.Facade{
    public class Cadin{
        public bool EstaNoCadin(Cliente cliente){
            Console.WriteLine($"Verificando o CADIN para o cliente {cliente.nome}");
            if (Facade.Randomize() == 1){
                Console.WriteLine($"Esta no CADIN");
                return true;
            }
            Console.WriteLine($"Liberação CADIN: Ok");
            return false;
        }
    }
}
