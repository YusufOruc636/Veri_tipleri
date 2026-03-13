// kur bilgileri ve tarih

var dollarRate = 27.5m;
decimal euroRate = 30.2m;
decimal goldRate = 1800.75m;
DateTime rateDate= DateTime.Now;

Console.WriteLine("tl miktarınızı giriniz: ");
decimal tlAmount = Convert.ToDecimal(Console.ReadLine());

// menü

Console.WriteLine("\n donüstürme işlemleri");
Console.WriteLine("1- dolar");
Console.WriteLine("2- euro");
Console.WriteLine("3- altın");

Console.WriteLine("secminizi yapınız: (1-3)");
int choice=Convert.ToInt32(Console.ReadLine());

decimal result = 0m;
string currencyName = "";

switch (choice)
{
    case 1:
        result = tlAmount / dollarRate;
        currencyName = "dolar";
        break;
    case 2:
        result = tlAmount / euroRate;
        currencyName = "euro";
        break;
    case 3:
        result = tlAmount / goldRate;
        currencyName = "altın";
        break;
    default:
        Console.WriteLine("geçersiz seçim");
        return;
}

Console.WriteLine($"\n tarih: {rateDate}");
Console.WriteLine($"girilen tl miktarı {tlAmount}");
Console.WriteLine($"donüsüm sonucu: {result:F2} {currencyName}");
