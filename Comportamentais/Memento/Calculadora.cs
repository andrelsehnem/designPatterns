namespace designPatterns.Memento{
    public class Calculadora: ICalculadora {
        private double primeiroNumero;
        private double segundoNumero;
        private string ope;

        public ICaretaker BackupUltimoCalculo(){
            //cria o obj memento usado para restaurar os dois numeros
            return new MementoClass(primeiroNumero, ope, segundoNumero);
        }

        public double GetCalculoResultado(){
            switch (ope){
                case "+":
                    return primeiroNumero + segundoNumero;
                case "-":
                    return primeiroNumero - segundoNumero;
                case "*":
                    return primeiroNumero * segundoNumero;
                case "/":
                    return primeiroNumero / segundoNumero;
                default:
                    return 0;
            }
        }

        public string GetCalculoResultado2(){
            return primeiroNumero + " " + ope + " " + segundoNumero + " = " + GetCalculoResultado();
        }

        public void RestauraUltimoCalculo(ICaretaker memento){
            primeiroNumero = ((IOrigem)memento).GetPrimeiroNumero();
            ope = ((IOrigem)memento).GetOperacao();
            segundoNumero = ((IOrigem)memento).GetSegundoNumero();
        }

        public void SetPrimeiroNumero(double num1){
            primeiroNumero = num1;
        }

        public void SetSegundoNumero(double num2){
            segundoNumero = num2;
        }

        public void SetOperacao(string _ope){
            ope = _ope;
        }

    }
}