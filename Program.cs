namespace datastrukturer;

class Program
{
    static void Main(string[] args)
    {
        
        // Övning1();
        // Övning3();
        // Övning4();
        static void Övning1() 
        {
            List<string> lista = new List<string>();
            lista.Add("hej");
            lista.Add("hejsan");
            lista.Add("hallå");

            foreach(string word in lista)
            {
                Console.WriteLine(word);
            }
        }

        static void Övning3() 
        {
           string? input = Console.ReadLine();
           string[] inputArr = input.Split(" ");
           List<int> resultList = new List<int>();
           foreach(string numberStr in inputArr) {
             if (int.TryParse(numberStr, out int number))
                {
                    if (number % 2 == 0)
                    {
                        resultList.Add(number);
                    }
                }
           }
           string resultString = string.Join(", ", resultList);

            Console.WriteLine($"Jämna nummer i listan: {resultString}");
        }

        static void Övning4() 
        {
           string? input = Console.ReadLine();
           string[] inputArr = input.Split(" ");
           List<int> resultList = new List<int>();
           foreach(string numberStr in inputArr) {
             if (int.TryParse(numberStr, out int number))
                {
                    resultList.Add(number * 2);
                }
           }
           string resultString = string.Join(", ", resultList);

            Console.WriteLine(resultString);
        }
    }

    // Övning 6
    /* 
    Fråga: Vad är ekvivalent med en C# List i JavaScript?
    Svar: En array i javascript är ekvivalent med en C# lista - då arrayer i js inte är så begränsade som en array i C#
    */

    // Övning 7
    /* 
    Fråga: Vad är ekvivalent med en C# Dictionary i JavaScript?
    Svar: Ett objekt i javascript är ekvivalent med en C# Dictionary - objekt i js har keys och values precis som en dictionary, du kan göra objekt i js med samma struktur som en dictionary.
    */

    // Övning 9
    /* 
    Fråga: Varför är dictionaries O(1) medans listor är O(n) när det kommer till att leta upp värden?
    Svar: dictionaries använder keys för att hitta värdet - alltså är tidskomplexiteten konstanst, det spelar ingen roll hur många element du har.
    Listor därimot måste gå igenom varje element tills du hittar vad du letar efter. (elementet kan vara var som helst i listan).
    */
}
