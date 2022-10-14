namespace designPatterns.Composite{
    public class Funcionario: HoraTrabalhada{
        public int id {get; set;}
        public int horas {get; set;}

        public override int GetHoraTrabalhada()
        {
            Console.WriteLine($"O funcionário {id} - {nome} registrou:");
            Console.WriteLine($"{horas} trabalhadas");
            return horas;
        }
    }
}