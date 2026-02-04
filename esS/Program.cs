namespace esS
{
    internal class Program
    {
        static void Acronimo(string frase, string[] acronimo)
        {
            

            for (int i = 0; i < acronimo.Length; i++)
            {
                Console.WriteLine(acronimo[i]);
            }

        }
        static void Main(string[] args)
        {
           
            Console.WriteLine("Dammi una frase");
            string frase = Console.ReadLine();
            string[] acronimo = frase.Split(" ");
            Acronimo(frase, acronimo);
        }
    }
}
