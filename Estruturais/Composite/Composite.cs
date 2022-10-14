namespace designPatterns.Composite{
    class Composite{
        public Empresa empresa;
        public Empresa departamento1;
        public Empresa departamento2;
        public void Inicio(){
            Console.Clear();
            bool b = true;
            while(b){
                Console.Clear();
                Console.WriteLine(" --    ---    -- ");
                Console.WriteLine(" -- Composite -- ");
                Console.WriteLine(" --    ---    -- ");
                Console.WriteLine("");
                b = Menu();
            }
        }

         private bool Menu(){
            string _nome, _horas;
            Console.WriteLine("Digite o nome da empresa");
            empresa = new Empresa {nome = Console.ReadLine()};
            
            Console.WriteLine("Digite o nome do departamento 1");
            departamento1 = new Empresa {nome = Console.ReadLine()};
            Console.WriteLine("Funcionário 1: ");
            _nome = Console.ReadLine();
            Console.WriteLine("Horas trabalhadas: ");
            _horas = Console.ReadLine();
            departamento1.Add(new Funcionario {id = 1, nome = _nome, horas = Convert.ToInt32(_horas)});
            Console.WriteLine("Funcionário 2: ");
            _nome = Console.ReadLine();
            Console.WriteLine("Horas trabalhadas: ");
            _horas = Console.ReadLine();
            departamento1.Add(new Funcionario {id = 2, nome = _nome, horas = Convert.ToInt32(_horas)});
            Console.WriteLine("Funcionário 3: ");
            _nome = Console.ReadLine();
            Console.WriteLine("Horas trabalhadas: ");
            _horas = Console.ReadLine();
            departamento1.Add(new Funcionario {id = 3, nome = _nome, horas = Convert.ToInt32(_horas)});

            Console.WriteLine("Digite o nome do departamento 2");
            departamento2 = new Empresa {nome = Console.ReadLine()};
            Console.WriteLine("Funcionário 4: ");
            _nome = Console.ReadLine();
            Console.WriteLine("Horas trabalhadas: ");
            _horas = Console.ReadLine();
            departamento2.Add(new Funcionario {id = 4, nome = _nome, horas = Convert.ToInt32(_horas)});
            Console.WriteLine("Funcionário 5: ");
            _nome = Console.ReadLine();
            Console.WriteLine("Horas trabalhadas: ");
            _horas = Console.ReadLine();
            departamento2.Add(new Funcionario {id = 5, nome = _nome, horas = Convert.ToInt32(_horas)});
            Console.WriteLine("Funcionário 6: ");
            _nome = Console.ReadLine();
            Console.WriteLine("Horas trabalhadas: ");
            _horas = Console.ReadLine();
            departamento2.Add(new Funcionario {id = 6, nome = _nome, horas = Convert.ToInt32(_horas)});

            empresa.Add(departamento1);
            empresa.Add(departamento2);

            empresa.GetHoraTrabalhada();

            Console.WriteLine("Recalcular? s = Sim");
            if (Console.ReadLine() == "s") return true;
            return false;
         }
    }
}