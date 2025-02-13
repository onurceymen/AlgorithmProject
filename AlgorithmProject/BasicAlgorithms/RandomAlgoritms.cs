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
    }
}
