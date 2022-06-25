// See https://aka.ms/new-console-template for more information

class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Fibonacci seri uzunluğunu giriniz: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Fibonacci serisinin toplamı: {0}", fiboTop(num));
            Console.WriteLine("Fibonacci serisinin ortalaması: {0}\n", (double)fiboTop(num)/num);
        }
    }

    public static int fiboTop(int x)
    {
        if (x <= 2)
            return 1;
        else
            return fiboTop(x - 1) + fiboTop(x - 2);
    }
}