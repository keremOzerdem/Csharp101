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
Worker worker1 = new Worker();
worker1.Name = "Ayşe";
worker1.Surname = "Kara";
worker1.WorkerNumber = 23425634;
worker1.Department = "Human Resources";
worker1.WorkerInfo();
Console.WriteLine("*************");

Worker worker2 = new Worker();
worker2.Name="Deniz";
worker2.Surname="Arda";
worker2.WorkerNumber=25646789;
worker2.Department="The Purchasing";

worker2.WorkerInfo();
class Worker
{
    public string Name;
    public string Surname;
    public int WorkerNumber;
    public string Department;
    public void WorkerInfo()
    {
        Console.WriteLine("Worker Name: {0}", Name);
        Console.WriteLine("Worker Surname: {0}", Surname);
        Console.WriteLine("Worker Number: {0}", WorkerNumber);
        Console.WriteLine("Worker Department: {0}", Department);

    }
}
