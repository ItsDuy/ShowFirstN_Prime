namespace ShowFirstN_Prime;

class Program
{
    static void Main(string[] args)
    {
        int number;
        Console.WriteLine("Enter the numbers of Prime number you want to display: ");
        int.TryParse(Console.ReadLine(), out number);
        int count=0;
        int z=0;
        Console.Write("Prime number to the n-th:");
        while(count<number)
        {
            if(isPrime(z))
            {
                count++;
                Console.Write($"{z} ");
                z++;
            }
            else
            {
                z++;
            }
        }
    }
    static bool isPrime(int n)
    {
        if(n<2)
        {
            return false;
        }
        else if(n<4)
        {
            return true;
        }
        else
        {
            for(int i=2;i<=MathF.Sqrt(n);i++)
            {
                if(n%i==0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
