// isaretsiz byte
Console.WriteLine("isaretsiz byte (0-255)");
Console.WriteLine($"min deger: {byte.MinValue}, max deger: {byte.MaxValue}");

Console.WriteLine("sbyte (-128 - 128");
Console.WriteLine($"min deger: {sbyte.MinValue}, max deger: {sbyte.MaxValue}");

// isaretsiz degerlerde tasma
Console.WriteLine("");
byte unsignedValue = 255;
Console.WriteLine($"isaretsiz byte degeri: {unsignedValue}");
unsignedValue++;
Console.WriteLine($"isaretsiz byte degeri (tasma sonrasi): {unsignedValue}");

// ikili gosterim binary

Console.WriteLine("binary karısıklıklar");
Console.WriteLine($"Byte 255 : {Convert.ToString(255,2)}");
Console.WriteLine($"Byte 255: {Convert.ToString(15,2).PadLeft(8,'0')}");

Console.ReadKey();