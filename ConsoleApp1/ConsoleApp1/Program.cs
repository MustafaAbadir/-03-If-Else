// See https://aka.ms/new-console-template for more information
/*Even or Odd*/
Console.WriteLine("Write a number!");
int myNumber = int.Parse(Console.ReadLine()); 

if (myNumber%2 == 0)
{
    Console.WriteLine("The number is even");
}
else
{
    Console.WriteLine("The number is odd");
}

/*Age Bracket*/
Console.WriteLine("How old are you?");
int age = int.Parse(Console.ReadLine());
if (age < 13)
{
    Console.WriteLine("You are a child");
}
else if (age > 13 && age < 19)
{
    Console.WriteLine("You are a teenager");
}
else
{
    Console.WriteLine("You are an adult");
}