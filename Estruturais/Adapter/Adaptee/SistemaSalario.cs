using designPatterns.Adapter.Domain;

namespace designPatterns.Adapter.Adaptee{
    
    public class SistemaSalario{
        public void CalculaSalario(List<Programador> listaProgramadores){
            foreach (Programador programador in listaProgramadores){
                Console.WriteLine($"Programador:  {programador.nome} - Nível {programador.nivel} - Salário R$ {programador.salario}");
            }
        }
    }

}

