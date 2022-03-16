Console.WriteLine("The Number Of Worker: {0}", Worker.WorkerNumber);

Worker worker1 = new Worker("Ayşe", "Yılmaz", "HR");
Console.WriteLine("The Number Of Worker: {0}", Worker.WorkerNumber);
Worker worker2 = new Worker("Deniz", "Arda", "HR");
Worker worker3 = new Worker("Zikriye", "Ürkmez", "HR");

Console.WriteLine("The Number Of Worker: {0}", Worker.WorkerNumber);

Console.WriteLine("The result of adding operation: {0}", Operations.Add(100, 200));
Console.WriteLine("The result of  operation: {0}", Operations.Substract(400, 50));


class Worker
{
    private static int workerNumber;
    public static int WorkerNumber { get => workerNumber; }
    private string Name;
    private string Surname;
    private string Department;
    static Worker()
    {
        workerNumber = 0;
    }
    public Worker(string name, string surname, string department)
    {
        this.Name = name;
        this.Surname = surname;
        this.Department = department;
        workerNumber++;
    }
}

static class Operations
{
    public static long Add(int number1, int number2)
    {
        return number1 + number2;
    }

    public static long Substract(int number1, int number2)
    {
        return number1 - number2;
    }
}