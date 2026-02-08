namespace es3
{
    internal class Program
    {
        static void Conversione(string frase)
        {
            frase = frase.ToLower();
            char[] f = frase.ToCharArray();
            for (int i = 0; i < f.Length; i++)
            {
                if (i == 0 || f[i - 1] == ' ')
                {

                    f[i] = char.ToUpper(f[i]);


                }
                Console.Write(f[i]);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Dammi una frase");
            string frase = Console.ReadLine();
            Conversione(frase);
        }
    }
}
