namespace designPatterns.Facade{
    public class Serasa{
        public bool EstaNoSerasa(Cliente cliente){
            Console.WriteLine($"Verificando o SERASA para o cliente {cliente.nome}");
            if (Facade.Randomize() == 1){
                Console.WriteLine($"Esta no SERASA");
                return true;
            }
            return false;
        }
    }
}