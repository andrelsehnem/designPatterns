namespace designPatterns.Factory{
    class Factory{
        public void inicio(){
            Console.WriteLine("Qual via deseja utilizar?");
            Console.WriteLine("1 - Terrestre");
            Console.WriteLine("2 - Aéreo");
            string via = Console.ReadLine();

            Console.WriteLine("Duas ou mais pessoas?");
            Console.WriteLine("1 - Duas");
            Console.WriteLine("2 - Mais");
            string qtdePessoas = Console.ReadLine();

            try{
                VeiculoFactoryMethod fabricaDeVeiculos = VeiculoSimpleFactory.CriarVeiculo(qtdePessoas, via);
                var veiculo = fabricaDeVeiculos.MontaVeiculo(qtdePessoas, via);

                Console.WriteLine(veiculo.MontarVeiculo());
                Console.WriteLine("Viagem finalizada");   
            }catch(Exception ex){
                Console.WriteLine(ex.Message);
            }
        }
    }
}