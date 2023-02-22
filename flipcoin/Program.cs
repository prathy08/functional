namespace flipcoin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int h = 0;
            int t= 0;
            double heads, tails;
            Random random = new Random();
           
            
            Console.WriteLine("enter no of times to flip the coin :");
            Console.WriteLine("----------------------------------------");
            n = random.Next();

            for (int i = 0; i < n; i++)
            {
 
                if (n < 0.5)
                    t++;
               else
                    h++;

            }
            heads = h/ (double) n * 100;
            tails = t / (double) n * 100;
            Console.WriteLine("percentage of heads:" + heads + "%");
            Console.WriteLine("percentage of tails:" + tails + "%");
          
        }
    }
}
