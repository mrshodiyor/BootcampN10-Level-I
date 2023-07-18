Console.ForegroundColor = ConsoleColor.Green;

// N1

/*
string[] questions = {"1. Who is the creator of Facebook ?",
                      "2. Who is the owner of Tesla company ?",
                      "3. Who is the GOAT ?",
                      "4. Which color of the sky ?",
                      "5. When was Nyuton born ?"};


string[] answer = new string[10]{"(A) Elon Musk" ,"(B) Mark Zuckerberg", "(A) Elon Musk","(B) Mark Zukerberg",
                    "(A) Messi","(B) Ronaldo","(A) Blue","(B) Red","(A) 6.02.1643","(B) 4.02.1643"};

string[] abQuestions = new string[5];

int jer = 0;

for (int i = 0; i < questions.Length; i++)
{
    Console.WriteLine(questions[i]);
    
    int jir = 0;
    while ( jir < 1)
    {
        Console.WriteLine(answer[jer]);
        Console.WriteLine(answer[jer+1]);
        string AB = Console.ReadLine();
        abQuestions[i] = AB;
        
        jer += 2;
        jir++;
    }
}


int ball = 0;



//1
if (abQuestions[0] == "A" || abQuestions[0] == "a")
{
    Console.WriteLine($"\n\n\n\n\nQuestion:{questions[0]}\nAnswer: {answer[1]}");
}
else if(abQuestions[0] == "B" || abQuestions[0] == "b")
{
    ball += 10;
    Console.WriteLine("\n\n\n1-question True|| +10 ball");
}

//2
if (abQuestions[1] == "B" || abQuestions[1] == "b")
{
    Console.WriteLine($"\nQuestion:{questions[1]}\nAnswer: {answer[2]}");
}
else if (abQuestions[1] == "A" || abQuestions[1] == "a")
{
    ball += 10;
    Console.WriteLine("2-question True|| +10 ball");
}

//3
if (abQuestions[2] == "B" || abQuestions[2] == "b")
{
    Console.WriteLine($"\nQuestion:{questions[2]}\nAnswer: {answer[4]}");
}
else if (abQuestions[2] == "A" || abQuestions[2] == "a")
{
    ball += 10;
    Console.WriteLine("3-question True|| +10 ball");
}

//4
if (abQuestions[3] == "B" || abQuestions[3] == "b")
{
    Console.WriteLine($"\nQuestion:{questions[3]}\nAnswer: {answer[6]}");
}
else if (abQuestions[3] == "A" || abQuestions[3] == "a")
{
    ball += 10;
    Console.WriteLine("4-question True|| +10 ball");
}

//5
if (abQuestions[4] == "A" || abQuestions[4] == "a")
{
    Console.WriteLine($"\nQuestion:{questions[4]}\nAnswer: {answer[9]}");
}
else if (abQuestions[4] == "B" || abQuestions[4] == "b")
{
    ball += 10;
    Console.WriteLine("5-question True|| +10 ball");
}



Console.WriteLine($"\nYou have 50 -/- {ball} ball");

*/









//  N2

Console.Write("Enter a number: ");
int numA = int.Parse(Console.ReadLine());

int count = 0;
while (true)
{

    
    Console.WriteLine("Enter a command (*,/,-,+, e -> exit) : ");
    char command = char.Parse(Console.ReadLine());

    if (command == 'e')
    {
        break;
    }

    else
    {
        Console.WriteLine("Enter a number: ");
        int numB = int.Parse(Console.ReadLine());
    
        if (command == '*')
        {
            count = numA * numB;
        }
        else if (command == '/')
        {
            count = numA / numB;
        }
        else if (command == '-')
        {
            count = (numA - numB);
        }
        else if (command == '+')
        {
            count = numA + numB;
        }
    
    
    }

    Console.WriteLine($"Result: {count}");

    

}