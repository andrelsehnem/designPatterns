namespace designPatterns.Facade{
    public class Cadastro{
        public void CadastrarCliente(Cliente cliente){
            Console.WriteLine($"Cadastro do cliente {cliente.nome} concluído");
        }
    }
}