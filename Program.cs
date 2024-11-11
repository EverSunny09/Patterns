#region Square Pattern
/*int n = 3;
char ch = 'A';
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++, ch++)
    {
        Console.Write(ch + " ");
    }
    Console.WriteLine();
}*/
#endregion

#region Triangle Pattern
/*int n = 4;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < i+1; j++)
    {
        Console.Write(i+1);
    }
    Console.WriteLine();
}*/
/*int n = 4;
char ch = 'A';
for (int i = 0; i < n; i++, ch++)
{
    for (int j = 0; j < i + 1; j++)
    {
        Console.Write(ch + " ");
    }
    Console.WriteLine();
}*/

/*int n=5;
for (int i = 0; i < n; i++)
{
    for (int j = 1; j <= i + 1; j++)
    {
        Console.Write(j);
    }
    Console.WriteLine();
}*/
#endregion

#region Reverse Triangle Pattern

/*int n = 4;
for (int i = 0; i < n; i++)
{
    for (int j = i + 1; j > 0; j--)
    {
        Console.Write(j);
    }
    Console.WriteLine();
}*/

#endregion

#region Floyds Triangle Pattern

/*int n = 4;
int num = 1;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < i + 1; j++, num++)
    {
        Console.Write(num+ " ");
    }
    Console.WriteLine();
}*/

/*int n = 4;
char ch = 'A';
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < i + 1; j++, ch++)
    {
        Console.Write(ch+ " ");
    }
    Console.WriteLine();
}*/

#endregion

#region Inverted Pattern

/*int n = 4;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write(" ");
    }

    for (int k = 0; k < n - i; k++)
    {
        Console.Write(i + 1);
    }

    Console.WriteLine();
}*/

/*int n = 4;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write(" ");
    }
    for (int j = 0; j < n - i; j++)
    {
        Console.Write(j + 1);
    }
    Console.WriteLine();
}*/

/*int n = 4;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write(" ");
    }
    for (int j = 0; j < n - i; j++)
    {
        Console.Write(j + 1+ " ");
    }
    Console.WriteLine();
}*/

/*int n = 5;
char ch = 'A';
for (int i = 0; i < n; i++,ch++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write(" ");
    }

    for (int j = 0; j < n - i; j++)
    {
        Console.Write(ch);
    }
    Console.WriteLine();
}
*/
#endregion

#region Pyramid Pattern

/*int n = 8;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n - i - 1; j++)
    {
        Console.Write(" ");
    }

    for (int j = 0; j < i + 1; j++)
    {
        Console.Write(j+1);
    }

    for (int j = i; j > 0; j--)
    {
        Console.Write(j);
    }

    Console.WriteLine();
}*/

#endregion

#region Hollow Diamond Pattern

/*int n = 10;

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n - i - 1; j++)
    {
        Console.Write(" ");
    } 
    Console.Write("*");
    if (i != 0)
    {
        for (int j = 0; j < i*2-1; j++)
        {
            Console.Write(" ");
        }
        Console.Write("*");
    }

    Console.WriteLine();
}

for (int i = 0; i < n - 1; i++)
{
    for (int j = 0; j < i + 1; j++)
    {
        Console.Write(" ");
    }
    Console.Write("*");

    if (i != n-2)
    {
        for (int j = 0; j < 2*(n-i)-5; j++)
        {
            Console.Write(" ");
        }
        Console.Write("*");
    }
    Console.WriteLine();
}*/

#endregion

#region Butterfly Pattern
/*int n = 5;

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < i + 1; j++)
    {
        Console.Write("*");
    }
    for (int j = 0; j < ((2 * n - 2) - 2 * i); j++)
    {
        Console.Write(" ");
    }
    for (int j = 0; j < i + 1; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

for (int i = 0; i < n; i++)
{
    for (int j = i; j < n; j++)
    {
        Console.Write("*");
    }
    for (int j = 0; j < 2*i; j++)
    {
        Console.Write(" ");
    }

    for (int j = 0; j < n-i; j++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}*/
#endregion

#region Sum of numbers or a digit

/*namespace Patterns;

class Program
{

    static int SumOfNumbers(int n)
    {
        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }

        return sum;
    }

    public static void Main()
    {
        int n = 20;

        int sum = SumOfNumbers(n);

        Console.WriteLine($"The sum of numbers from 1 to {n} is: {sum}");
    }
}*/

/*namespace Patterns;

class Program
{

    static int SumOfDigits(int n)
    {
        int sum = 0;
        while (n != 0)
        {
            int temp = n % 10;
            sum += temp;
            n /= 10;
        }

        return sum;
    }

    public static void Main()
    {
        int n = 567;

        int sum = SumOfDigits(n);

        Console.WriteLine($"The sum of digit {n} is: {sum}");
    }
}*/

#endregion

#region Calculate Factorial

/*namespace Patterns;

class Program
{

    static long Factorial(int n)
    {
        long factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        return factorial;
    }

    public static void Main()
    {
        int n = 10;

        long factorial = Factorial(n);

        Console.WriteLine($"The factorial of {n} is: {factorial}");
    }
}*/

#endregion

#region Binomial Coefficient

/*namespace Patterns;

class Program
{

    static long Factorial(long n)
    {
        long factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        return factorial;
    }

    static long CalculateNcr(int n, int r)
    {
        long nFactorial = Factorial(n);
        long rFactorial = Factorial(r);
        long nrFactorial = Factorial(n - r);
        return nFactorial / (rFactorial * nrFactorial);
    }

    public static void Main()
    {
        int n = 6;
        int r = 3;

        Console.WriteLine($"The Binomial Coefficient of N:{n} R:{r} is: {CalculateNcr(n,r)}");
    }
}*/

#endregion

#region Decimal to Binary

/*namespace Patterns;

class Program
{
    static int DecimalToBinary(int num)
    {
        int power = 1;
        int binaryNum = 0;
        while (num != 0)
        {
            var remainder = num % 2;
            binaryNum += remainder * power;
            power *= 10;
            num /= 2;
        }

        return binaryNum;
    }

    public static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"The Binary number for {i} is: {DecimalToBinary(i)}");
        }
    }
}*/



#endregion

#region Binary to Decimal

/*namespace Patterns;

class Program
{
    static int BinaryToDecimal(int binNum)
    {
        int ans = 0, pow = 1;
        while (binNum > 0)
        {
            var rem = binNum % 10;
            ans += rem * pow;
            binNum /= 10;
            pow *= 2;
        }
        return ans;
    }

    public static void Main()
    {
        int i = 10110;
        Console.WriteLine($"The Decimal number for {i} is: {BinaryToDecimal(i)}");
    }
}
*/
#endregion

#region Reverse an Integer

/*int number = 1242123;
int rev = 0;
while (number > 0)
{
    int latestDigit = number % 10;
    rev = rev * 10 + latestDigit;
    number /= 10;
}
Console.Write("Reverse is " +rev);*/

#endregion
