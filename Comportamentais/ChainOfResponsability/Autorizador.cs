
namespace designPatterns.ChainOfResponsability{
    public abstract class Autorizador{
        protected Autorizador _autorizador;

        public void ProximoAutorizador(Autorizador autorizador){
            _autorizador = autorizador;
        }

        public abstract void Saca(Decimal valor, string notas);

        public abstract void CalculaNotas(Decimal valor, int nota);
    }
}
