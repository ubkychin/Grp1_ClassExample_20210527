namespace ClassExample_20210527
{
    public class Player : Character
    {
        public string ControlScheme;
        public Player(string controlScheme, string name, CharacterClass cc) : base(name, cc){
            this.ControlScheme = controlScheme;
        }

        
    }
}