Console.WriteLine("Напишите свое имя ");
string username = Console.ReadLine()!;

if (username.ToLower() == "маша")
{
 Console.WriteLine("Так это же Маша!");
}
else
{
 Console.Write("Привет, ");
 Console.WriteLine(username);
}