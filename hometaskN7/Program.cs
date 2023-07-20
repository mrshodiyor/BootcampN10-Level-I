Console.ForegroundColor = ConsoleColor.Green;

DateOnly[] days = new DateOnly [5];
days[0] = new DateOnly(2023, 07, 19);
days[1] = new DateOnly(2023, 07, 18);
days[2] = new DateOnly(2023, 07, 17);
days[3] = new DateOnly(2023, 07, 16);
days[4] = new DateOnly(2023, 07, 15);

TimeSpan[] timeSpans = new TimeSpan[5];
timeSpans[0] = new TimeSpan(8,0,0);
timeSpans[1] = new TimeSpan(7,0,0);
timeSpans[2] = new TimeSpan(6,0,0);
timeSpans[3] = new TimeSpan(8,0,0);
timeSpans[4] = new TimeSpan(8,0,0);

int[] sleepBreak = new int[5] {0,2,3,0,0};

for  (int i = 0; i < days.Length; i++)
{
    string add = days[i].ToString();
    float result = (float)(timeSpans[i].Hours - sleepBreak[i]) / (8 + 0) * 10;
    Console.WriteLine($"{add}  -  {timeSpans[i].Hours} Hours - {result} score");
}