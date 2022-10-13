namespace designPatterns.Facade{
    class Facade{
        public void Inicio(){
            Console.Clear();
            bool b = true;
            while(b){
                Console.WriteLine(" --   --   -- ");
                Console.WriteLine(" -- Facade -- ");
                Console.WriteLine(" --   --   -- ");
                Console.WriteLine("");
                b = Menu();
            }
        }

         private bool Menu(){
            return true;
         }
    }
}