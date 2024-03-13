string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

string input = Console.ReadLine().ToUpper(); // ABCD



for (int i = 0; i < input.Length; i++)
{
    char c = input[i];

    int index = letters.IndexOf(c);
    Console.Write($"{input[i]}, {index}\n");
}
