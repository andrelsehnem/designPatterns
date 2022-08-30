namespace designPatterns.Factory{
    public abstract class VeiculoFactoryMethod{ //08:12
        public Veiculo MontaVeiculo(string modelo, string via){
            Veiculo veiculo;
            veiculo = CriaVeiculo(modelo, via);
            return veiculo;
        }

        protected abstract Veiculo CriaVeiculo(string modelo, string via);

    }
}