using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProject.SortingAlgorithms
{
    public class MergeSort
    {
        public void Sort(int[] array, int sol, int sag)
        {
            if (sol < sag)
            {
                int orta = (sol + sag) / 2;

                Sort(array, sol, orta);
                Sort(array, orta + 1, sag);

                Merge(array, sol, orta, sag);
                Thread.Sleep(1000);

            }
        }

        public void Merge(int[] array, int sol, int orta, int sag)
        {
            int n1 = orta - sol + 1;
            int n2 = sag - orta;

            int[] soldizi = new int[n1];
            int[] sagdizi = new int[n2];
            Thread.Sleep(1000);

            for (int i = 0; i < n1; i++)
            {
                soldizi[i] = array[sol + i];
            }
            Thread.Sleep(1000);

            for (int j = 0; j < n2; j++)
            {
                sagdizi[j] = array[orta + 1 + j];
            }
            Thread.Sleep(1000);


            int k = sol, iIndex = 0, jIndex = 0;

            while (iIndex < n1 && jIndex < n2)
            {
                if (soldizi[iIndex] <= sagdizi[jIndex])
                {
                    array[k] = soldizi[iIndex];
                    iIndex++;
                }
                else
                {
                    array[k] = sagdizi[jIndex];
                    jIndex++;
                }
                k++;
            }
            Thread.Sleep(1000);

            while (iIndex < n1)
            {
                array[k] = soldizi[iIndex];
                iIndex++;
                k++;
            }
            Thread.Sleep(1000);

            while (jIndex < n2)
            {
                array[k] = sagdizi[jIndex];
                jIndex++;
                k++;
            }
            Thread.Sleep(1000);


            Console.WriteLine("Birleşim : " + string.Join(",", array));
        }
    }
}
