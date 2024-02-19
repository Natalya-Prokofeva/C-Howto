int num = int.Parse(Console.ReadLine()!);

if (num < 100)
{
  Console.WriteLine("No");
}
else
{
  Console.WriteLine((num / 100) % 10);

}
