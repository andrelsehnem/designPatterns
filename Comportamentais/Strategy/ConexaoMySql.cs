namespace designPatterns.Strategy{
    
    public class ConexaoMySql : IConexao{
        
        public void ConectarBanco(string stringConexao){ 
            Console.WriteLine("Iniciando conexão MySql");
            Console.WriteLine("DRIVER={MySQL ODBC 8.0 Driver};SERVER=localhost;dATABASE=" + stringConexao + ";USER=venu;PASSWORD=venu;OPTION=3;");
            Console.WriteLine("Conectado");
        }
    }
}