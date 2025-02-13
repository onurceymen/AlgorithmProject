namespace AlgorithmProject.SortingAlgorithms
{
    public class QuickSort
    {
        public void Sort(int[] elmalar, int sol, int sag) 
        {
            if (sol < sag)
            {
                int pivotIndex = Partition(elmalar, sol, sag);

                Sort(elmalar, sol, pivotIndex - 1);

                Sort(elmalar, pivotIndex + 1, sag);

            }
        }

        private int Partition(int[] elmalar, int sol, int sag)
        {
            int pivot = elmalar[sag];
            int i = (sol - 1);

            for (int j = sol; j < sag; j++)
            {
                if (elmalar[j] < pivot)
                {
                    i++;

                    int temp = elmalar[i];
                    elmalar[i] = elmalar[j];
                    elmalar[j] = temp;
                    Console.WriteLine($"Elma {elmalar[j]} ve Elma {elmalar[i]} yer değiştirdi.");
                    Thread.Sleep(500);
                }
            }

            int temp1 = elmalar[i + 1];
            elmalar[i + 1] = elmalar[sag];
            elmalar[sag] = temp1;
            Thread.Sleep(500);

            Console.WriteLine($"Pivot {elmalar[i + 1]} yerine taşındı.");
            return (i + 1);
        }
    }
}
