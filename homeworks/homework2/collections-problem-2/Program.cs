int[] numbers = new int[20];
int averageOfLargest3Numbers = 0;
int averageOfLowest3Numbers = 0;
for (int i = 0; i < 20; i++)
{
    Console.Write("Enter {0}. number  : ", (i + 1));
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}
Array.Sort(numbers);
for (int i = 0; i < 3; i++)
{
    averageOfLowest3Numbers += numbers[i];
}
averageOfLowest3Numbers /= 3;

Array.Reverse(numbers);
for (int i = 0; i < 3; i++)
{
    averageOfLargest3Numbers += numbers[i];
}
averageOfLargest3Numbers /= 3;

Console.WriteLine("Average of 3 Largest Numbers : " + averageOfLargest3Numbers);
Console.WriteLine("Average of 3 Lowest Numbers : " + averageOfLowest3Numbers);
Console.WriteLine("The total of these 2 averages : " + (averageOfLargest3Numbers + averageOfLowest3Numbers));