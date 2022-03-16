//*************************Problem 1*********************************
// Console.Write("Enter a positive number of n: ");
// int n1 = Convert.ToInt32(Console.ReadLine());
// int[] numberArr = new int[n1];
// for(int i=0;i<n1;i++){
// Console.Write("Enter the {0}. number of n positive numbers : ",(i+1));
// numberArr[i] = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine("The even numbers you entered are below.");
// foreach (var number in numberArr)
// {
// if(number%2==0)
// Console.WriteLine(number);
// }

//*************************Problem 2*********************************
// Console.Write("Enter a positive number of n: ");
// int n2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter a positive number of m: ");
// int n3=Convert.ToInt32(Console.ReadLine());
// int[] numArray = new int[n2];
// for (int i = 0; i < n2; i++)
// {
//     Console.Write("Enter the {0}. number of n positive numbers : ",(i+1));
//     numArray[i] = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine("Below are the numbers you entered that are divisible by {0}(the value of m)",n3);
// foreach (var number in numArray)
// {
//     if(n3%number==0)
//         Console.WriteLine(number);
// }

//*************************Problem 3*********************************
// Console.Write("Enter a positive number of n: ");
// int n4 = Convert.ToInt32(Console.ReadLine());
// string[] wordArray = new string[n4];
// for (int i = 0; i < n4; i++)
// {
//     Console.Write("Enter the {0}. word of n words : ", (i + 1));
//     wordArray[i] = Console.ReadLine();
// }
// Console.WriteLine("Below are the words you entered");

// for (int i = n4 - 1; i >= 0; i--)
// {
//     Console.WriteLine(wordArray[i]);
// }

//*************************Problem 4*********************************
Console.Write("Enter a sentence: ");
string text = Console.ReadLine();
int wordCount = 0, index = 0;
int letterCount = 0;

// skip whitespace until first word
while (index < text.Length && char.IsWhiteSpace(text[index])) ;
{
    index++;
}
while (index < text.Length)
{
    //check if current char is part of a word
    while (index < text.Length && !char.IsWhiteSpace(text[index]))
    {
        index++;
    }

    wordCount++;

    //skip whitespace until next word
    while (index < text.Length && char.IsWhiteSpace(text[index]))
    {
        index++;
    }
}
Console.WriteLine("The number of words: " + wordCount);
Console.WriteLine("The number of letters: "+text.Count(char.IsLetter));

//************************* Project is done*********************************
