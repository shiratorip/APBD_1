// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// First modification
Console.WriteLine("meow");

// Second modification
Console.WriteLine("murrr");

// Third modification
Console.WriteLine("HAHAHAHA");
static double CountAverage(int[] Arr)
{
    double avg = 0;
    int len = Arr.Length;
    for (int i = 0; i < len; i++)
    {
        avg += Arr[i] / len;
    }
    return avg;
}

static double CountMax(int[] Arr)
{
    double max_val = Arr[0];
    for (int i = 0; i < Arr.Length; i++)
    {
        max_val = Math.Max(max_val, Arr[i]);
    }
    return max_val;
}