public class Player
{
    private Random _die = new Random();

    public int RollDie() => _die.Next(1, 19);//18 sided die 

    public double GenerateSpellStrength() => _die.NextDouble() * 100;
}
