//erisim_belirteci geri_donustipi metot_adi(parametreListesi/arguman)
// {
// komutlar
//return;
// }

int a = 2;
int b = 3;

Console.WriteLine(a+b);

int result = Add(a,b);
Console.WriteLine(result);

Methods instance = new Methods();
instance.PrintTerminal(Convert.ToString(result));

int result2 = instance.IncreaseAndAdd(ref a,ref b);
instance.PrintTerminal(Convert.ToString(result2));
instance.PrintTerminal(Convert.ToString(a+b));

static int Add(int value1,int value2){
    return (value1+value2);
}

class Methods
{
    public void PrintTerminal(string data)
    {
        Console.WriteLine(data);
    }

    public int IncreaseAndAdd(ref int value1,ref int value2){
        value1+=1;
        value2+=1;
        return value1+value2;
    }
}