string carpma = "*";
string bolme = "/";
string toplama = "+";
string cıkarma = "-";

Console.Write("1.sayı:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("2.Sayı:");
int number2= Convert.ToInt32(Console.ReadLine());

Console.Write("seç işlem işaretini koyun :\n carpma\n bolme\n toplama\n cıkarma\n ");
string ıslem = Console.ReadLine();
if (ıslem == carpma)
{
    Console.Write(number1 * number2);
}
else if (ıslem == bolme)
    if (number2 == 0)
    {
        Console.Write("tanımsızdır");
    }
    else
    {
        Console.Write(number1 / number2);
    }
else if (ıslem == toplama)
    {
        Console.Write(number1 + number2);
    }
else if (ıslem == cıkarma)
    {
        Console.Write(number1 - number2);
    }
    
else if (number2 == 0)
    {
        Console.Write("tanımsızdır");
    }
   
else
    {
        Console.Write("Geçersiz değer kullandınız");
    }