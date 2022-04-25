Console.Write("Enter first number: ");
int firstNumber = int.Parse(Console.ReadLine());

Console.Write("Enter second number: ");
int secondNumber = int.Parse(Console.ReadLine());

Console.Write("Enter third number: ");
int thirdNumber = int.Parse(Console.ReadLine());

Console.WriteLine($"{firstNumber}, {secondNumber}, and {thirdNumber}. ({firstNumber} + {secondNumber}) * {thirdNumber} is {(firstNumber + secondNumber) * thirdNumber} and {firstNumber} * {secondNumber} + {secondNumber} * {thirdNumber} is {firstNumber * secondNumber + secondNumber * thirdNumber}");