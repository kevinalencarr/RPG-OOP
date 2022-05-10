namespace RPGoop.src.Entities
{
    public class BlackWizard : Heroes
    {
        public BlackWizard(string name, int level, string heroType, int hp, int mp)
            : base(name, level, heroType, hp, mp) {}

        public string BaseAttack(){
            return this.Name + " lançou magia sombria!";
        }        
    }
}