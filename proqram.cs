using System;

class Program
{
    static IsciBazasi hrBaza = new IsciBazasi();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n========== HR mini ERP ==========");
            Console.WriteLine("1. İşçi əlavə et");
            Console.WriteLine("2. İşçi bazasını göstər");
            Console.WriteLine("3. Sistemdən çıxış");
            Console.WriteLine("4. İşçi sil");
            Console.WriteLine("5. Maaşa görə axtar");
            Console.WriteLine("=================================");

            Console.Write("Seçim: ");

            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":

                    Isci yeni = new Isci();

                    Console.Write("Ad: ");
                    yeni.Ad = Console.ReadLine();

                    Console.Write("Soyad: ");
                    yeni.Soyad = Console.ReadLine();

                    Console.Write("Vəzifə: ");
                    yeni.Vezife = Console.ReadLine();

                    Console.Write("Maaş: ");
                    yeni.Maas = decimal.Parse(Console.ReadLine());

                    hrBaza.ElaveEt(yeni);

                    break;

                case "2":

                    hrBaza.Baza();

                    break;

                case "3":

                    Console.WriteLine("Çıxış edilir...");
                    return;

                case "4":

                    Console.Write("Silinəcək ID: ");
                    int silID = int.Parse(Console.ReadLine());

                    hrBaza.Sil(silID);

                    break;

                case "5":

                    Console.Write("Minimum maaş: ");
                    decimal limit = decimal.Parse(Console.ReadLine());

                    hrBaza.LimitdenCox(limit);

                    break;

                default:

                    Console.WriteLine("Yanlış seçim!");
                    break;
            }
        }
    }
}
