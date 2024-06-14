namespace Condition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if(n == 0 || n == 1)
            {
                Console.WriteLine("0 or 1 is not a prime number.");
            }
            else
            {
                Console.WriteLine("Prime numbers are :");
                for (int i=2; i<=n; i++)
                {
                   

                    if (i == 2)
                        Console.WriteLine(i);
                    if (i % 2 != 0)
                        Console.WriteLine(i);
                }

            }
        }
    }
}
