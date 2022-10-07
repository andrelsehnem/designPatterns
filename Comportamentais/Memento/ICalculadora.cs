namespace designPatterns.Memento{
    //define a interface para implementação do Origem (originator)

    public interface ICalculadora{
        ICaretaker BackupUltimoCalculo();

        void RestauraUltimoCalculo(ICaretaker memento);


//serviços do originator
        double GetCalculoResultado();
        void SetPrimeiroNumero(double num1);
        void SetSegundoNumero(double num2);
        void SetOperacao(char ope);
    }
   
}