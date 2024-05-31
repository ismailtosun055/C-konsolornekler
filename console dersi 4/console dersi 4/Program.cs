internal class Program
{
    private static void Main(string[] args)
    {
        int vize=0,final=0;
        float ort = 0;

        Console.Write("vize notunuzu giriniz:");
        vize=Convert.ToInt32(Console.ReadLine());

        Console.Write("final notunuzu giriniz:");
        final =Convert.ToInt32(Console.ReadLine());

        ort = (float)vize * 0.4f + final * 0.6f;
        Console.WriteLine("ortalamanız:"+ort);
        if (ort >= 80)
        {
            Console.WriteLine("harf notu:AA");
        }
        else if (ort >= 70)
        {
            Console.WriteLine("harf notu:BA");
        }
        else if (ort >= 65)
        {
            Console.WriteLine("harf notu:BB");
        }
        else if (ort >= 55)
        {
            Console.WriteLine("harf notu:CB");
        }
        else if (ort >= 45)
        {
            Console.WriteLine("harf notu:CC");
        }
        else
        {
            Console.WriteLine("harf notu:DC\nmalesef dersten kaldınız:(");
        }

        Console.ReadLine();
    }
}