/*
Utilizado quando se necessita a existência de uma única instância de uma classe e que possa ser facilmente acessível de qualquer ponto do programa;
Cria uma classe que deixa o construtor privado, ficando disponível uma função que vai verificar se a instância está vazia, para então assim criá-lo, assim vai somente existir uma instância deste objeto, não mais.
*/
namespace designPatterns{
    class Singleton{
        public void inicio(){
            var repositorio = ProdutoRepository.GetInstance();

            var lista1 = repositorio.GetAll();
            Console.WriteLine(lista1.Count);
            repositorio.Insert(new Produto{
                 Id = 1, Name = "AAA", Price = 12 });
            repositorio.Insert(new Produto { 
                Id = 2, Name = "BBBB", Price = 33 });

            var lista2 = repositorio.GetAll();

            var repositorio2 = ProdutoRepository.GetInstance();

            var lista3 = repositorio2.GetAll();

            Console.WriteLine("Lista 1: " + lista1.Count);
            Console.WriteLine("Lista 2: " + lista2.Count);
            Console.WriteLine("Lista 3: " + lista3.Count);
        }
    }

}









/*public class ClasseNormal
    {
        public int variavelClasseNormal;
    }
    public sealed class ClasseSingleton
    {
        static ClasseSingleton? _instancia;
        public static ClasseSingleton Instancia
        {
            get { return _instancia ?? (_instancia = new ClasseSingleton()); }
        }
        private ClasseSingleton() { }
        public string? Mensagem { get; set; }
    }
    static public class ClasseEstatica
    {
        private static readonly int variavelEstatica;
        // Construtor Static constructor é executado 
        // somente uma vez quando o tipo for usado.   
        static ClasseEstatica()
        {
            variavelEstatica = 1;
        }
        public static string ExibirValor()
        {
            return string.Format("O valor da variável estática é {0}", variavelEstatica);
        }
        public static string? Mensagem { get; set; }
    }*/