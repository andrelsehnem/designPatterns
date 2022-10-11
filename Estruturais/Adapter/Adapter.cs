using designPatterns.Adapter.Adaptee;
using designPatterns.Adapter.Adapter;
using designPatterns.Adapter.Domain;
using designPatterns.Adapter.Target;


namespace designPatterns.Adapter{
    class Adapterr{
        private string[,] arrayProg;
        public void Inicio(){
            Console.Clear();
            bool b = true;
            
            while(b){
                Console.WriteLine(" --   --    -- ");
                Console.WriteLine(" -- Adapter -- ");
                Console.WriteLine(" --   --    -- ");
                Console.WriteLine("");
                b = Menu();
            }
        }

        private bool Menu(){
            CriaArray();
            ITarget target = new ProgramadorAdapter();

            Console.WriteLine("Sistema de salários - Passa o array para o Adapter");

            target.ProcessaCalculoSalarios(arrayProg);
repros:
            Console.WriteLine("Reprocessar? \n 1- Sim \n 2- Não");
            switch (Console.ReadLine()) {
                case "1":
                    Console.Clear();
                    return true;
                case "2":
                    Console.Clear();
                    return false;
                default:
                    goto repros;
            }
            return true;
        }

        private void CriaArray(){
            arrayProg = new string[4,4]{
                 {"1", "Antonio", "Aprendiz", "100"},
                 {"2", "Bernardo", "Junior", "200"},
                 {"3", "Carlos", "Pleno", "300"},
                 {"4", "Douglas", "Senior", "400"},
            };
        }

    }
}
