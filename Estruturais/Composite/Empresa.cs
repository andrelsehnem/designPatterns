namespace designPatterns.Composite{
    public class Empresa: HoraTrabalhada{

        protected List<HoraTrabalhada> departamentos = new();

        public override void Add(HoraTrabalhada component)
        {
            departamentos.Add(component);
        }
        public override void Remove(HoraTrabalhada component)
        {
            departamentos.Remove(component);
        }

        public override int GetHoraTrabalhada()
        {
            var horasTrabalhadasDepartamento = 0;

            foreach(var departamento in departamentos){
                horasTrabalhadasDepartamento += departamento.GetHoraTrabalhada();
            }
            Console.WriteLine($"{nome} registrou um total de {horasTrabalhadasDepartamento} horas");
            return horasTrabalhadasDepartamento;
        }
    }
}