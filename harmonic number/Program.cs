namespace harmonic_number
{

        internal class Program
        { 


    static double nthHarmonic(int N)
    {
        // H1 = 1
        float harmonic = 1;

        // loop to apply the formula
        // Hn = H1 + H2 + H3 ... +
        // Hn-1 + Hn-1 + 1/n
        for (int i = 2; i <= N; i++)
        {
            harmonic += (float)1 / i;
        }

        return harmonic;
    }

    // Driver Code
    public static void Main()
    {
        int N = 8;

        Console.Write(nthHarmonic(N));
    }

}
}


    



