Console.ForegroundColor = ConsoleColor.Green;



// N1
string[] names = { "Shodiyor", "Samandar", "G'ayrat", "Shoxsuvar", "Benzema", "Messi", "CR7", "Jon", "Uik", "Toretto" };
int[] ball = { 10, 20, 70, 30, 50, 80, 90, 60, 100, 40 };

int a = 0;

for (int i = 0; i < ball.Length - 1; i++)
{
    for (int j = i + 1 ; j<ball.Length; j++)
    {
        if (ball[i] > ball[j])
        {
            a = ball[i];
            ball[i] = ball[j];
            ball[j] = a;
        }
    }    
    

}

for (int i = 0;i < ball.Length; i++)
{
    Console.WriteLine(ball[i]);
}

//1
Console.WriteLine(ball.Max());
//2
Console.WriteLine(ball[ball.Length/2]);
//3
Console.WriteLine(ball.Min());
//4
int count = 0;
for  (int i = 0;i < ball.Length ; i++)
{
    if (ball[i] > 80)
    {
        count++;
    }
}
Console.WriteLine($"{ count} kishi 80 balldan yuqori olgan");
//5
count = 0;
for (int i = 0; i < ball.Length; i++)
{
    if (ball[i] > 90)
    {
        count++;
    }
}
Console.WriteLine($"{count} kishi 90 balldan yuqori olgan");


//6
int get = 0;
for (int i = 0; i < ball.Length - 1; i++)
{
    for (int j = i + 1; j < ball.Length; j++)
    {
        if (ball[i] < ball[j])
        {
            get = ball[i];
            ball[i] = ball[j];
            ball[j] = get;
        }
    }
}

for  (int i = 0; i < ball.Length; i++)
{
    if (ball[i] >= 90)
    {
        Console.WriteLine($"--> 90 dan tepa {names[i]}");
    }
    else if (ball[i] >= 80)
    {
        Console.WriteLine($"--> 80 dan tepa {names[i]}");
    }
    else if (ball[i] >= 70)
    {
        Console.WriteLine($"--> 70 dan tepa {names[i]}");
    }
    else if (ball[i] >= 60)
    {
        Console.WriteLine($"--> 60 dan tepa {names[i]}");
    }
    else if (ball[i] >= 50)
    {
        Console.WriteLine($"--> 50 dan tepa {names[i]}");
    }
    else if (ball[i] >= 40)
    {
        Console.WriteLine($"--> 40 dan tepa {names[i]}");
    }
}



// N2

string[] name = new string[10] {"Birthday","New Year","Mothers' day","Child day","Mustaqillik day",
                                "Hapines day","my day","some day","any day","a day"};
DateTime[] dateTimes = new DateTime[10];
dateTimes[0] = new DateTime(2023, 12,10);
dateTimes[0] = new DateTime(2023, 01, 13);
dateTimes[0] = new DateTime(2023, 11, 9);
dateTimes[0] = new DateTime(2023, 02, 12);
dateTimes[0] = new DateTime(2023, 10, 17);
dateTimes[0] = new DateTime(2023, 03, 7);
dateTimes[0] = new DateTime(2023, 09, 25);
dateTimes[0] = new DateTime(2023, 04, 3);
dateTimes[0] = new DateTime(2023, 08, 27);
dateTimes[0] = new DateTime(2023, 05, 1);
dateTimes[0] = new DateTime(2023, 07, 29);
//...