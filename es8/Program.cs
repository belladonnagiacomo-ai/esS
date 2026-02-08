namespace es8
{
    internal class Program
    {
        static void Censura(string n)
        {
            char[] num = n.ToCharArray();
            if (num.Length <= 4)
            {
                for (int z = 0; z < num.Length; z++)
                {
                    Console.Write(num[z]);
                }
            }
            else
            {
                for (int i = 0; i < num.Length - 4; i++)
                {
                    num[i] = '*';

                }
                n = new string(num);
                Console.WriteLine(n);
            }
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Dammi i numeri della tua carta di credito");
            string n = Console.ReadLine();
            Censura(n);
        }
    }
}
