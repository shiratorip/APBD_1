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