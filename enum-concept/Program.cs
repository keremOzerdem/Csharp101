Console.WriteLine(Days.Sunday);
Console.WriteLine((int)Days.Saturday);

int temperature = 32;

if (temperature <= (int)WeatherForecast.Normal)
{
    Console.WriteLine("Wait for warming the air to go outside.");
}
else if (temperature >= (int)WeatherForecast.Hot)
{
    Console.WriteLine("It is a hot day to go outside");
}
else if (temperature >= (int)WeatherForecast.Normal && temperature < (int)WeatherForecast.SoHot)
{
    Console.WriteLine("Let's go outside!");
}

enum Days
{
    Monday = 1,
    Tuesday,
    Wednesday,
    Thursday,
    Friday = 23,
    Saturday,
    Sunday
}

enum WeatherForecast
{
    Cold = 5,
    Normal = 20,
    Hot = 25,
    SoHot = 30
}