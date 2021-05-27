namespace ClassExample_20210527
{
    public class Warrior : CharacterClass
    {
        public uint Dmg;

        public Warrior(string name, uint dmg) : base(name)
        {
            this.Dmg = dmg;
        }
    }
}