namespace RPGoop.src.Entities
{
    public class Ninja : Heroes
    {
        public Ninja(string name, int level, string heroType, int hp, int mp)
            : base(name, level, heroType, hp, mp) {}

        public string BaseAttack(){
            return this.Name + " lançou uma shuriken!";
        }
    }
}