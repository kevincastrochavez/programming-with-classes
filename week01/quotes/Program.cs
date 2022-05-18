public class Program {
    static void Main() {
        Quote q = new Quote("Paul", "God hath given us the spirit of fear; but of power, and of love, and of a sound mind", new Source("2 Timothy 1:7"));
        Console.WriteLine(q.GetQuote());
    }
}