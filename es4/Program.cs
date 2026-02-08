namespace es4
{
    internal class Program
    {
        static void Cancellazione(string frase)
        {
            frase = frase.ToLower();
            char[] f = frase.ToCharArray();
            for (int i = 0; i < frase.Length; i++)
            {
               
                if (f[i] == 'a' || f[i] == 'e' || f[i] == 'i' || f[i] == 'o' || f[i] == 'u')
                {

                    f[i] = ' ';
                }
            }
               
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Dammi una frase");
            string frase = Console.ReadLine();

        }
    }
}
