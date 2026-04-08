Console.WriteLine("KALKULATOR SEDERHANA");
Console.WriteLine("1. Penjumlahan");
Console.WriteLine("2. Pengurangan");
Console.WriteLine("3. Perkalian");
Console.WriteLine("4. Pembagian");
Console.Write("Pilih menu (1-4): ");

int pilih = int.Parse(Console.ReadLine()!);

Console.Write("Masukan angka Pertama: ");
int var1 = int.Parse(Console.ReadLine()!);
Console.Write("Masukan angka Kedua: ");
int var2 = int.Parse(Console.ReadLine()!);

if (pilih == 1)
{
    Console.WriteLine("Hasil: " + (var1 + var2));
}

else if (pilih == 2)
{
    Console.WriteLine("Hasil: " + (var1 - var2));
}

else if (pilih == 3)
{
    Console.WriteLine("Hasil: " + (var1 * var2));
}

else if (pilih == 4)
{
    Console.WriteLine("Hasil: " + (var1 / var2));
}
