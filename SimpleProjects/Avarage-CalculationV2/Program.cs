// Şu ana kadar verilen ödev sayısı
int currentAssignments = 5;

// Öğrenci isimlerinin tanımlanması
string[] studentName = new string[] { "Ahmet", "Mehmet", "Ecem", "Zehra" };

// Her öğrencinin aldığı notlar
int[] ahmetNotlar = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] mehmetNotlar = new int[] { 92, 89, 81, 96, 90, 89 };
int[] ecemNotlar = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] zehraNotlar = new int[] { 90, 95, 87, 88, 96, 96 };

// Mevcut ödev sayısını sınav ödev sayısına atama
int examAssignments = currentAssignments;

// Ekrana çıktıyı temizle ve başlık satırını yaz
Console.Clear();
Console.WriteLine("Öğrenci\t\tNot\tNot Harfı\n");

// Öğrenci isimleri üzerinde döngü başlatma
foreach (string student in studentName)
{
    // Geçerli öğrencinin notlarını almak için bir dizi tanımlama
    int[] studentNotes;

    // Öğrencinin adına göre hangi not setini kullanacağını belirle
    if (student == "Ahmet")
        studentNotes = ahmetNotlar;
    else if (student == "Mehmet")
        studentNotes = mehmetNotlar;
    else if (student == "Ecem")
        studentNotes = ecemNotlar;
    else if (student == "Zehra")
        studentNotes = zehraNotlar;
    else
        continue; // Bilinmeyen öğrenci isimlerini atla

    // Öğrenci notlarını toplamak için değişkenleri sıfırlama
    int totalHomeworkNotes = 0;
    decimal studentGrade = 0;
    int gradedAssignments = 0;

    // Öğrenci notlarını toplama
    foreach (int note in studentNotes)
    {
        gradedAssignments += 1;

        // Ekstra kredi ödevleri, sınav notlarının %10'unun değerindedir
        if (gradedAssignments <= examAssignments)
            totalHomeworkNotes += note;
        else
            totalHomeworkNotes += note / 10;
    }

    // Öğrenci not ortalamasını hesaplama
    studentGrade = (decimal)(totalHomeworkNotes) / examAssignments;

    // Öğrenci harf notunu belirleme
    string studentLetterGrade = "";

    // Not aralıklarına göre harf notunu belirleme
    if (studentGrade >= 97)
        studentLetterGrade = "A+";
    else if (studentGrade >= 93)
        studentLetterGrade = "A";
    else if (studentGrade >= 90)
        studentLetterGrade = "A-";
    else if (studentGrade >= 87)
        studentLetterGrade = "B+";
    else if (studentGrade >= 83)
        studentLetterGrade = "B";
    else if (studentGrade >= 80)
        studentLetterGrade = "B-";
    else if (studentGrade >= 77)
        studentLetterGrade = "C+";
    else if (studentGrade >= 73)
        studentLetterGrade = "C";
    else if (studentGrade >= 70)
        studentLetterGrade = "C-";
    else if (studentGrade >= 67)
        studentLetterGrade = "D+";
    else if (studentGrade >= 63)
        studentLetterGrade = "D";
    else if (studentGrade >= 60)
        studentLetterGrade = "D-";
    else
        studentLetterGrade = "F";

    // Öğrenci notunu ve harf notunu ekrana yazma
    Console.WriteLine($"{student}\t\t{studentGrade}\t{studentLetterGrade}");
}

// Sonuçları görüntülemek için ekranın açık kalmasını sağlama
Console.WriteLine("\nDevam etmek için Enter tuşuna basın");
Console.ReadLine();
