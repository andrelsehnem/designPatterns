namespace designPatterns.Strategy{
    class Strategy{
        private string control;
        private ConexaoContext cnx = new(new ConexaoMySql());
        public void Inicio(){
            Console.Clear();
            bool b = true;
            while(b){
                Console.WriteLine(" --   ---    -- ");
                Console.WriteLine(" -- Strategy -- ");
                Console.WriteLine(" --   ---    -- ");
                Console.WriteLine("Conexão para bancos");
                b = Menu();
            }
        }

         private bool Menu(){
            string banco = "";
            Console.WriteLine("Digite o nome do banco");
            banco = Console.ReadLine();
            Console.WriteLine("Escolha como conectar:");
            Console.WriteLine("1- MySql (Padrão)");
            Console.WriteLine("2- Firebird");
            Console.WriteLine("3- SQL Server");
            Console.WriteLine("x  Retornar");
            control = Console.ReadLine();
            switch (control){
                case "1":
                    Console.Clear();
                    ConectaMy(banco);
                    break;
                case "2":
                    Console.Clear();
                    ConectaFB(banco);
                    break;
                case "3":
                    Console.Clear();
                    ConectaSQ(banco);
                    break;
                case "x":
                    return false;
            }
            cnx.CriarConexao(banco);

            return true;
        }

        private void ConectaMy(string banco){
            cnx.DefineStrategy(new ConexaoMySql());
        }
        
        private void ConectaFB(string banco){
            cnx.DefineStrategy(new ConexaoFirebird());
        }

        private void ConectaSQ(string banco){
            cnx.DefineStrategy(new ConexaoSQLServer());
        }
    }
}