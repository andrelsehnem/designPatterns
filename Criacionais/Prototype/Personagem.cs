using designPatterns.Prototype;

namespace designPatterns{
    class Personagem:ICloneable{
        public string nome {get; set;}
        public Classe classe{get; set;}
        public Arma arma{get; set;}

        public Personagem(){

        }
        public Personagem(Personagem i){
            this.nome = i.nome;
            this.classe = i.classe;
            this.arma = i.arma;
        }

        ///<summary>
        ///Clona mas só muda o nome
        ///</summary> 
        public object Clone1(){
            return new Personagem(this);
        }

        ///<summary>
        ///Clona tudo
        ///</summary> 
        public object Clone(){
            Personagem per = (Personagem)this.MemberwiseClone();
            per.classe = (Classe)this.classe.Clone();
            per.arma = (Arma)this.arma.Clone();
            return per;
        }
    }
}