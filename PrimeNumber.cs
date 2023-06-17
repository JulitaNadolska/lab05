namespace lab05;

public class PrimeNumber
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int enteredNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("{0} prime numbers: ", enteredNumber);
        int number = 2;
        int counter = 0;

        while (counter < enteredNumber)
        {
            if (IsPrimeNumber(number))
            {
                Console.WriteLine(number);
                counter++;
            }

            number++;
        }
    }
    static bool IsPrimeNumber(int number)
    {
        if (number < 2)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}