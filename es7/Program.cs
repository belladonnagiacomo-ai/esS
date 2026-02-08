namespace es7
{
    internal class Program
    {
        static void Occorrenze(char lettera, string parola)
        {
            parola = parola.ToLower();
            char[] p = parola.ToCharArray();
            lettera = char.ToLower(lettera);
            int n = 0;
            for(int i = 0; i < p.Length; i++)
            {
                if (p[i] == lettera)
                {
                    n++;
                }
            }
            Console.WriteLine("La lettera " + lettera + " e nella parola per " + n + " volte");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Dammi una parola");
            string parola = Console.ReadLine();
            Console.WriteLine("Dammi una lettera");
            char lettera = Convert.ToChar(Console.ReadLine());
            Occorrenze(lettera, parola);
        }
    }
}
