public class NumberModel
{
    // Constructor ile değişkenlerin atamasını gerçekleştirdik.
    public NumberModel(string name, string surname, string number)
    {
        this.Name = name;
        this.Surname = surname;
        this.Number = number;
    }

    //Değişkenleri get ve setlerine erişebilmek nedeniyle public yaptım 
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Number { get; set; }
}