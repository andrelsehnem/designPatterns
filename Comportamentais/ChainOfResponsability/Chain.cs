namespace designPatterns.ChainOfResponsability{
    class Chain{
        public void inicio(){
            Nota100 n100 = new();
            Nota50 n50 = new();
            Nota20 n20 = new();
            Nota10 n10 = new();

            n100.ProximoAutorizador(n50);
            n50.ProximoAutorizador(n20);
            n20.ProximoAutorizador(n10);

            bool b = true;
            while(b){
                Console.WriteLine("-- Banco Chain Of Responsability --");
                Console.WriteLine("Qual valor deseja sacar?");
                string s = Console.ReadLine();
                if (s == "x") return;
                Decimal valor = Convert.ToDecimal(s);
                n100.Saca(valor, "");
                Console.WriteLine(" --- --- --- ");
            }
            
        }
    }
}