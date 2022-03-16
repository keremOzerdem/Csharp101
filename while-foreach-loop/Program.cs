// // While
// // 1 den başlayarak console dan girilen sayıya kadar
// // (sayı dahil) ortalama hesaplayıp console a 
// // yazdıran program
// Console.Write("Please enter a number: ");
// int number = int.Parse(Console.ReadLine());
// int count = 1;
// int total = 0;
// while (count <= number)
// {
//     total += count;
//     count++;
// }
// Console.WriteLine(total/number);

// // 'a' dan 'z' ye kadar tüm harfleri console a yazdır.
// char character = 'a';
// while (character<'z')
// {
//     Console.Write(character);
//     character++;
// }

Console.WriteLine("***** Foreach *****");
string[] cars = {"BMW","Ford","Toyota","Nissan"};

foreach (var car in cars)
{
    Console.WriteLine(car);
}