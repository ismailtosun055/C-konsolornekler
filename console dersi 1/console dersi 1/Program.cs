internal class Program
{
    private static void Main(string[] args)
    {
        string ad,soyad,yas,meslek_adi,sehir;
        Console.WriteLine("lutfen sirasi ile adinizi,soyadinizi,yasinizi,mesleginizi ve sehrinizi giriniz:");
        ad = Console.ReadLine();
        soyad = Console.ReadLine();
        yas = Console.ReadLine();
        meslek_adi = Console.ReadLine();
        sehir = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("adiniz:" + ad);
        Console.WriteLine("soyadiniz:"+soyad);
        Console.WriteLine("yasiniz:"+yas);
        Console.WriteLine("mesleginiz:"+meslek_adi);
        Console.Write("sehriniz:"+sehir);
        Console.ReadLine();

    }
}