using RPGoop.src.Entities.Items;

namespace RPGoop.src.Entities
{
    public abstract class Heroes
    {
        public Heroes(string name, int level, string heroType, int hp, int mp)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
            this.HP = hp;
            this.MP = mp;
        }

        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }

        public string BonusAttack(int bonus){        
            AttPotions potions = new AttPotions();
            int selectedPotion;

            Console.WriteLine("Usar poção? 1- Poção Azul | 2- Poção Vermelha | 3- Não");
            string? input = Console.ReadLine();
            
            if (int.TryParse(input, out selectedPotion)) {
                switch(selectedPotion){
                case 1: bonus = bonus + potions.BluePotion; break;
                case 2: bonus = bonus + potions.RedPotion; break;
                case 3: break;
                default: BonusAttack(bonus); break;
                }
            } else {
                Console.WriteLine("Opção inválida!");
                BonusAttack(bonus);
            }

            if (bonus >= 6) {
                return this.Name + " fez um ataque superefetivo com bônus de " + bonus + "!";
            } else {
                return this.Name + " atacou com bônus de " + bonus + "!";
            }
        }
    }
}