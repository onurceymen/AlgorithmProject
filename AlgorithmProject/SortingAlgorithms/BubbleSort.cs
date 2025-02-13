namespace AlgorithmProject.SortingAlgorithms
{
    public class BubbleSort
    {
        public void Sort(int[] elmalar)
        {
            int n = elmalar.Length;
            bool yerDegisti;

            Console.WriteLine("Sıralama işlemi başlıyor...");
            Thread.Sleep(1000);

            for (int i = 0; i < n - 1; i++)
            {
                yerDegisti = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (elmalar[j] > elmalar[j + 1])
                    {
                        int temp = elmalar[j];
                        elmalar[j] = elmalar[j + 1];
                        elmalar[j + 1] = temp;
                        yerDegisti = true;

                        Console.WriteLine($"Elma {elmalar[j + 1]} ve Elma {elmalar[j]} yer değiştirdi.");
                        Thread.Sleep(500);
                    }
                }

                if (!yerDegisti)
                {
                    Console.WriteLine("Hiçbir elma yer değiştirmedi, sıralama tamamlandı.");
                    break;
                }

                Console.WriteLine($"İterasyon {i + 1}: {string.Join(", ", elmalar)}");
                Thread.Sleep(1000);
            }

            Console.WriteLine("Sıralama tamamlandı: " + string.Join(", ", elmalar));
        }
    }
}
