namespace designPatterns.Factory{
    public class VeiculoFactory_aereo: VeiculoFactoryMethod{
        protected override Veiculo CriaVeiculo(string modelo, string via){
            if (modelo == "2"){//aviao
                return new Aviao_aereo();
            }else if(modelo == "1"){//helicoptero
                return new Helicoptero_aereo();
            }else{
                return null;
            }  
        }
    }
}