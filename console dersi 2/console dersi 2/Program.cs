internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        string ad, soyad, yas, meslek_adi, sehir;
        Console.WriteLine("lutfen sirasi ile adinizi,soyadinizi,yasinizi,mesleginizi ve sehrinizi giriniz:");
        ad = Console.ReadLine();
        soyad = Console.ReadLine();
        yas = Console.ReadLine();
        meslek_adi = Console.ReadLine();
        sehir = Console.ReadLine();
        Console.WriteLine("\nad:{0}\nsoyad:{1}\nyas:{2}\nmeslek:{3}\nsehir:{4}",ad,soyad,yas,meslek_adi,sehir);
       
        Console.ReadLine();
    }
}