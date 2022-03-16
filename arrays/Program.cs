// Declaring Array
string[] colors = new string[5];

string[] animals = { "Cat", "Dog", "Bird", "Monkey" };

int[] myArray;
myArray = new int[5];

//Assigning variable to array and accessing the variable
colors[0] = "Blue";
myArray[3] = 10;

Console.WriteLine(animals[1]);
Console.WriteLine(myArray[3]);
Console.WriteLine(colors[0]);

// Using arrays via loops
// Write a program that calculates the average of n numbers were entered by keyboard
Console.Write("Please enter the number of elements of the array: ");
int lengthofArray = int.Parse(Console.ReadLine());
int[] arrayofNumbers = new int[lengthofArray];

for (int i = 0; i < lengthofArray; i++)
{
    Console.Write("Lütfen {0}. sayıyı giriniz: ", i + 1);
    arrayofNumbers[i] = int.Parse(Console.ReadLine());
}

int total = 0;
foreach (var number in arrayofNumbers)
{
    total += number;
}
Console.WriteLine("Ortalama :" + total / lengthofArray);