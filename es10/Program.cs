namespace es10
{
    internal class Program
    {
        static void LunghezzaMax(string frase)
        {
            string[] f = frase.Split(' ');
            int k = 0, a = 0;
            string parolaMax = "";
            for(int i = 0; i < f.Length; i++)
            {
                k = 0;
               for(int z = 0; z < f[i].Length; z++)
               {
                    k++;
               }
                if(k >= a)
                {
                   parolaMax = new string (f[i]);
                    a = k;
                    
                }
            }
            Console.WriteLine ("La parola piu lunga e: " + parolaMax);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Dammi una frase");
            string frase = Console.ReadLine();
            LunghezzaMax (frase);
        }
    }
}
