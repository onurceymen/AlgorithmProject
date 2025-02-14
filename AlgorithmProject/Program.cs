using AlgorithmProject.BasicAlgorithms;
using AlgorithmProject.SortingAlgorithms;
public class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("===== Algoritmalar Uygulamasına Hoş Geldiniz =====");
            Console.WriteLine("Lütfen bir kategori seçin:");
            Console.WriteLine("1. Sıralama Algoritmaları");
            Console.WriteLine("2. Arama Algoritmaları");
            Console.WriteLine("3. Graf ve Ağ Algoritmaları");
            Console.WriteLine("4. Zamanlama ve Kuyruk Algoritmaları");
            Console.WriteLine("5. Kriptografi Algoritmaları");
            Console.WriteLine("6. Optimizasyon Algoritmaları");
            Console.WriteLine("7. Matematik ve Geometri Algoritmaları");
            Console.WriteLine("8. Basic Algoritms");
            Console.WriteLine("0. Çıkış");
            Console.Write("Seçiminiz: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    SortingAlgorithmsMenu();
                    break;
                case "2":
                    SearchAlgorithmsMenu();
                    break;
                case "3":
                    GraphAndNetworkAlgorithmsMenu();
                    break;
                case "4":
                    SchedulingAndQueueAlgorithmsMenu();
                    break;
                case "5":
                    CryptographicAlgorithmsMenu();
                    break;
                case "6":
                    OptimizationAlgorithmsMenu();
                    break;
                case "7":
                    MathAndGeometryAlgorithmsMenu();
                    break;
                case "8":
                    BasicAlgorithmsMenu();
                    break;
                case "0":
                    Console.WriteLine("Çıkış yapılıyor...");
                    return;
                default:
                    Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                    break;
            }

            Console.WriteLine("Devam etmek için bir tuşa basın...");
            Console.ReadKey();
        }
    }
    static void SortingAlgorithmsMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("===== Sıralama Algoritmaları =====");
            Console.WriteLine("1. Bubble Sort");
            Console.WriteLine("2. Quick Sort");
            Console.WriteLine("3. Merge Sort");
            Console.WriteLine("4. Heap Sort");
            Console.WriteLine("5. Insertion Sort");
            Console.WriteLine("6. Selection Sort");
            Console.WriteLine("7. Counting Sort");
            Console.WriteLine("0. Geri");
            Console.Write("Seçiminiz: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    int[] array = { 64, 34, 25, 12, 22, 11, 90 };
                    Console.WriteLine($"Başlangıç Dizisi: {string.Join(", ", array)}");
                    BubbleSort bubbleSort = new BubbleSort();
                    bubbleSort.Sort(array);
                    Console.WriteLine($"Sıralı Dizi: {string.Join(", ", array)}");
                    break;
                case "2":
                    int[] arrayQuick = { 10, 7, 8, 9, 1, 5 };
                    Console.WriteLine($"Başlangıç Dizisi: {string.Join(", ", arrayQuick)}");
                    QuickSort quickSort = new QuickSort();
                    quickSort.Sort(arrayQuick, 0, arrayQuick.Length - 1);
                    Console.WriteLine($"Sıralı Dizi: {string.Join(", ", arrayQuick)}");
                    break;
                case "3":
                    int[] arrayMerge = { 12, 11, 13, 5, 6, 7 };
                    Console.WriteLine($"Başlangıç Dizisi: {string.Join(", ", arrayMerge)}");
                    MergeSort mergeSort = new MergeSort();
                    mergeSort.Sort(arrayMerge, 0, arrayMerge.Length - 1);
                    Console.WriteLine($"Sıralı Dizi: {string.Join(", ", arrayMerge)}");
                    break;

                default:
                    Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                    break;
            }

            Console.WriteLine("Devam etmek için bir tuşa basın...");
            Console.ReadKey();
        }
    }
    static void SearchAlgorithmsMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("===== Arama Algoritmaları =====");
            Console.WriteLine("1. Binary Search");
            Console.WriteLine("2. Linear Search");
            Console.WriteLine("3. Jump Search");
            Console.WriteLine("0. Geri");
            Console.Write("Seçiminiz: ");
            string choice = Console.ReadLine();

            if (choice == "0")
            {
                return;
            }
            else
            {
                Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
            }

            Console.WriteLine("Devam etmek için bir tuşa basın...");
            Console.ReadKey();
        }
    }
    static void GraphAndNetworkAlgorithmsMenu() {}
    static void SchedulingAndQueueAlgorithmsMenu() {}
    static void CryptographicAlgorithmsMenu() {}
    static void OptimizationAlgorithmsMenu() {}
    static void MathAndGeometryAlgorithmsMenu() {}
    static void BasicAlgorithmsMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Lütfen bir algoritma seçin:");
            Console.WriteLine("1. En Küçük Sayıyı Bul");
            Console.WriteLine("2. String Ters Çevir");
            Console.WriteLine("3. Tekrar Eden Sayıları Bul");
            Console.WriteLine("4. Tek ve Çift Sayıları Ayır");
            Console.WriteLine("5. En Büyük Sayıyı Bul");
            Console.WriteLine("6. Palindrom Kontrolü");
            Console.WriteLine("7. Fibonacci Hesapla");
            Console.WriteLine("8. Faktöriyel Hesapla");
            Console.WriteLine("0. Çıkış");
            Console.Write("Seçiminiz: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    FindSmallestNumberExample();
                    break;
                case "2":
                    ReverseStringExample();
                    break;
                case "3":
                    FindDuplicatesExample();
                    break;
                case "4":
                    SeparateEvenOddExample();
                    break;
                case "5":
                    FindLargestNumberExample();
                    break;
                case "6":
                    IsPalindromeExample();
                    break;
                case "7":
                    FibonacciExample();
                    break;
                case "8":
                    FactorialExample();
                    break;
                case "0":
                    Console.WriteLine("Çıkış yapılıyor...");
                    return;
                default:
                    Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                    break;
            }

            Console.WriteLine("\nDevam etmek için bir tuşa basın...");
            Console.ReadKey();
        }
        static void FindSmallestNumberExample()
        {
            int[] numbers = { 3, 1, 5, 7, 2 };
            int min = RandomAlgoritms.FindSmallestNumber(numbers);
            Console.WriteLine($"En küçük sayı: {min}");
        }

        static void ReverseStringExample()
        {
            string input = "hello";
            string reversed = RandomAlgoritms.ReverseString(input);
            Console.WriteLine($"Ters çevrilmiş string: {reversed}");
        }

        static void FindDuplicatesExample()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 2, 4, 7 };
            int[] duplicates = RandomAlgoritms.FindDuplicates(numbers);
            Console.WriteLine($"Tekrar eden sayılar: {string.Join(", ", duplicates)}");
        }

        static void SeparateEvenOddExample()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            var (evens, odds) = RandomAlgoritms.SeparateEvenOdd(numbers);
            Console.WriteLine($"Çift sayılar: {string.Join(", ", evens)}");
            Console.WriteLine($"Tek sayılar: {string.Join(", ", odds)}");
        }

        static void FindLargestNumberExample()
        {
            int[] numbers = { 3, 1, 5, 7, 2 };
            int max = RandomAlgoritms.FindLargestNumber(numbers);
            Console.WriteLine($"En büyük sayı: {max}");
        }

        static void IsPalindromeExample()
        {
            string word = "radar";
            bool result = RandomAlgoritms.IsPalindrome(word);
            Console.WriteLine($"'{word}' bir palindrom mu? {result}");
        }

        static void FibonacciExample()
        {
            int n = 7;
            int fib = RandomAlgoritms.Fibonacci(n);
            Console.WriteLine($"{n}. Fibonacci sayısı: {fib}");
        }

        static void FactorialExample()
        {
            int n = 5;
            int factorial = RandomAlgoritms.Factorial(n);
            Console.WriteLine($"{n}! = {factorial}");
        }
    }
}
