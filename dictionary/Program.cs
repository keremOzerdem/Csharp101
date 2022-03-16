//system.collection.generic
Dictionary<int, string> users = new Dictionary<int, string>();
users.Add(10, "Ayşe Yılmaz");
users.Add(12, "Ahmet Yılmaz");
users.Add(18, "Deniz Arda");
users.Add(20, "Özcan Coşar");

//Accesing the elements of the series
Console.WriteLine("***** Accessing the Elements *****");
Console.WriteLine(users[12]);
foreach (var user in users)
    Console.WriteLine(user);

//Count
Console.WriteLine("***** Count *****");
Console.WriteLine(users.Count);

//Contains
Console.WriteLine("***** Contains *****");
Console.WriteLine(users.ContainsKey(12));
Console.WriteLine(users.ContainsValue("Zikriye Ürkmez"));

//Remove
Console.WriteLine("***** Remove *****");
users.Remove(12);
foreach (var user in users)
    Console.WriteLine(user.Value);

//Keys
Console.WriteLine("***** Keys *****");
foreach (var item in users.Keys)
    Console.WriteLine(item);

//Values
Console.WriteLine("***** Values *****");
foreach (var item in users.Values)
    Console.WriteLine(item);
