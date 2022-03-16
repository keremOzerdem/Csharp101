//List<T> class
// System.Collections.Generic
// T-> its type is object

List<int> numberList = new List<int>();
numberList.Add(23);
numberList.Add(10);
numberList.Add(4);
numberList.Add(5);
numberList.Add(92);
numberList.Add(34);

List<string> colorList = new List<string>();
colorList.Add("Red");
colorList.Add("Blue");
colorList.Add("Orange");
colorList.Add("Yellow");
colorList.Add("Green");

//Count
Console.WriteLine(colorList.Count);
Console.WriteLine(numberList.Count());

//Accessing elements with foreach ve List.ForEach 
foreach (var number in numberList)
    Console.WriteLine(number);
foreach (var color in colorList)
    Console.WriteLine(color);

numberList.ForEach(number => Console.WriteLine(number));
colorList.ForEach(color => Console.WriteLine(color));

//Removing element from list
numberList.Remove(4);
colorList.Remove("Green");

numberList.RemoveAt(0);
colorList.RemoveAt(1);

numberList.ForEach(number => Console.WriteLine(number));
colorList.ForEach(color => Console.WriteLine(color));

//Searching at list
if (numberList.Contains(10))
    Console.WriteLine("The number 10 is found in the list.");

// Accesing the index via element
Console.WriteLine(colorList.BinarySearch("Yellow"));

//Converting array to list
string[] animals = { "Cat", "Dog", "Bird" };
List<string> animalList = new List<string>(animals);

//How can ı clear the list?
animalList.Clear();

//Holding an class in List
List<Users> userList = new List<Users>();
Users user1 = new Users();
user1.Name = "Ayşe";
user1.Surname = "Yılmaz";
user1.Age = 26;

Users user2 = new Users();
user2.Name = "Özcan";
user2.Surname = "Çalışkan";
user2.Age = 26;

userList.Add(user1);
userList.Add(user2);

List<Users> newList = new List<Users>();
newList.Add(new Users()
{
    Name = "Deniz",
    Surname = "Arda",
    Age = 24
});

foreach (Users user in userList)
{
    Console.WriteLine("User Name: " + user.Name);
    Console.WriteLine("User Surname: " + user.Surname);
    Console.WriteLine("User Age: " + user.Age);
}

newList.Clear();

public class Users
{
    private string name;
    private string surname;
    private int age;

    public string Name { get => name; set => name = value; }
    public string Surname { get => surname; set => surname = value; }
    public int Age { get => age; set => age = value; }
}

