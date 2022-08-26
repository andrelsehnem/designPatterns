namespace designPatterns.Prototype{
    class Prototype{
        public void inicio(){
            Personagem personagem = new();
            personagem.nome = "Kratos";
            personagem.arma = new Arma {nome = "Espada"} ;
            personagem.classe = new Classe();
            personagem.classe.ViraGuerreiro();

            Personagem personagem2 = (Personagem)personagem.Clone();
            personagem2.nome = "Poison";
            personagem2.arma.nome = "Cajado";
            personagem2.classe.ViraMago();

            Personagem personagem3 = (Personagem)personagem.Clone();
            personagem3.nome = "Garry";
            personagem3.arma.nome = "Arco de madeira";
            personagem3.classe.ViraArqueiro();

            ExibeValores(personagem);
            ExibeValores(personagem2);
            ExibeValores(personagem3);
        }

        public void ExibeValores(Personagem p){
            Console.WriteLine(p.nome);
            Console.WriteLine(p.arma.nome);
            Console.WriteLine(p.classe.nome + " - " + p.classe.ataque + " - " + p.classe.defesa + " - " + p.classe.magia + " - " + p.classe.vida);
        }
    }
}