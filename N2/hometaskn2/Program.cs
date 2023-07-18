Console.ForegroundColor = ConsoleColor.Green;


// N1
/*
string[] password = new string[3];
string letter; string symbol;


    Console.WriteLine("Password length max 12 || use (letters, num, symbol)");
    Console.Write("Password uchun son kiriting: ");
    string son = Console.ReadLine();
    password[0] = son;
    if (son.Length <= 12)
    {
        Console.Write("Password uchun harf kiritinhg: ");
        letter =  Console.ReadLine();
        if (son.Length + letter.Length <= 12)
        {
            password[1] = letter;
            Console.Write("Password uchun Symbol kiriting: ");
            symbol = Console.ReadLine();
            password[2] = symbol;
        }
        else
        {
            Console.WriteLine("Limit reached, Try again !");
        }
    

    }
    else
    {
    Console.WriteLine("Limit reached, Try again !");
    }

Console.WriteLine($"Your Password-->  { password[0] + password[1] + password[2]}");

*/



// N2

/*
Console.Write("Email kiriting: ");
string email = Console.ReadLine();

char[] charArr = email.ToCharArray();

char[] notChar; 
for(int i = 0; i < charArr.Length; i++)
{
    if(charArr[i]) { }...
}

*/