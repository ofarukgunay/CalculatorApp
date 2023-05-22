internal class Program
{
    static void Main(string[] args)
    {
        double sayi1, sayi2, sonuc;
        string islem;

        Console.WriteLine("İlk sayıyı girin: ");
        sayi1 = double.Parse(Console.ReadLine());

        Console.WriteLine("İkinci sayıyı girin: ");
        sayi2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Yapılacak işlemi girin (+, -, *, /): ");
        islem = Console.ReadLine();

        switch (islem)
        {
            case "+":
                sonuc = sayi1 + sayi2;
                Console.WriteLine(sayi1 + " + " + sayi2 + " = " + sonuc);
                break;

            case "-":
                sonuc = sayi1 - sayi2;
                Console.WriteLine(sayi1 + " - " + sayi2 + " = " + sonuc);
                break;

            case "*":
                sonuc = sayi1 * sayi2;
                Console.WriteLine(sayi1 + " * " + sayi2 + " = " + sonuc);
                break;

            case "/":
                if (sayi2 == 0)
                {
                    Console.WriteLine("Hata: Sıfıra bölme hatası!");
                }
                else
                {
                    sonuc = sayi1 / sayi2;
                    Console.WriteLine(sayi1 + " / " + sayi2 + " = " + sonuc);
                }
                break;

            default:
                Console.WriteLine("Hatalı işlem seçimi!");
                break;
        }

        Console.ReadLine();
    }


}