Console.ForegroundColor = ConsoleColor.Green;

Console.Write("Ismingizni kiriting: ");
string name = Console.ReadLine();
Console.Write("Familiyangizni kiriting: ");
string secondName = Console.ReadLine();
Console.Write("yoshingizni kiriting: ");
int age = int.Parse( Console.ReadLine());

Console.Clear();
DateTime time = DateTime.Now;

Console.WriteLine($"-> {time}\n-> {name}\n-> {secondName}\n-> {age}\n-> 125.4 $");
