static int Task1(int n)
{
    if (n <= 0)
    {
        throw new Exception("Provide integer that is greater than 0");
    }

    string stringifiedN = Convert.ToString(n);

    int sum = 0;

    for (int i = 0; i < stringifiedN.Length; i++)
    {
        int num = (int)char.GetNumericValue(stringifiedN[i]);

        if (num % 2 != 0)
        {
            sum = sum + num;
        }
    }

    return sum;
}

static int Task2(int n)
{
    if (n <= 0)
    {
        throw new Exception("Provide integer that is greater than 0");
    }

    string binary = Convert.ToString(n, 2);

    int sum = 0;

    for (int i = 0; i < binary.Length; i++)
    {
        int num = (int)char.GetNumericValue(binary[i]);
        //sum = sum + num;
        sum += num;
    }

    return sum;
}

static int Task3(int n)
{
    if (n <= 0)
    {
        throw new Exception("Provide integer that is greater than 0");
    }

    int a = 0;
    int b = 1;
    int sum = 0;
    int temp;

    for (int i = 0; i < n; i++)
    {
        sum = sum + a;
        temp = a;
        a = b;
        b = temp + b;
    }

    return sum;
}