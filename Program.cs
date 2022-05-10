using RPGoop.src.Entities;

Knight arus = new Knight("Arus", 42, "Knight", 749, 72);
Ninja wedge = new Ninja("Wedge", 42, "Ninja", 574, 89);
WhiteWizard jenica = new WhiteWizard("Jenica", 42, "White Wizard", 601, 482);
BlackWizard topapa = new BlackWizard("Topapa", 42, "Black Wizard", 385, 641);

// Console.WriteLine($"Name: {arus.Name};  Type: {arus.HeroType}; Level: {arus.Level}; HP: {arus.HP}; MP: {arus.MP};");
// Console.WriteLine(arus.BaseAttack());

// Console.WriteLine($"Name: {wedge.Name};  Type: {wedge.HeroType}; Level: {wedge.Level}; HP: {wedge.HP}; MP: {wedge.MP};");
// Console.WriteLine(wedge.BaseAttack());

// Console.WriteLine($"Name: {jenica.Name};  Type: {jenica.HeroType}; Level: {jenica.Level}; HP: {jenica.HP}; MP: {jenica.MP};");
// Console.WriteLine(jenica.BaseAttack());

// Console.WriteLine($"Name: {topapa.Name};  Type: {topapa.HeroType}; Level: {topapa.Level}; HP: {topapa.HP}; MP: {topapa.MP};");
// Console.WriteLine(topapa.BaseAttack());

Console.WriteLine(arus.BaseAttack());

Console.WriteLine(arus.BonusAttack(1));