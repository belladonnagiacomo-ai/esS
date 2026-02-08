namespace es6
{
    internal class Program
    {
        static void Slug (string frase)
        {
            frase = frase.ToLower ();
            frase = frase.Trim ();
            char[] f = frase.ToCharArray ();
            for (int i = 0; i < f.Length; i++)
            {
                if(f [i] == ' ')
                {
                    f[i] = '-';
                }
                Console.Write(f[i]);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Dammi una frase");
            string frase = Console.ReadLine();
            Slug (frase);
        }
    }
}
