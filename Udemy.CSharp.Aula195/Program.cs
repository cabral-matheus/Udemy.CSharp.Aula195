namespace Udemy.CSharp.Aula195
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\mathe\OneDrive\Documentos\Projetos C#\Udemy.CSharp.Aula195\file1.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);

                string[] lines = File.ReadAllLines(sourcePath);

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            } catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}