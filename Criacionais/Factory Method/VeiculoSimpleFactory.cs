using System;

namespace designPatterns.Factory{
    public class VeiculoSimpleFactory{
        public static VeiculoFactoryMethod CriarVeiculo(string modelo, string via){
            VeiculoFactoryMethod veiculo;
            switch (via){
                case "1":
                    veiculo = new VeiculoFactory_terrestre();
                    break;
                case "2":
                    veiculo = new VeiculoFactory_aereo();
                    break;
                default:
                    throw new ApplicationException("Modelo não disponível");
            }
            return veiculo;
        }
    }
}