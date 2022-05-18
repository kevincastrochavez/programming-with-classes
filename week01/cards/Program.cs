int points = 300;
var cardsNumber = new List<int>{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
var random = new Random();
string response;
string playing;

int previousNumber = random.Next(cardsNumber.Count);
Console.WriteLine($"The card is: {cardsNumber[previousNumber]}");
cardsNumber.Remove(cardsNumber[previousNumber]); 

while (cardsNumber.Count != 0)
{
    int nextNumber = random.Next(cardsNumber.Count);
    Console.Write("Higher or lower? [h/l]");
    response = Console.ReadLine();

    if (response == "h" && nextNumber > previousNumber) {
        points += 100;
    } else if (response == "l" && nextNumber < previousNumber) {
        points += 100;
    } else if (response == "h" && nextNumber < previousNumber) {
        points -= 75;
    } else if (response == "l" && nextNumber > previousNumber) {
        points -= 75;
    }

    Console.WriteLine($"The card was: {cardsNumber[nextNumber]}");

    Console.WriteLine($"Your score is: {points}");

    Console.Write("Play again? [y/n]");
    playing = Console.ReadLine();

    if (playing == "n") {
        return;
    }

    Console.WriteLine("");
    Console.WriteLine($"The card is: {cardsNumber[nextNumber]}");
    cardsNumber.Remove(cardsNumber[nextNumber]);  
}