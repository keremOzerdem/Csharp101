//out parametreler
string number = "999";


bool result = int.TryParse(number, out int outNumber);
if (result)
{
    Console.WriteLine("Successful!");
    Console.WriteLine(outNumber);
}
else
{
    Console.WriteLine("Unsuccessful!");
}

Methods instance = new Methods();
instance.Add(4, 5, out int resultofTotal);
Console.WriteLine(resultofTotal);

//Method Overloading

int expression = 999;
instance.PrintScreen(Convert.ToInt32(expression));
instance.PrintScreen(expression);
instance.PrintScreen("Kerem","Özerdem");
//Method signature
//methodAdı+parametre sayisi+parametre

class Methods
{
    public void Add(int a, int b, out int total)
    {
        total = a + b;
    }
    public void PrintScreen(string data)
    {
        Console.WriteLine(data);
    }
    public void PrintScreen(int data)
    {
        Console.WriteLine(data);
    }
    public void PrintScreen(string data1, string data2)
    {
        Console.WriteLine(data1 + data2);
    }
}