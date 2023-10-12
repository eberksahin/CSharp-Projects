// Üç zar atılıp, sonuçlara göre ödüllerin dağıtıldığı bir program

// Random sınıfından bir zar için nesne oluşturma
Random dice = new Random();

// 1 ile 6 arasında (1 ve 6 dahil) rastgele bir sayı üretme (3 kere zar atılıyor)
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

// Üç zar atışının toplamını hesaplama
int total = roll1 + roll2 + roll3;

// Zar atış sonuçlarını ve toplamını ekrana yazdırma
Console.WriteLine($"Zar atma: {roll1} + {roll2} + {roll3} = {total}");

// Eğer üç zarın herhangi ikisi aynıysa 
if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    // Eğer üç zar da aynıysa
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("Sonuç : Üçlü attın! Toplamda +6 Puan Bonus kazandın!");
        total += 6; // 6 puan bonus ekleniyor
    }
    // Eğer sadece iki zar aynıysa
    else
    {
        Console.WriteLine("Sonuç : Çifte yuvarladın! Toplamda +2 bonus!");
        total += 2; // 2 puan bonus ekleniyor
    }
}

// Toplam puana göre ödüllerin dağıtılması

// Eğer toplam 16 veya üzeriyse
if (total >= 16)
{
    Console.WriteLine("Ödül : Bir Araba kazandın!");
}
// Eğer toplam 10 veya üzeri ama 16'dan düşükse
else if (total >= 10)
{
    Console.WriteLine("Ödül : Yeni bir laptop kazandın!");
}
// Eğer toplam tam olarak 7 ise
else if (total == 7)
{
    Console.WriteLine("Ödül : İki kişilik bir tatil kazandın!");
}
// Diğer tüm sonuçlar için
else
{
    Console.WriteLine("Ödül : Bir Oyuncak ayı kazandın!");
}
