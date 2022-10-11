namespace designPatterns.Strategy{
    
    public class ConexaoSQLServer: IConexao{
        
        public void ConectarBanco(string stringConexao){
            Console.WriteLine("Iniciando conexão SQL Server");
            Console.WriteLine("Driver={SQL Server};Server=myServerAddress;Database=" + stringConexao + ";Uid=myUsername;Pwd=myPassword;");
            Console.WriteLine("Conectado");
        }
    }
}