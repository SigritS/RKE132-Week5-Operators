//temp võrdne 0 freezing cold
//temp 0 kuni 10 siis cold
// temp 10 kuni 15 chilly
//15 kuni 20 warm
//20 kuni 30 hot
// 30 peale boiling hot


Console.WriteLine("Enter the temperature:");
int temp = Int32.Parse(Console.ReadLine());

if (temp >= 30)
{
    Console.WriteLine("Boiling hot.");
}

else if (temp < 30 && temp >= 20)
{
    Console.WriteLine("Hot.");
}
else if (temp < 20 && temp >= 15)
{
    Console.WriteLine("Warm.");
}
else if (temp < 15 && temp >= 10)
{
    Console.WriteLine("Chilly.");
}
else if (temp < 10 && temp > 0)
{
    Console.WriteLine("Cold.");
}
else
{
    Console.WriteLine("Freezing cold.");
}