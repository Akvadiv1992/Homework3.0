Console.Clear();
Console.Write("Введите количество кустов: ");
int n = Convert.ToInt32(Console.ReadLine()),
sum = 0;
int[] a = new int[n + 2];
for (int i = 0; i < n; i++)
a[i] = Convert.ToInt32(Console.ReadLine());
a[n] = a[0];
a[n + 1] = a[1];

for (int i = 1; i < n + 1; i++)
{
int t = a[i - 1] + a[i] + a[i + 1];
if (t > sum)
sum = t;
}
Console.WriteLine(sum);