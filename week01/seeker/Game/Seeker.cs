public class Seeker {
    public int number;
    public int location;
    public Seeker() {
        number = new Hider().generateRandomNumber();
    }

    public void startGame() {
        Console.Write("Enter a location [1-1000]: ");
        location = Int32.Parse(Console.ReadLine());

        Console.WriteLine(number);
        Console.WriteLine(location);
    }

}