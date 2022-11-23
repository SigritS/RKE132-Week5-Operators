//90 või rohkem tulemus
//&& mõlemad tingimused peavad tõesed olema siis tulem tõene

int math, biology, chemistry;

Console.WriteLine("Enter your math result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Biology result:");
biology= Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Chemistry result:");
chemistry= Int32.Parse(Console.ReadLine());

if (math >= 90 && biology >= 90 && chemistry >= 90)
{
    Console.WriteLine("Congrats! You got accepted!");
}
else
{
    Console.WriteLine("You are not enough!");
}