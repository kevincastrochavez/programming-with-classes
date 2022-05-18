public class Hider {
    public int number;
    public Hider() {}

    public int generateRandomNumber() {
        Random random = new Random();
        number = random.Next(1, 1000);

        return number;
    }
}