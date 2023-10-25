// Değer tipler
// int, bool, char, double, float
// Değer tipler null değer alamazlar
// Hafızanın stack kısmında depolanır


// Referans tipler
// string, ArryList, List, Map, enum, class ve interface
// referans tipler null değer alabilirler

//int? a = null; // soru işartei koyduğumuzda bunun anlamı benim a değişkenim null değer alabilir olarak atanır 

//string ad = "Berfin Özkahraman";
//Console.WriteLine($" ad metninde a harfi var mı: {ad.Contains("a")}");
//Console.WriteLine(ad.ToUpper()); // ToUpper ad kısmındaki bütün harfleri büyütmek için kullanılır.


// Collections
//using System.Threading.Channels;

//string[] sehirler = { "Elazığ", "Kahramanmaraş", "Malatya", "Ankara" };
//Console.WriteLine(sehirler[0]);
//Console.WriteLine(sehirler[1]);
//Console.WriteLine(sehirler[2]);

// 1. Yöntem For döngüsü ile
//for(int i =0;i<sehirler.Length; i++) // lenght şehirler dizisinin eleman sayısı kadar bak
//{
//    Console.WriteLine(sehirler[i]);
//}
//// Foreach Yöntemi ile
//// Seed Data 
//int [] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//foreach (int sayi in sayilar)
//{
//    Console.WriteLine(sayi);
//}
// Listeler
// 2. Yöntem
//List<string> meyveler = new List<string>()
//{
//    "Karpuz", "Çilek", "Elma"
//};
//meyveler.Add("Kavun"); // Add tekli veri eklemek için kullanılır
//meyveler.Add("Armut");

//List<string> eklenecekMeyveler = new List<string>()
//{
//    "Ejderha Meyvesi", "Mango"
//};
//meyveler.AddRange(eklenecekMeyveler); // AddRange çoklu veri eklemek için kullanılır
////foreach (string meyve in meyveler )
////{
////    Console.WriteLine(meyve);
////}


////predicate, lambda
//meyveler.ForEach(meyve => Console.WriteLine(meyve));
//List<string> sebzeler = new ();


//List<int> numbers = new()
//{
//    1,4,2,3,7,6,8,9,11,10,5
//};
//numbers.Sort();// küçükten büyüğe sıralar
//numbers.Reverse(); // büyükten küçüğe sıralar

//numbers.Remove(7); // Listede 7 olan elemanı siler
//numbers.ForEach(number => Console.WriteLine(number));

//Console.WriteLine($"listedeki 3 olan değerin indexi: {numbers.IndexOf(3)}");
//Console.WriteLine($"listedeki tüm elemanların toplamı: {numbers.Sum()}");
//Console.WriteLine($"listedeki en küçük eleman: {numbers.Min()}");
//Console.WriteLine($"listedeki en büyük eleman: {numbers.Max()}");



//List<int> numbers1 = new()
// for yöntemi
//{
//1,4,2,3,7,6,8,9,11,10,5
//};

//List<int> evenNumbers = new();
//for (int i = 0; i < numbers1.Count; i++) // Count elemanların sayısını önümüze getirir
//{
//    if (numbers1[i] % 2 == 0)
//    {
//        evenNumbers.Add(numbers[i]);
//    }
//}
//for (int i = 0; i < evenNumbers.Count; i++)
//{
//    Console.WriteLine(evenNumbers[i]);
//}
//// foreach yöntemi
//foreach (int number in numbers1)
//{
//    if (number %2 ==0)
//    {
//        evenNumbers.Add(number);
//    }
//}
// 
//evenNumbers = numbers1.FindAll(even=> even %2 ==0); //foreachle olan kısmın kısaltılmış hali
//evenNumbers.ForEach(number => Console.WriteLine(number));


// sebzeler listesine 3 eleman ekle onları listele 
// bu listede 2. İndexteki sebze adını ekrana bastırın 
// bu listede küçük harflerle yazılanları büyük harflerle yazsın

using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

List<string> sebzeler = new()
{
    "Patlıcan", "Brokoli", "Ispanak"
};
sebzeler.Add("Patates");
sebzeler.Add("Biber");
sebzeler.Add("Domates");

foreach (string sebze in sebzeler)
{
    Console.WriteLine(sebze);
}
Console.WriteLine($"2. Indexte ki eleman: {sebzeler[2]}");
foreach (string sebze in sebzeler)
{
    Console.WriteLine(sebze.ToUpper());
}
sebzeler.ForEach(sebze => Console.WriteLine(sebze.ToUpper()));

