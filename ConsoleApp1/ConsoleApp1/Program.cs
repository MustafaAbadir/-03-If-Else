// See https://aka.ms/new-console-template for more information
/*Even or Odd*/
Console.WriteLine("Write a number!");
int myNumber = int.Parse(Console.ReadLine());

if (myNumber % 2 == 0)
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

/*Ask the user to input their test score*/

Console.WriteLine("Write your test score 0-100");
int score= int.Parse(Console.ReadLine());
if (score >= 90 && score <= 100)
{
    Console.WriteLine("A");
}
else if (score >= 80 && score <= 89)
{
    Console.WriteLine("B");
}
else if (score >= 70 && score <= 79)
{
    Console.WriteLine("C");
}
else if (score >= 60 && score <= 69)
{
    Console.WriteLine("D");
}
else
{
    Console.WriteLine("F");
}