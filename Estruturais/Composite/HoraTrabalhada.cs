namespace designPatterns.Composite{
    public abstract class HoraTrabalhada{
        public HoraTrabalhada(){

        }

        public string nome{get; set;}
        public abstract int GetHoraTrabalhada();
        public virtual void Add(HoraTrabalhada component){
            throw new NotImplementedException();
        }
        public virtual void Remove(HoraTrabalhada component){
            throw new NotImplementedException();
        }
    }
}