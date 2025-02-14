namespace AlgorithmProject.BasicAlgorithms
{
    public class RandomAlgoritms
    {
        public static int FindSmallestNumber(int[] numbers)
        {
            int min = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            return min;

        }

        public static string ReverseString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            string result = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                result += input[i];
            }
            return result;

        }

        public static int[] FindDuplicates(int[] numbers)
        {
            if (numbers.Length == 0)
                return new int[0];

            HashSet<int> seenNumbers = new HashSet<int>();
            HashSet<int> duplicates = new HashSet<int>();

            foreach (int num in numbers)
            {
                if (seenNumbers.Contains(num))
                {
                    duplicates.Add(num);
                }
                else
                {
                    seenNumbers.Add(num);
                }
            }

            return duplicates.ToArray();
        }

        public static (int[], int[]) SeparateEvenOdd(int[] numbers)
        {
            List<int> ciftsayilar = new List<int>();
            List<int> teksayilar = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    ciftsayilar.Add(numbers[i]);
                }
                else
                {
                    teksayilar.Add(numbers[i]);
                }
            }

            return (ciftsayilar.ToArray(), teksayilar.ToArray());
        }

        public static int FindLargestNumber(int[] numbers)
        {
            int enbuyukdeger = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > enbuyukdeger)
                {
                    enbuyukdeger = numbers[i];
                }
            }

            return enbuyukdeger;
        }

        public static bool IsPalindrome(string word)
        {
            if (string.IsNullOrEmpty(word))
                return false; 

            string donenkelime = ""; 

            for (int i = word.Length - 1; i >= 0; i--)
            {
                donenkelime += word[i];
            }

            return word == donenkelime;
        }

        public static int Fibonacci(int n)
        {
            if (n <= 0)
                return 0;
            if (n == 1) 
                return 1;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
            
        }

        public static int Factorial(int n)
        {
            if (n == 0 || n == 1)
                return 1; 

            int sonuc = 1; 

            for (int i = 2; i <= n; i++)
            {
                sonuc *= i; 
            }

            return sonuc;
        }

        public static int FactorialRecursive(int n)
        {
            if (n == 0 || n == 1)
                return 1; 

            return n * FactorialRecursive(n - 1);
        }



    }
}
