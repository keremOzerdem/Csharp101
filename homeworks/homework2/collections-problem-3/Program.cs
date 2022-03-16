Console.Write("Write something : ");
string sentence = Console.ReadLine().ToLower();
List<char> vowels = new List<char>();
for (int i = 0; i < sentence.Length; i++)
{
    if (sentence[i] == ('a') || sentence[i] == ('e') || sentence[i] == ('i') || sentence[i] == ('o') || sentence[i] == ('u'))
    {
        vowels.Add(sentence[i]);
    }
}
Console.Write("The list of all vowels : ");
foreach (var item in vowels)
{
    Console.Write(item + ", ");
}
