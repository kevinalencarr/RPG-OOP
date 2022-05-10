namespace RPGoop.src.Entities
{
    public class Knight : Heroes
    {
        public Knight(string name, int level, string heroType, int hp, int mp)
            : base(name, level, heroType, hp, mp) {}

        public string BaseAttack(){
            return this.Name + " atacou com a espada!";
        }
    }
}