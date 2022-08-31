using System.Text;

namespace designPatterns.Factory
{
    public abstract class Veiculo{
        protected string? nome {get; set;}
        protected string? modelo;
        protected int? passageiros;
        
        public string MontarVeiculo(){
            Console.Clear();
            StringBuilder sb = new();
            sb.Append("Iniciando montagem do veículo..." + "\n");
            sb.Append("... - " + nome + " - ..." + "\n");
            sb.Append("Modelo: " + modelo + "\n");
            sb.Append("Número máximo de passageiros: " + passageiros + "\n");

            sb.Append(Ligar());
            sb.Append(Acelerar());
            sb.Append(Percurso());
            sb.Append(Estacionar());
            sb.Append(Desligar());           

            return sb.ToString();
        }

        private string Ligar(){
            return "Ligando " + nome  +  "\n";
        }

        private string Acelerar(){
            return "Acelerando " + nome  +  "\n";
        }    
        
        private string Percurso(){
            return "Em percurso " + "\n";
        } 

        private string Estacionar(){
            return "Estacionando " + nome  +  "\n";
        }    
        private string Desligar(){
            return "Desligando " + nome  + "\n";
        }       
    }
}