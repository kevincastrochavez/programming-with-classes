// Declaring lists in C# (you declare the type of the elements' list)

List<int> numbers = new List<int>();
List<string> words = new List<string>();

words.Add("phone");
words.Add("keyboard");
words.Add("mouse");

Console.WriteLine(words.Count);

foreach (string word in words) {
    Console.WriteLine(word);
}

for (int i = 0; i < words.Count; i++) {
    Console.WriteLine(words[i]);
}