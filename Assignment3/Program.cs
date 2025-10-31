float[] Mark = { 47.5f, 55, 80, 90, 33.2f, 35 };
float Sum = 0.0f;

for (int i = 0; i < Mark.Length; i++)
{
    Sum += Mark[i];
}

float Avg = Sum / Mark.Length;
Console.WriteLine($"The Average is: {Avg:F2}\n");

Console.WriteLine("Numbers greater than the average:");
for (int i = 0; i < Mark.Length; i++)
{
    if (Mark[i] > Avg)
    {
        Console.WriteLine(Mark[i]);
    }
}
