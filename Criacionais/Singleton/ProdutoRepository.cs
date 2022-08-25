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

        public IList<Produto> GetAll(){
            return _instancia._produtos;
        }

        public void Insert (Produto produto){
            _instancia?._produtos.Add(produto);
        }
    }
}