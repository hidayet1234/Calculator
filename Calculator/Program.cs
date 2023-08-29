namespace Calculator
{

    class Program
    {
        static string[] questions = {
            "Azerbaycanin paytaxti hansi sheherdir?",
            "İncesenetin shimalinda yerleshen qesebe hansi adla meshurdur?",
            "Astronomiya sifarishleri ile meshgul olan boyuk birleshmeye ne ad verilir?",
            "İnsan orqanizminde en chox hansi element tapilir?",
            "Azerbaycanin boyuk golu hansi goldur?",
            "Kimya elementler cedveli nece adlanir?",
            "Dunya uzerinde en uzun derinlik hansi yerindedir?",
            "Hindu mifologiyasinda butun tanri və tanrichalarin bir araya geldiyi mekan ne adlanir?",
            "Azerbaycanin en hundur zirvəsi hansi dagda yerleshir?",
            "İlk atom bombası hansı sheherde atilmişdir?"
        };

        static string[][] options = {
            new string[] { "a) Baki", "b) Gence", "c) Naxchivan" },
            new string[] { "a) Quba", "b) Xachmaz", "c) Qusar" },
            new string[] { "a) NASA", "b) SETI", "c) ESA" },
            new string[] { "a) Azot", "b) Qalib", "c) Su" },
            new string[] { "a) Gence golu", "b) Mingechevir golu", "c) Seri golu" },
            new string[] { "a) Mendeleyev cədvəli", "b) Molekul cedveli", "c) İyon cedveli" },
            new string[] { "a) Mariana cekekliyi", "b) Qubaq cokekliyi", "c) Kaliforniya cokekliyi" },
            new string[] { "a) Nirvana", "b) Valhalla", "c) Brahmaloka" },
            new string[] { "a) Bazarduzu", "b) Agdag", "c) Shahdag" },
            new string[] { "a) Hiroshima", "b) Nagasaki", "c) Tokyo" }
        };

        static int[] correctAnswers = { 0, 1, 1, 1, 1, 0, 0, 2, 2, 0 };

        static void ShuffleOptions(string[] optionArray)
        {
            Random random = new Random();
            int n = optionArray.Length;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                string value = optionArray[k];
                optionArray[k] = optionArray[n];
                optionArray[n] = value;
            }
        }

        static void Main(string[] args)
        {
            int score = 0;
            Console.WriteLine("Imtahan başladı...");

            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine($"\nSual {i + 1}: {questions[i]}");
                string[] currentOptions = (string[])options[i].Clone();
                ShuffleOptions(currentOptions);

                for (int j = 0; j < currentOptions.Length; j++)
                {
                    Console.WriteLine(currentOptions[j]);
                }

                int userAnswer = Array.IndexOf(currentOptions, Console.ReadLine());

                if (userAnswer == correctAnswers[i])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Düzgün cavab!");
                    score += 10;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Səhv cavab!");
                    score -= 10;
                }

                Console.ResetColor();
            }

            if (score < 0)
            {
                score = 0;
            }

            Console.WriteLine($"\nImtahan bitmişdir. Topladığınız xal: {score}");
        }
    }
}