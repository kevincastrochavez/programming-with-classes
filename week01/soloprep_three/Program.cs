Random randomGenerator = new Random();
int magicNumber = randomGenerator.Next(1, 101);
Console.WriteLine(magicNumber);

int guess = -1;

while (guess != magicNumber) {
    Console.Write("What is your guess?: ");
    guess = int.Parse(Console.ReadLine());
    
    if (magicNumber > guess) {
        Console.WriteLine("Go higher");
    } else if (magicNumber < guess) {
        Console.WriteLine("Go lower");
    } else {
        Console.WriteLine("You guessed it!");
    }
}

