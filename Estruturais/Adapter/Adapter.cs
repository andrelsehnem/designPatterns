namespace designPatterns.Adapter{
    class Adapter{
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
            return true;
         }
    }
}
