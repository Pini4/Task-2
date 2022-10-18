internal class Program
{
    private static void Main(string[] args)
    {
        int[] A = new int[20];
        int[] B = new int[20];

        static int random()
        {
            Random rnd = new Random();
            int value = rnd.Next(-99999, 99999);
            return value;
        }

        for (int i = 0; i < 20; i++)
        {
            A[i] = random();
        }

        for (int i = 0; i < 20; i++)
        {
            if (A[i] <= 888)
            {
                B[i] = A[i];
            }
        }

        int cpsn;
        for (int i = 0; i < 19; i++)
        {
            for (int a = i + 1; a < 20; a++)
            {
                if (B[i] < B[a])
                {
                    cpsn = B[i];
                    B[i] = B[a];
                    B[a] = cpsn;
                }
            }
        }

        for (int i = 0; i < 20; i++)
        {
            if (B[i] != 0)
            {
                Console.WriteLine($"Число удовлетворяющее требование:{B[i]}");

            }
        }        
    }
}
