namespace designPatterns.Bridge{
    class Bridge{
        public void Inicio(){
            Console.Clear();
            bool b = true;
            while(b){
                Console.WriteLine(" --   --   -- ");
                Console.WriteLine(" -- Bridge -- ");
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