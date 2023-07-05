using System.Threading.Channels;

namespace ReadAndWriteChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\kacpe\Desktop\C# tutorialsEU\CompleteCsharp\ReadAndWriteChallenge\Assets\input.txt");




            using (StreamWriter file = new StreamWriter(@"C:\Users\kacpe\Desktop\C# tutorialsEU\CompleteCsharp\ReadAndWriteChallenge\Assets\output.txt"))
            {
                foreach (string line in lines)
                {
                    if (line.Contains("split"))
                    {
                        string[] splittedLine = line.Split(" ");
                        string text = splittedLine[4];
                        file.Write(text + " ");
                    }


                }
            }
            Console.WriteLine("Saved a new text file!");
            Console.ReadKey();
        }



    }
}
