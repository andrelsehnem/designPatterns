namespace designPatterns.Memento{
   public interface IOrigem{ //(originator)
//permite restaurar seu estado
        double GetPrimeiroNumero();
        double GetSegundoNumero();
        char GetOperacao();

   }
}

//Esta é uma classe que cria um objeto de lembrança contendo um instante do estado atual do “Originator”. 
//Ele também restaura o “Originator” para um estado armazenado anteriormente usando a operação Save.