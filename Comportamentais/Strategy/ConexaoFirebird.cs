namespace designPatterns.Strategy{
    
    public class ConexaoFirebird: IConexao{
        
        public void ConectarBanco(string stringConexao){ //DBNAME=MyServer/3051:myData"
            Console.WriteLine("Iniciando conexão Firebird");
            Console.WriteLine(@"DRIVER=Firebird/InterBase(r) driver; UID=SYSDBA;PWD=masterkey; C:\database\" + stringConexao + ".fdb;");
            Console.WriteLine("Conectado");
        }
    }
}