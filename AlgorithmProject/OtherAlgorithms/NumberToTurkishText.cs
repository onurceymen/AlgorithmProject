namespace AlgorithmProject.OtherAlgorithms
{
    public static class NumberToTurkishText
    {
        // Dışarıya açık metot: bir decimal sayıyı metinsel okunuşuna dönüştürür
        public static string ConvertNumberToWords(decimal number)
        {
            // Sayı negatif ise başa "eksi" ekleyip pozitif tarafını işleyeceğiz
            if (number < 0)
            {
                return "eksi " + ConvertNumberToWords(-number);
            }

            // Tam kısmı al
            long integerPart = (long)number;

            // Ondalık kısmı al - virgülden sonra kalan kısım (2 basamak gibi sabit tutabilirsiniz)
            decimal fractionPart = number - integerPart;
            fractionPart = decimal.Round(fractionPart, 2); // 2 basamak yuvarlama

            long fractionValue = 0;
            if (fractionPart > 0)
            {
                // Ondalık kısmı 2 basamaklı bir tam sayı haline getiriyoruz
                fractionValue = (long)((fractionPart) * 100);
            }

            // Tam kısım 0 ise "sıfır"
            string words = integerPart == 0
                ? "sıfır"
                : ConvertIntegerToWords(integerPart);

            // Ondalık kısım varsa "virgül" diyerek ekle
            if (fractionValue > 0)
            {
                words += " virgül " + ConvertIntegerToWords(fractionValue);
            }

            return words.Trim();
        }

        // 0 ile 999,999,999,999 (999 milyar) arasında kalan tam sayısal değeri metinsel karşılığına dönüştürür
        private static string ConvertIntegerToWords(long number)
        {
            if (number == 0)
                return "sıfır";

            // Binlik grupları için ekler (bin, milyon, milyar gibi)
            string[] scaleNumbers = { "", "bin", "milyon", "milyar" };

            // Sonucu tutacağımız değişken
            string result = "";

            // Hangi binlik grupta olduğumuzu tutan sayaç
            int groupIndex = 0;

            // Sayıyı 3'lü gruplar halinde parçalayarak oku
            while (number > 0)
            {
                int threeDigits = (int)(number % 1000); // son 3 basamak
                number /= 1000;

                if (threeDigits != 0)
                {
                    // 3 basamağı (0-999) okunuşuna çevir
                    string threeDigitsText = ConvertUpToThreeDigits(threeDigits);

                    // Binlik ekleri (bin, milyon, milyar)
                    if (!string.IsNullOrEmpty(scaleNumbers[groupIndex]))
                    {
                        threeDigitsText += " " + scaleNumbers[groupIndex];
                    }

                    // Sonuca ekle (daha yüksek basamakları sonra gelecek)
                    result = threeDigitsText + " " + result;
                }

                groupIndex++;
            }

            return result.Trim();
        }

        // 0-999 arasındaki sayıları okunuşuna çevirir
        private static string ConvertUpToThreeDigits(int number)
        {
            // Temel kelimeler
            string[] ones =
                { "sıfır", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
            string[] tens =
                { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };

            // Özel durum: 0 ise direkt "sıfır"
            if (number == 0)
                return "sıfır";

            string words = "";

            // Yüzler basamağı
            int hundreds = number / 100;
            int remainder = number % 100;

            if (hundreds > 0)
            {
                if (hundreds == 1)
                {
                    words += "yüz"; // "1 yüz" yerine "yüz" denir
                }
                else
                {
                    words += ones[hundreds] + " yüz";
                }
            }

            // Onlar basamağı
            int tenValue = remainder / 10;

            // Birler basamağı
            int oneValue = remainder % 10;

            if (tenValue > 0)
            {
                if (!string.IsNullOrEmpty(words))
                    words += " ";
                words += tens[tenValue];
            }

            if (oneValue > 0)
            {
                if (!string.IsNullOrEmpty(words))
                    words += " ";
                words += ones[oneValue];
            }

            return words.Trim();
        }
    }

    // Örnek kullanım
    public class Program
    {
        public static void Main()
        {
            decimal[] testValues =
            {
            0,
            5,
            10,
            21,
            99,
            100,
            101,
            110,
            999,
            1000,
            1001,
            2022,
            999999,
            1000000,
            1000100,
            1234567.89m,
            -456.78m // negatif örnek
        };

            foreach (decimal val in testValues)
            {
                string text = NumberToTurkishText.ConvertNumberToWords(val);
                Console.WriteLine($"{val} => {text}");
            }
        }
    }

}
