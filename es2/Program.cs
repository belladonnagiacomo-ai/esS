namespace es2
{
    internal class Program
    {
        static bool Sicurezza(string password, bool verifica)
        {
            verifica = false;
            password = password.ToLower();
            string[] p = password.Split();
           
          if(password.Length >= 8 && password != "password")
          {
              for(int i  = 0; i < p.Length; i++)
                {
                 
                    if(p[i] == " ")
                    {
                       
                    }
                    else
                    {
                        verifica = true;
                       
                    }
              }

          }
          if(verifica == true)
          {
                Console.WriteLine("La password e sicura");
                return verifica;
          }
            else
            {
                Console.WriteLine("La password non e sicura");
                return verifica;
            }
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Dammi una password");
            string password = Console.ReadLine();
          
            Sicurezza(password, false);
            
        }
    }
}
