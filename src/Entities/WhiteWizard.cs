namespace RPGoop.src.Entities
{
    public class WhiteWizard : Heroes
    {
        public WhiteWizard(string name, int level, string heroType, int hp, int mp)
            : base(name, level, heroType, hp, mp) {}

        public string BaseAttack(){
            return this.Name + " lançou magia de luz!";
        }        
    }
}