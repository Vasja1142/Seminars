try
{
Console.Write("CЧ(2,8,10,16):");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Число : ");
int value = Convert.ToInt32(Console.ReadLine(), n);
Console.WriteLine($"hex:{Convert.ToString(value, 16),10}");
Console.WriteLine($"dec:{Convert.ToString(value, 10),10}");
Console.WriteLine($"oct:{Convert.ToString(value, 8),10}");
Console.WriteLine($"bit:{Convert.ToString(value, 2),10}");
}
catch
{
Console.WriteLine("Возникло исключение!");
}