using System;

namespace In_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int N = int.Parse(Console.ReadLine());
            int[] vet = new int[N];

            int contin = 0;
            int contout = 0;

            for (int i = 0; i < N; i++)
            {
                vet[i] = int.Parse(Console.ReadLine());
                if (vet[i] >= 10 && vet[i] <= 20)
                {
                    contin = contin + 1;
                }
                else
                {
                    contout = contout + 1;
                }
            }

            Console.WriteLine(contin + " in");
            Console.WriteLine(contout + " out");
        }
    }
}
