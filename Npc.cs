namespace ClassExample_20210527
{
    public class Npc : Character
    {
        public string Ai;

        public Npc(string ai, string name, uint hp, CharacterClass cc) : base(name, hp, cc) 
        {
            this.Ai = ai;
        }
    }
}