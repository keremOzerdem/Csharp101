Rectangle rectangle = new Rectangle();
// rectangle.ShortEdge = 3;
// rectangle.LongEdge = 4;
Console.WriteLine("The area of rectangle : {0}", rectangle.CalculateArea());

Rectangle_Struct rectangle_struct;
rectangle_struct.ShortEdge = 3;
rectangle_struct.LongEdge = 4;
Console.WriteLine("The area of rectangle : {0}", rectangle_struct.CalculateArea());

class Rectangle
{
    public int ShortEdge;
    public int LongEdge;
    // public Rectangle()
    // {
    //     ShortEdge = 3;
    //     LongEdge = 4;
    // }
    public long CalculateArea()
    {
        return this.ShortEdge * this.LongEdge;
    }
}

struct Rectangle_Struct
{
    public int ShortEdge;
    public int LongEdge;
    public Rectangle_Struct(int shortEdge, int longEdge)
    {
        ShortEdge = shortEdge;
        LongEdge = longEdge;
    }
    public long CalculateArea()
    {
        return this.ShortEdge * this.LongEdge;
    }
}