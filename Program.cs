namespace datastrukturer;

class Program
{
    static void Main(string[] args)
    {
        
        // Övning1();
        // Övning3();
        Övning4();
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
}
