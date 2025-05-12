Console.WriteLine("Kim Milyoner Olmak Yarışmasına Hoş Geldiniz");

Console.Write("Adınızı Girin: ");

string yarismaciAdi = Console.ReadLine();

Console.WriteLine("Sayın "+ yarismaciAdi + " yarışmamızda sorulacak 3 sorudan 2'sini doğru bilmeniz durumunda 1 MİLYON TL büyük ödülü kazanacaksınız.");


Console.WriteLine("1. Soru: Kızınca tüküren hayvan hangisidir ?");
Console.WriteLine("Şıklar:");
Console.WriteLine("A) Lama");
Console.WriteLine("B) Deve");

char cevap1= Convert.ToChar(Console.ReadLine().ToUpper()); //tek karakter girileceği için char kullandım onu da stringten convert ediyorum. Aynı zamanda büyük-küçük harf duyarlılığı ortadan kaldırılıyor.
//doğru cevapları tutmak için tanım
int sayac = 0;

if (cevap1 == ('A'))
{
    Console.WriteLine("Doğru cevabı verdiniz.");
    sayac++; //burada 1 artırıyorum
}
else
{
    Console.WriteLine("Yanlış cevabı verdiniz.");
}

Console.WriteLine("2. Soru: Dünya'ya en yakın gezegen hangisidir ?");
Console.WriteLine("Şıklar:");
Console.WriteLine("A) Venüs");
Console.WriteLine("B) Mars");

char cevap2 = Convert.ToChar(Console.ReadLine().ToUpper()); //tek karakter girileceği için char kullandım onu da stringten convert ediyorum. Aynı zamanda büyük-küçük harf duyarlılığı ortadan kaldırılıyor.

if (cevap2 == ('B'))
{
    Console.WriteLine("Doğru cevabı verdiniz.");
    sayac++; //burada 1 artırıyorum
}
else
{
    Console.WriteLine("Yanlış cevabı verdiniz.");
}

if (sayac == 0) //eğer iki soruda yanlışsa kullanıcı kaybediyor
{
    Console.WriteLine("Yarışmayı Kaybettiniz!");
}

else 
{
    Console.WriteLine("3. Soru: Türkiye'nin başkenti neresidir?");
    Console.WriteLine("Şıklar:");
    Console.WriteLine("A) Ankara");
    Console.WriteLine("B) İstanbul");

    char cevap3 = Convert.ToChar(Console.ReadLine().ToUpper()); //tek karakter girileceği için char kullandım onu da stringten convert ediyorum. Aynı zamanda büyük-küçük harf duyarlılığı ortadan kaldırılıyor.

    if (cevap3 == ('A'))
    {
        Console.WriteLine("Doğru cevabı verdiniz.");
        sayac++; //burada 1 artırıyorum
    }
    else
    {
        Console.WriteLine("Yanlış cevabı verdiniz.");
    }

    if (sayac >= 2) //toplamda doğru cevap sayısı 2'ye eşit veya 2'den fazla ise yarışmayı kazanıyor.
    {
        Console.WriteLine($"Büyük ödül olan 1 MİLYON TL'yi kazandınız. Toplam doğru sayınız: {sayac}");
    }
    else //toplamda doğru cevap sayısı 2'ye eşit veya 2'den fazla değilse ise yarışmayı kaybediyor.
    {
        Console.WriteLine($"Büyük ödül olan 1 MİLYON TL'yi kaybettiniz. Toplam doğru sayınız: {sayac}");
    }
}