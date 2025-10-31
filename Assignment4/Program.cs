int size = 0;
Console.WriteLine("Enter Size of the array is: ");
size=Convert.ToInt32( Console.ReadLine());
int[] Arr = new int[size];

for (int i = 0; i < Arr.Length; i++)
{
    Console.WriteLine($"Enter element {i + 1}:");
    Arr[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("The elements reverse in the array are:");
for (int i = size - 1; i >= 0; i--)
{
    Console.WriteLine(Arr[i]);
}