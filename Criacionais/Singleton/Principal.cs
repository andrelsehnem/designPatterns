/*
Utilizado quando se necessita a existência de uma única instância de uma classe e que possa ser facilmente acessível de qualquer ponto do programa;
Cria uma classe que deixa o construtor privado, ficando disponível uma função que vai verificar se a instância está vazia, para então assim criá-lo, assim vai somente existir uma instância deste objeto, não mais.
*/
namespace designPatterns{
    public sealed class ProdutoRepository{
        private readonly IList<Produto> _produtos;
        private static ProdutoRepository? _instancia = null;

        private ProdutoRepository(){
            _produtos = new List<Produto>();
        }

        public static ProdutoRepository GetInstance(){
            if(_instancia != null ) return _instancia;
            else _instancia = new ProdutoRepository();
            return _instancia;
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