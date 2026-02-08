namespace es9
{
    internal class Program
    {
        static void Inversione (string frase)
        {
            string[] parole = frase.Split(" ");
            for (int i = parole.Length - 1; i >= 0; i--)
            {

                Console.Write(parole[i]);
                Console.Write("  ");

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Dammi una frase");
            string frase = Console.ReadLine();
            Inversione (frase);
        }
    }
}
