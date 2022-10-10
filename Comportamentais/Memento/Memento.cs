//https://www.youtube.com/watch?v=WjtiVVcWTB4&ab_channel=JoseCarlosMacoratti
//https://medium.com/xp-inc/design-patterns-parte-20-memento-6b30ad75b12f

namespace designPatterns.Memento{
    class Memento{
        private string control;
        private double numero1, numero2;
        private string ope;
        private bool opeVal = false;
        //private Calculadora calc = new();
        private ICalculadora calcInt = new Calculadora();
        ICaretaker meme;
        public void inicio(){
            Console.Clear();
            bool b = true;
            while(b){
                Console.WriteLine(" --- --- --- ");
                Console.WriteLine("   Memento ");
                Console.WriteLine(" --- --- --- ");
                Console.WriteLine("Calculadora");
                b = Menu();
            }
        }

        private bool Menu(){
            Console.WriteLine("Escolha como continuar:");
            Console.WriteLine(">  Nova Operação");
            Console.WriteLine("<  Verificar operação anterior");
            Console.WriteLine("x  Retornar");
            control = Console.ReadLine();
            switch (control){
                case ">":
                    Calculo();
                    return true;
                case "<":
                    calcInt.RestauraUltimoCalculo(meme);
                    Console.Clear();
                    Console.WriteLine(calcInt.GetCalculoResultado2());
                    return true;
                case "x":
                    return false;
            }
            return true;
        }

        private void Calculo(){
            Console.Clear();
            Console.WriteLine("Digite o primeiro numero:");
            numero1 = Convert.ToDouble(Console.ReadLine());
            calcInt.SetPrimeiroNumero(numero1);
            Console.WriteLine("Digite a operação:");
            opeVal = false;
            while(!opeVal){
                ope = Console.ReadLine();
                if(ope.Equals("+") ||ope.Equals("-")||ope.Equals("*") ||ope.Equals("/")){
                    calcInt.SetOperacao(ope);
                    opeVal = true;
                }
                else Console.WriteLine("Digite uma operação correta");
            }
            Console.WriteLine("Digite o segundo numero:");
            numero2 = Convert.ToDouble(Console.ReadLine());
            calcInt.SetSegundoNumero(numero2);
            Console.Clear();
            Console.WriteLine("Resultado: " + calcInt.GetCalculoResultado());
            meme = calcInt.BackupUltimoCalculo();
        }
    }
}