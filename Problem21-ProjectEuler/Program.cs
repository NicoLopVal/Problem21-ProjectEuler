double totalSum = 0;

for (int i = 2; i < 10000; i++)
{
    if (i == SumaFactores(SumaFactores(i)) && i != SumaFactores(i))
    {
        int test = SumaFactores(i);
        int test2 = SumaFactores(SumaFactores(i));
        totalSum = totalSum + i;
    }
}



Console.WriteLine("The sum of factors is: " + totalSum);


int SumaFactores(int value)
{
    int sum = 0;

    for (int i = 1; i < value; i++)
    {
        if (value % i == 0)
            sum = sum + i;
    }

    return sum;
}