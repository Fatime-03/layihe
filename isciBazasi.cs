using System;
using System.Collections.Generic;

public class IsciBazasi
{
    public List<Isci> isciler = new List<Isci>();

    public void ElaveEt(Isci yeni)
    {
        yeni.Id = isciler.Count + 1;
        isciler.Add(yeni);
        Console.WriteLine("\n>>> İşçi uğurla əlavə edildi.");
    }

    public void Baza()
    {
        Console.WriteLine("\n--- İşçi Bazası ---");

        if (isciler.Count == 0)
        {
            Console.WriteLine("Siyahıda işçi yoxdur.");
            return;
        }

        foreach (var item in isciler)
        {
            Console.WriteLine($"ID: {item.Id} | Ad: {item.Ad} | Soyad: {item.Soyad} | Vəzifə: {item.Vezife} | Maaş: {item.Maas}");
        }
    }

    public void Sil(int id)
    {
        var tapildi = isciler.Find(i => i.Id == id);

        if (tapildi != null)
        {
            isciler.Remove(tapildi);
            Console.WriteLine($"\n>>> {tapildi.Ad} {tapildi.Soyad} sistemdən silindi.");
        }
        else
        {
            Console.WriteLine("\n>>> Xəta: Bu ID-yə uyğun işçi tapılmadı.");
        }
    }

    public void LimitdenCox(decimal limit)
    {
        Console.WriteLine($"\n--- Maaşı {limit}-dən çox olanlar ---");

        bool tapildi = false;

        foreach (var item in isciler)
        {
            if (item.Maas > limit)
            {
                Console.WriteLine($"Ad: {item.Ad} | Soyad: {item.Soyad} | Maaş: {item.Maas}");
                tapildi = true;
            }
        }

        if (!tapildi)
        {
            Console.WriteLine("Uyğun işçi tapılmadı.");
        }
    }
}
