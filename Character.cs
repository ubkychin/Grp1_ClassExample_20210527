namespace ClassExample_20210527
{
    public class Character
    {
        public string Name;
        public uint HP;
        public CharacterClass CharacterClass;

        public Character(string name, uint hp, CharacterClass cClass) {
            this.Name = name;
            this.HP = hp;
            this.CharacterClass = cClass;
        }

        public Character(string name, CharacterClass cClass) {
            this.Name = name;
            this.HP = 100;
            this.CharacterClass = cClass;
        }

    }
}