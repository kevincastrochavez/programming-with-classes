// Declaring lists in C# (you declare the type of the elements' list)

// List<int> numbers = new List<int>();
// List<string> words = new List<string>();

// words.Add("phone");
// words.Add("keyboard");
// words.Add("mouse");

// Console.WriteLine(words.Count);

// foreach (string word in words) {
//     Console.WriteLine(word);
// }

// for (int i = 0; i < words.Count; i++) {
//     Console.WriteLine(words[i]);
// }

Console.WriteLine("Enter a list of numbers, type 0 when finished.");

List<int> numbers = new List<int>();

int number = 1;

while (number != 0) {
    Console.Write("Enter number: ");
    int numberEntered = int.Parse(Console.ReadLine());
    if (numberEntered != 0) {
        numbers.Add(numberEntered);
    }

    number = numberEntered;
}

int sum = 0;
int listCount = numbers.Count;
int largestNumber = numbers.Max();
int smallestPositiveNumber = numbers[0];
Console.WriteLine(smallestPositiveNumber);

foreach (int item in numbers) {
    sum += item;
}

float average = sum / listCount;
numbers.Sort();

for (int i = 1; i < numbers.Count; i++) {
    if(numbers[i] < smallestPositiveNumber && numbers[i] > 0){
        smallestPositiveNumber = numbers[i];   
    }
}

Console.WriteLine($"The sum is {sum}");
Console.WriteLine($"The average is {average}");
Console.WriteLine($"The largest number is {largestNumber}");
Console.WriteLine($"The smallest positive number is {smallestPositiveNumber}");
Console.WriteLine("");
Console.WriteLine("The sorted list is:");
foreach (int item in numbers) {
    Console.WriteLine(item);
}
