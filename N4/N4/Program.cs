Console.ForegroundColor = ConsoleColor.Green;


// N1
string str = "Lorem ipsum dolor sit amet consectetur adipisicing elit. quaerat est quas commodi quibusdam labore, nihil doloribus quam temporibus inventore optio expedita consectetur voluptatem QUIDEM nulla soluta earum. Numquam rem alias minima culpa iste distinctio. Eum similique est consequuntur minus, odio nisi recusandae iure asperiores facere, reiciendis voluptate maiores! Repellat, dolorum!";
int ball = 100;
int count = 0;


string[] words = str.Split();

int twenty = (words.Length * 20) / 100;


    if (words.Length < 500)
    {
        ball = ball - 5;
    }




string[] dots = str.Split(". ");


for (int i = 0; i < dots.Length; i++)
{
    if (char.IsLower(dots[i][0]))
    {
        ball = ball - 5;
    }
}



for (int i = 0;i < words.Length; i++)
{
    if (words[i] == words[i].ToUpper())
    {
        ball = ball - 10;
    }
}



for (int i = 0; i < words.Length; i++)
{
    if (words[i].Length > 20)
    {
        ball = ball - 20;
    }
}



for (int i = 0; i < words.Length; i++ )
{
    for (int j = 0; j < words.Length; j++)
    {
        if (words[i] == words[j])
        {
            count += 1;
            

        }
    }
    

    if (twenty < count)
    {
        ball = ball - 5;
    }

    count = 0;
}


Console.WriteLine(ball);

//ghjk













// N2

string[] symbols = new string[10] {"-coder","-junior","-7777","-unstotable","-senior","-middle","spider","-gamer","-c#","-dotnet"};
string[] readyName = new string[5] { "Shodiyor-uz", "Coder-senior", "IlonMusk-Tesla", "Zuckerberk", "MacDonalds" };

Console.Write("Ismingizni kiriting: ");
string name = Console.ReadLine();
Console.Write("Familyangizni kiriting: ");
string secondName = Console.ReadLine();

Random random = new Random();
int index = random.Next(symbols.Length);

string fullName = name + "-" + secondName;

for (int i = 0; i < readyName.Length; i++)
{
    if (fullName != readyName[i])
    {
        fullName = fullName + symbols[index];
        break;
    }
}

Console.WriteLine(fullName);



