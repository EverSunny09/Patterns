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

/*int n = 7;

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < i+1; j++)
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
    for (int j = 0; j < i; j++)
    {
        Console.Write(" ");
    }
    for (int j = 0; j < i; j++)
    {
        Console.Write(" ");
    }
    for (int j = i; j < n; j++)
    {
        Console.Write("*");
    }
    
    Console.WriteLine();
}*/

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