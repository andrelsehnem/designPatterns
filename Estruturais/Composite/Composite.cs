namespace designPatterns.Composite{
    class Composite{
        public void Inicio(){
            Console.Clear();
            bool b = true;
            while(b){
                Console.WriteLine(" --    ---    -- ");
                Console.WriteLine(" -- Composite -- ");
                Console.WriteLine(" --    ---    -- ");
                Console.WriteLine("");
                b = Menu();
            }
        }

         private bool Menu(){
            return true;
         }
    }
}