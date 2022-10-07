//https://www.youtube.com/watch?v=WjtiVVcWTB4&ab_channel=JoseCarlosMacoratti
//https://medium.com/xp-inc/design-patterns-parte-20-memento-6b30ad75b12f

namespace designPatterns.Memento{
    class Memento{
        private string control;
        private double numero1, numero2;
        private string ope;
        private bool opeVal = false;
        private Calculadora calc = new();
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
            calc.SetPrimeiroNumero(numero1);
            Console.WriteLine("Digite a operação:");
            opeVal = false;
            while(!opeVal){
                ope = Console.ReadLine();
                if(ope.Equals("+") ||ope.Equals("-")||ope.Equals("*") ||ope.Equals("/")){
                    calc.SetOperacao(ope);
                    opeVal = true;
                }
            }
            Console.WriteLine("Digite o segundo numero:");
            numero2 = Convert.ToDouble(Console.ReadLine());
            calc.SetSegundoNumero(numero2);
            Console.WriteLine("Resultado: " + calc.GetCalculoResultado());
        }
    }
}