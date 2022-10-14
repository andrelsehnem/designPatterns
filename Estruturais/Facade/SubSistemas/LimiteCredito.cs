namespace designPatterns.Facade{
    public class LimiteCredito{
        public bool PossuiLimite(Cliente cliente, double valor){
            Console.WriteLine($"Verificando o limite de R$ {valor} para o cliente {cliente.nome}");
            if (valor > 10000){
                Console.WriteLine($"Não liberado crédito");
                return false;
            }
            Console.WriteLine($"Liberação de crédito: Ok");
            return true;
        }
    }
}