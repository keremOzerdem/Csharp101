using System.Collections;
// gonna use ArrayList for storing 20 numbers' values.

ArrayList numberList = new ArrayList();
ArrayList primeNumberList = new ArrayList();
ArrayList notPrimeNumberList = new ArrayList();

// The algorithm is ready below!!! I prepared this algorithm to check only one number
//So, lets rewrite the code block to make this algorithm to check a number of array.
//for checking the numbers in array, lets use a for loop.
// I have the power is to check an array whether if contains prime numbers.
for (int i = 0; i < 20; i++)
{
    Console.Write("Enter the {0}. number: ", (i + 1));
    //the numbers I take can not be negative or non-numeric. lets check this.
    //okay, cool.The program has the power of checking numbers whether if are negative
    //but also we need to check non-numeric numbers->lets do this
    // I HAVE THE POWER OF BLOCKING NON-NUMERIC CHARACTERS. COLLLL!!! 

    // blocking non-numeric characters - start
    string number = Console.ReadLine();
    int value;
    while (!Int32.TryParse(number, out value))
    {
        Console.Write("Please enter a numeric value: ");
        number = Console.ReadLine();
        if (Int32.TryParse(number, out value))
        {
            value = Convert.ToInt32(number);
        }
    }
    // blocking non-numeric characters - end

    //blocking negative number - start
    while (Convert.ToInt32(number) < 0)
    {
        Console.Write("Please enter the number {0} as a positive number again: ", (i + 1));
        number = Console.ReadLine();
        while (!Int32.TryParse(number, out value))
        {
            Console.Write("Please enter a numeric value: ");
            number = Console.ReadLine();
            if (Int32.TryParse(number, out value))
            {
                value = Convert.ToInt32(number);
            }
        }
    }
    //blocking negative number - end

    //sending numbers to lists according to prime numbers - start
    numberList.Add(number);
    if (IsPrimeNumber(Convert.ToInt32(numberList[i])) == true)
    {
        primeNumberList.Add(numberList[i]);
    }
    else if (IsPrimeNumber(Convert.ToInt32(numberList[i])) == false)
    {
        notPrimeNumberList.Add(numberList[i]);
    }
    //sending numbers to lists according to prime numbers - end
}
decimal averageOfPrimeNumbers = 0;
decimal averageOfNotPrimeNumbers = 0;
//WRITELINE BLOCKS -START
Console.Write("Prime numbers : ");
foreach (var item in primeNumberList)
{
    averageOfPrimeNumbers += Convert.ToDecimal(item);
    Console.Write(item.ToString() + ", ");
}
Console.WriteLine("");
Console.Write("Not Prime numbers : ");
foreach (var item in notPrimeNumberList)
{
    averageOfNotPrimeNumbers += Convert.ToDecimal(item);
    Console.Write(item.ToString() + ", ");
}
Console.WriteLine("");
Console.WriteLine("*********************************************");
Console.WriteLine("The Prime numbers that are sorted from largest to smallest : ");
primeNumberList.Reverse();
foreach (var item in primeNumberList)
{
    Console.Write(item + ", ");
}
Console.WriteLine("");
Console.WriteLine("The average of prime numbers : " + averageOfPrimeNumbers / primeNumberList.Count);
Console.WriteLine("The number of numbers are prime numbers : " + primeNumberList.Count);
Console.WriteLine("*********************************************");
Console.WriteLine("The Not Prime numbers that are sorted from largest to smallest : ");
notPrimeNumberList.Reverse();
foreach (var item in notPrimeNumberList)
{
    Console.Write(item + ", ");
}
Console.WriteLine("");
Console.WriteLine("The average of not prime numbers : " + averageOfNotPrimeNumbers / notPrimeNumberList.Count);
Console.WriteLine("The number of the numbers are not prime numbers : " + notPrimeNumberList.Count);
Console.WriteLine("*********************************************");



//WRITELINE BLOCKS - END


//checking whether if a prime number 
//what is the prime number? 
//prime number is the number that can not divide by 
//a number except 1 and itself  
//EXAMPLE -> 7 ----> 2,3,4,5,6(these numbers can not divide the number 7)
//now lets write the algorithm checks whether if a number is a prime number
// The algorithm is ready!!! I prepared this algorithm to check only one number
//So, lets rewrite the code block to make this algorithm to check a number of array.
//for checking the numbers in array, lets use a for loop.


bool IsPrimeNumber(int number)
{
    bool isPrime = false;

    for (int i = 2; i < number; i++)
    {
        if (number % i == 0)
        {
            isPrime = false;
            break;
        }
        else
        {
            isPrime = true;
        }
    }
    if (number == 2)
    {
        isPrime = true;
    }
    // if (isPrime)
    // {
    //     Console.WriteLine(number + " is a prime number");
    // }
    // else if (isPrime == false)
    // {
    //     Console.WriteLine(number + " is not a prime number");
    // }
    return isPrime;
}


