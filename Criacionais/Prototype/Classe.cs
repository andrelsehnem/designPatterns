namespace designPatterns.Prototype
{
    class Classe{
        public string nome{get; set;}
        public int vida{get; set;}
        public int ataque{get; set;}
        public int magia{get; set;}
        public int defesa{get; set;}

        public Classe(){
            nome = "Humano";
            vida = 5;
            ataque = 3;
            magia = 2;
            defesa = 3;
        }

        public void ViraMago(){
            Mago();
        }

        public void ViraGuerreiro(){
            Guerreiro();
        }

        public void ViraArqueiro(){
            Arqueiro();
        }

        public void Mago(){
            nome = "Mago";
            vida = 6;
            ataque = 3;
            magia = 10;
            defesa = 6;
        }

        public void Guerreiro(){
            nome = "Guerreiro";
            vida = 6;
            ataque = 10;
            magia = 2;
            defesa = 7;
        }

        public void Arqueiro(){
            nome = "Arqueiro";
            vida = 6;
            ataque = 6;
            magia = 6;
            defesa = 7;
        }
        

        //Clonar o personagem sem repedir a arma
        public object Clone(){
            return (Classe)this.MemberwiseClone();
        }
    }

}