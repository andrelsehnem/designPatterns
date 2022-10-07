namespace designPatterns.Memento{
    //Representa o estado armazenado
    //Armazena o estado do objeto Origem(originator)
    //Só tem Get, nao altera dados

    public class MementoClass: ICaretaker, IOrigem {
        private double primeiroNumero;
        private double segundoNumero;
        private string ope;
        public MementoClass(double num1, string _ope, double num2){
            primeiroNumero = num1;
            ope = _ope;
            segundoNumero = num2;
        }

        public double GetPrimeiroNumero(){
            return primeiroNumero;
        }

        public double GetSegundoNumero(){
            return segundoNumero;
        }

        public string GetOperacao(){
            return ope;
        }
    }
}