namespace designPatterns.Factory{
    public class VeiculoFactory_terrestre: VeiculoFactoryMethod{
        protected override Veiculo CriaVeiculo(string modelo, string via){
            if(modelo == "1"){//moto
                return new Moto_terrestre();
            }else if (modelo == "2"){//carro
                return new Carro_terrestre();
            }else{
                return null;
            }  
        }
    }
}