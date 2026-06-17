namespace Chapter03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = 256;
            for (byte i = 0; i < max; i++)
            {
                if (max > byte.MaxValue)
                {
                    Console.WriteLine("The value of the counter is greater than the max value of the byte type. Cannot continue the loop.");
                    break;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
