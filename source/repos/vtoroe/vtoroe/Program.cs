namespace vtoroe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = 9;
            var array = new int[n, n];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i, i] = i + 1;
                array[array.GetLength(0) - i - 1, i] = i + 1;
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}  .");
                }
                Console.WriteLine();
            }

        }
    }
}