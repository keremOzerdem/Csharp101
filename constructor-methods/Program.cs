/*
syntax
class className
{
   [access identifier] [data type] PropertyName;
   [access identifier] [return type] MethodName([Parameter List])
   {
       Method Commands
   }
}

//Access Identifiers
   - Public
   - Private
   - Internal
   - Protected
*/
Console.WriteLine("******* Worker 1 ******");
Worker worker1 = new Worker("Ayşe", "Kara", 23425634, "Human Resources");
worker1.WorkerInfo();

Console.WriteLine("******* Worker 2 ******");
Worker worker2 = new Worker();
worker2.Name = "Deniz";
worker2.Surname = "Arda";
worker2.WorkerNumber = 25646789;
worker2.Department = "The Purchasing";
worker2.WorkerInfo();

Console.WriteLine("******* Worker 3 ******");
Worker worker3 = new Worker("Zikriye", "Ürkmez");
worker3.WorkerInfo();

class Worker
{
    public string Name;
    public string Surname;
    public int WorkerNumber;
    public string Department;

    public Worker(string name, string surname, int workerNumber, string department)
    {
        this.Name = name;
        this.Surname = surname;
        this.WorkerNumber = workerNumber;
        this.Department = department;
    }

    public Worker(string name, string surname)
    {
        this.Name = name;
        this.Surname = surname;
    }
    public Worker() { }
    public void WorkerInfo()
    {
        Console.WriteLine("Worker Name: {0}", Name);
        Console.WriteLine("Worker Surname: {0}", Surname);
        Console.WriteLine("Worker Number: {0}", WorkerNumber);
        Console.WriteLine("Worker Department: {0}", Department);

    }
}