Console.Write("Type your grade percentage: ");
string gradePercentage = Console.ReadLine();

int percentage = int.Parse(gradePercentage);

string letter = "";

if (percentage >= 90) {
    letter = "A";
} else if (percentage >= 80) {
    letter = "B";
} else if (percentage >= 70) {
    letter = "C";
} else if (percentage >= 60) {
    letter = "D";
} else {
    letter = "F";
}

if (percentage % 10 >= 7) {
    letter = $"{letter}{"+"}";
} else if (percentage % 10 <= 3) {
    letter = $"{letter}{"-"}";
}

Console.WriteLine($"You got a {letter}");

if (percentage >= 70) {
    Console.WriteLine("Congratulations! You passed the class");
} else {
    Console.WriteLine("Try again later");
}
