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

            return false;  
        }
    }
}

// minuto 10:40 https://www.youtube.com/watch?v=QKcwvOJexqg&ab_channel=JoseCarlosMacoratti