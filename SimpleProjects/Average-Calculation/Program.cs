// Öğrencilerin ödev notlarına dair bir program

// Şu ana kadar verilmiş ödev sayısı
int currentAssignments = 5;

// Ahmet'in ödev notları
int ahmet1 = 93;
int ahmet2 = 87;
int ahmet3 = 98;
int ahmet4 = 95;
int ahmet5 = 100;

// Mehmet'in ödev notları
int mehmet1 = 70;
int mehmet2 = 74;
int mehmet3 = 30;
int mehmet4 = 40;
int mehmet5 = 88;

// Ecem'in ödev notları
int ecem1 = 54;
int ecem2 = 66;
int ecem3 = 78;
int ecem4 = 76;
int ecem5 = 90;

// Zehra'nın ödev notları
int zehra1 = 90;
int zehra2 = 49;
int zehra3 = 78;
int zehra4 = 94;
int zehra5 = 85;

// Öğrencilerin ödev notlarının toplamlarının hesaplanması
int ahmetSum = ahmet1 + ahmet2 + ahmet3 + ahmet4 + ahmet5;
int mehmetSum = mehmet1 + mehmet2 + mehmet3 + mehmet4 + mehmet5;
int ecemSum = ecem1 + ecem2 + ecem3 + ecem4 + ecem5;
int zehraSum = zehra1 + zehra2 + zehra3 + zehra4 + zehra5;

// Öğrencilerin ortalamalarının hesaplanması
decimal ahmetScore = (decimal)ahmetSum / currentAssignments;
decimal mehmetScore = (decimal)mehmetSum / currentAssignments;
decimal ecemScore = (decimal)ecemSum / currentAssignments;
decimal zehraScore = (decimal)zehraSum / currentAssignments;

// Öğrenci isimleri, ortalamaları ve derecelerinin ekrana yazdırılması
Console.WriteLine("Oğrenci\t\tDerece\n");
Console.WriteLine("Ahmet:\t\t" + ahmetScore + "\tA");
Console.WriteLine("Mehmet:\t\t" + mehmetScore + "\tB");
Console.WriteLine("Ecem:\t\t" + ecemScore + "\tB");
Console.WriteLine("Zehra:\t\t" + zehraScore + "\tA");

