namespace designPatterns.ChainOfResponsability{
    public class Nota10 : Autorizador {
        private int _nota = 10;
        private Decimal sobra = 0;
        private Decimal aux = 0;
        private String? _notas;
        public override void Saca(Decimal valor, string notas)
        {
            _notas = "";
            sobra = valor;
            if(valor >= _nota){
                CalculaNotas(valor, _nota);
                notas += _notas;
                if (sobra > 0) {
                    Console.WriteLine("Notas retiradas:" + "\n" + notas);
                    Console.WriteLine("Valor restante " + sobra);
                }
                else  Console.WriteLine("Notas retiradas:" + "\n" + notas);
            }
            else{
                Console.WriteLine("Notas retiradas:" + "\n" + notas);
                Console.WriteLine("Valor restante " + sobra);
            }                       
        }
        public override void CalculaNotas(Decimal valor, int nota){
            aux = Decimal.Floor(valor / nota);
            sobra = valor - (nota * aux);
            _notas = aux + " notas de R$ 10,00" + "\n";
        }

        private void Final(Decimal sobra, String notas){

        }
    }
}