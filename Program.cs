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

#region Arrays

/*int[] number = {12,32,542,23,23432,2342,1123,233243,34,-12,-23};
int largest= Int32.MinValue, smallest = Int32.MaxValue;
for (int i = 0; i < number.Length; i++)
{
    largest = Math.Max(number[i], largest);
    smallest = Math.Min(number[i], smallest); 
}
Console.WriteLine($"Largest number is: {largest} and the Smallest is {smallest}");*/

/*int[] number = { 12, 32, 542, 23, 23432, 2342, 1123, 233243, 34, -12, -23 };
int largest = Int32.MinValue, lIdx = Int32.MinValue, smallest = Int32.MaxValue, sIdx = Int32.MaxValue;
for (int i = 0; i < number.Length; i++)
{
    if (number[i] > largest)
    {
        largest = number[i];
        lIdx = i;
    }

    if (number[i] < smallest)
    {
        smallest = number[i];
        sIdx = i;
    }
}
Console.WriteLine($"Largest number is: {largest} and the index is {lIdx} and the Smallest is: {smallest} and the index is {sIdx}");*/
#endregion

#region Linear Search Array

/*int[] numbers = { 1, 4, 2, 12, 32, 54, 2, 4, 9 };
int find = 12;
int index = -1;
for (int i = 0; i < numbers.Length; i++)
{
    if (find == numbers[i])
    {
        index = i;
        break;
    }
}
Console.Write($"Index is: {index}");*/

#endregion

#region Reverse an Array

/*int[] num = { 12, 212, 12, 34, 56, 346, 123, 12, 3,1 };
int start = 0;
int end = num.Length - 1;

while (start < end)
{
    int temp = num[start];
    num[start] = num[end];
    num[end] = temp;

    start++;
    end--;
}

for (int i = 0; i < num.Length; i++)
{
    Console.WriteLine(num[i]);
}*/

#endregion

#region Find Sum and Product of an array

/*int[] arr = { 1, 2, 3, 4, 5 };
int sum = 0;
int product = 1;
for (int i = 0; i < arr.Length; i++)
{
    sum += arr[i];
    product *= arr[i];
}

Console.WriteLine($"Sum of give array is {sum}");
Console.WriteLine($"Product of give array is {product}");*/

#endregion

#region Swap min and max number of array

/*int[] arr = { 1, 2, 3, 4, 5, 12, 7, 8, 9 };
int minIdx = Int32.MaxValue;
int minNumber = Int32.MaxValue;
int maxIdx = Int32.MinValue;
int maxNumber = Int32.MinValue;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > maxNumber)
    {
        maxNumber = arr[i];
        maxIdx = i;
    }
    if (arr[i] < minNumber)
    {
        minNumber = arr[i];
        minIdx = i;
    }
}

int temp = arr[maxIdx];
arr[maxIdx] = arr[minIdx];
arr[minIdx] = temp;

Console.Write($"After swap array: ");
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i]+ " ");
}*/

#endregion

#region Find all unique values in an array

/*int[] arr = { 1, 2, 3, 4, 1, 2, 3 };

for (int i = 0; i < arr.Length; i++)
{
    bool exists = false;
    for (int j = 0; j < arr.Length; j++)
    {
        if (i != j && arr[i] == arr[j])
            exists = true;
    }
    if (!exists)
        Console.WriteLine(arr[i]);
}*/

#endregion
