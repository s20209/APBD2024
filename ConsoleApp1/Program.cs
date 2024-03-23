// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("mod 1");
Console.WriteLine("mod 2");
Console.WriteLine("mod 3");

static double getAvgNumber(int[] numbers)
{
    return numbers.Average();
}

static int getMaxNumber(int[] numbers)
{
    int mxValue = 0;
    Console.WriteLine("What conflict?");
    foreach(int i in numbers)
    {
        if (mxValue < i)
            mxValue = i;
    }
    return mxValue;
}