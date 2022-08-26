namespace designPatterns.Prototype
{
    class Arma{
        public string nome {get; set;}


        //Clonar o personagem sem repedir a arma
        public object Clone(){
            return (Arma)this.MemberwiseClone();
        }
    }
}
