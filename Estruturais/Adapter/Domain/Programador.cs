namespace designPatterns.Adapter.Domain{
    public class Programador{
        public string id{get;set;}
        public string nome {get;set;}
        public string nivel {get;set;}
        public decimal salario {get;set;}

        public Programador(string _id, string _nome, string _nivel, decimal _salario){
            id = _id;
            nome = _nome;
            nivel = _nivel;
            salario = _salario;
        }
    }
}