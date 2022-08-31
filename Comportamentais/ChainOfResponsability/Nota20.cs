namespace designPatterns.ChainOfResponsability{
    public class Nota20 : Autorizador {
        private int _nota = 20;
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
                    _autorizador?.Saca(sobra, notas);
                }
                else{
                    Console.WriteLine("Notas retiradas:" + "\n" + notas);
                }
            }
            else{
                _autorizador?.Saca(valor, notas);
            }                       
        }
        public override void CalculaNotas(Decimal valor, int nota){
            aux = Decimal.Floor(valor / nota);
            sobra = valor - (nota * aux);
            _notas = aux + " notas de R$ 20,00" + "\n";
        }
    }
}