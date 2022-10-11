namespace designPatterns.Strategy{
    
    public class ConexaoContext{
        private IConexao _iconex;
        public ConexaoContext(IConexao iconex){
            _iconex = iconex;
        }

        public void DefineStrategy(IConexao iconex){
            _iconex = iconex;
        }

        public void CriarConexao(string stringConexao){
            _iconex.ConectarBanco(stringConexao);
        }
        
    }
}