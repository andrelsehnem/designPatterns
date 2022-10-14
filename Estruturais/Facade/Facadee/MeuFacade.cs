namespace designPatterns.Facade{
    public class MeuFacade{
        private LimiteCredito limite;
        private Serasa serasa;
        private Cadin cadin;
        private Cadastro cadastro;

        public MeuFacade(){
            limite = new();
            serasa = new();
            cadin = new();
            cadastro = new();
        }

        public bool ConcederEmprestimo(Cliente cliente, double valor){
            Console.WriteLine($"Verificando condições para liberação de empréstimo para o cliente {cliente.nome}");

            bool ConcederEmprestimo = true;

            if (serasa.EstaNoSerasa(cliente)){
                ConcederEmprestimo = false;
            }

            if (cadin.EstaNoCadin(cliente)){
                ConcederEmprestimo = false;
            }

            if (!limite.PossuiLimite(cliente, valor)){
                ConcederEmprestimo = false;
            }

            return ConcederEmprestimo;  
        }
    }
}

// minuto 10:40 https://www.youtube.com/watch?v=QKcwvOJexqg&ab_channel=JoseCarlosMacoratti