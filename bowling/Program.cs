
using bowling;

List<Drink> drinks = new List<Drink>();

drinks.Add(new Drink { Name = "Mountain Dew", ContainsAlcohol =true, IsCarbonated = true, SizeInOz = 12 });
drinks.Add(new Drink { Name = "Diet Mountain Dew", ContainsAlcohol = false, IsCarbonated = true, SizeInOz = 12 });
drinks.Add(new Drink { Name = "Water", ContainsAlcohol = false, IsCarbonated = false, SizeInOz = 8 });
drinks.Add(new Drink { Name = "Guinness", ContainsAlcohol = true, IsCarbonated = true, SizeInOz = 16 });
drinks.Add(new Drink { Name = "Bourbon", ContainsAlcohol = true, IsCarbonated = false, SizeInOz = 2 });


foreach(var drink in drinks) {
    Console.WriteLine($"A drink to consider on any occasion is {drink.Name}, which contain alcohol {drink.ContainsAlcohol} " +
        $"and is carbonated {drink.IsCarbonated} served in a {drink.SizeInOz} glass.");
}



/*List<int> game = new List<int>();

for(var idx = 1; idx <= 10; idx++) {
    var score = GetScore();
    game.Add(score);
}

var gameScore = 0;

foreach(var score in game) {
    gameScore += score;
}

Console.WriteLine($"Score is {gameScore}");
int GetScore() {
    Console.Write("Enter Score: ");
    var scorAsString = Console.ReadLine();
    var score = Convert.ToInt32(scorAsString);
    return score;
}
 */
