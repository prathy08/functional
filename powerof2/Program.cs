namespace powerof2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
                 int mul = 1;

            

           
            if (num > 31)
            {
                Console.WriteLine("value of number should be less than 31");
                return;
            }

            
            else
            {
                Console.WriteLine(mul);
                for (int j = 1; j <= num; j++)
                {
                    mul = mul * 2;
                    Console.WriteLine(mul);
                }
            }

        }
    }
}