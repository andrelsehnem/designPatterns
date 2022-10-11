using designPatterns.Adapter.Target;
using designPatterns.Adapter.Adaptee;
using designPatterns.Adapter.Domain;


namespace designPatterns.Adapter.Adapter{
    public class ProgramadorAdapter : ITarget {

        private SistemaSalario sistemaSalario = new();

        public void ProcessaCalculoSalarios(string[,] programadoresArray){
            string id = null;
            string nome= null;
            string nivel= null;
            decimal salario= 0;

            List<Programador> listaProgramador = new();

            for(int i = 0; i < programadoresArray.GetLength(0); i++){
                for(int j = 0; j < programadoresArray.GetLength(1); j++){
                    if (j == 0){
                        id = programadoresArray[i,j];
                    }
                    else if (j == 1){
                        nome = programadoresArray[i,j];
                    }
                    else if (j == 2){
                        nivel = programadoresArray[i,j];
                    }
                    else{
                        salario = Convert.ToDecimal(programadoresArray[i,j]);
                    }
                }

                listaProgramador.Add(new Programador(id, nome, nivel, salario));
            }

            Console.WriteLine("Finalizada conversão de Array[] para List<>");

            //parei min 13:00  https://www.youtube.com/watch?v=HElHbc0yvl8&ab_channel=JoseCarlosMacoratti
            

        }


    }
}