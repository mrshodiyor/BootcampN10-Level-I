//using N7;

//List<Student> student = new List<Student>()
//{
//    new Student(){ Id = 1, FullName = "Abdulxayev Jasurbek Anvar O'g'li",  BirthDay = new DateTime(2005, 12, 12),  EduType = "DotNET", Payment = 2400000 },
//    new Student(){ Id = 2, FullName = "Abdumannonov Botirjon Davlat O'g'li",  BirthDay = new DateTime(2004, 1, 17),  EduType = "Python", Payment = 1600000 },
//    new Student(){ Id = 3, FullName = "Abdurahmonov Azizbek Alisher O'g'li",  BirthDay = new DateTime(2003, 12, 12),  EduType = "DotNET", Payment = 2400000 },
//    new Student(){ Id = 4, FullName = "Anvarjonov Ozodbek Avazxon O'g'li",  BirthDay = new DateTime(2003, 11, 1),  EduType = "SMM", Payment = 1450000 },
//    new Student(){ Id = 5, FullName = "Asadov Firdavs Asqarbek O'g'li",  BirthDay = new DateTime(2006, 7, 18),  EduType = "Dizayn", Payment = 1900000 },
//    new Student(){ Id = 6, FullName = "Eshmurodov Umarali Abduhalim O'g'li",  BirthDay = new DateTime(2005, 12, 12),  EduType = "SMM", Payment = 1450000 },
//    new Student(){ Id = 7, FullName = "Jo'raboyev Boburjon Murodjon O'g'li",  BirthDay = new DateTime(2007, 4, 12),  EduType = "Dizayn", Payment = 1900000 },
//    new Student(){ Id = 8, FullName = "Karimjonov Ilhom Ramzjon O'g'li",  BirthDay = new DateTime(2005, 8, 1),  EduType = "DotNET", Payment = 2400000 },
//    new Student(){ Id = 9, FullName = "Komiljonov Muhammadaziz Abduraximovich",  BirthDay = new DateTime(2002, 1, 12),  EduType = "Python", Payment = 1600000 },
//    new Student(){ Id = 10, FullName = "Rashidov Asadbek",  BirthDay = new DateTime(2001, 3, 12),  EduType = "Dizayn", Payment = 1900000 },
//    new Student(){ Id = 11, FullName = "Sadriddinov Abdurahmon Jurabek O'g'li",  BirthDay = new DateTime(2003, 5, 12),  EduType = "Python", Payment = 1600000 },
//    new Student(){ Id = 12, FullName = "Sattorova Habiba Shuxrat Qizi",  BirthDay = new DateTime(2006, 2, 7),  EduType = "DotNET", Payment = 2400000 },
//    new Student(){ Id = 14, FullName = "Tolibov Firdavs Odil O'g'li",  BirthDay = new DateTime(2003, 5, 6),  EduType = "DotNET", Payment = 2400000 },
//    new Student(){ Id = 15, FullName = "To'rayev Dinur Alisher O'g'li",  BirthDay = new DateTime(2002, 8, 22),  EduType = "Python", Payment = 1600000 },
//    new Student(){ Id = 16, FullName = "Vositov Muhammadrizo Muhammadtolib O'g'li",  BirthDay = new DateTime(2000, 11, 20),  EduType = "SMM", Payment = 1450000 },
//    new Student(){ Id = 17, FullName = "Xaybullayev Mexroj Mansurjonovich",  BirthDay = new DateTime(2005, 2, 12),  EduType = "Dizayn", Payment = 1900000 },
//    new Student(){ Id = 18, FullName = "Xolmuratov Qurbonali Suxrob O'g'li",  BirthDay = new DateTime(2006, 5, 9),  EduType = "DotNET", Payment = 2400000 },
//};

//int[,] balls = new int[,]
//{
//    { 90, 100, 75, 60 },
//    { 100, 100, 70, 0 },
//    { 90, 50, 60, 100 },
//    { 60, 50, 100, 90 },
//    { 100, 10, 75, 45 },
//    { 55, 85, 70, 60 },
//    { 95, 90, 40, 100 },
//    { 80, 100, 100, 40 },
//    { 65, 80, 100, 50 },
//    { 80, 90, 100, 60 },
//    { 90, 85, 65, 55 },
//    { 100, 55, 90, 100 },
//    { 80, 75, 90, 60 },
//    { 90, 90, 100, 55 },
//    { 100, 60, 90, 75 },
//    { 90, 80, 50, 100 },
//    { 100, 100, 60, 60 },
//    { 90, 50, 80, 90 },
//};





//for (int i = 0; i < 16; i++)
//{
//    {
//        Console.Write(student[i].FullName + "\t"+"\t");
//        for (int j = 0; j < 4; j++)
//        {


//            Console.Write(balls[i, j] + "\t");
//        }
//        Console.WriteLine();

//    }
//}   

TimeOnly startTime = new TimeOnly(8, 0, 0);
TimeOnly endTime = new TimeOnly(17,0,0);

DateTime[] mitings = new DateTime[10];
mitings[0] = new DateTime(2023,7,18,9,0,0);
mitings[1] = new DateTime(2023, 7, 18, 9, 0, 0);
mitings[2] = new DateTime(2023, 7, 19, 18, 0, 0);
mitings[3] = new DateTime(2023, 7, 20, 12, 0, 0);
mitings[4] = new DateTime(2023, 7, 21, 15, 0, 0);
mitings[5] = new DateTime(2023, 7, 19, 21, 0, 0);
mitings[6] = new DateTime(2023, 7, 18, 8, 0, 0);
mitings[7] = new DateTime(2023, 7, 20, 19, 0, 0);
mitings[8] = new DateTime(2023, 7, 23, 10, 0, 0);
mitings[9] = new DateTime(2023, 7, 24, 11, 0, 0);


TimeSpan[] timeSpans = new TimeSpan[10];
timeSpans[0] = new TimeSpan(20,20,20);
timeSpans[1] = new TimeSpan(10,10,10);
timeSpans[2] = new TimeSpan(20, 20, 20);
timeSpans[3] = new TimeSpan(30,30,30);
timeSpans[4] = new TimeSpan(25, 25, 25);
timeSpans[5] = new TimeSpan(35, 35, 35);
timeSpans[6] = new TimeSpan(15, 15, 15);
timeSpans[7] = new TimeSpan(30, 30, 30);
timeSpans[8] = new TimeSpan(20, 20, 20);
timeSpans[9] = new TimeSpan(10, 10, 10);

//1
for (int i = 0; i < 10; i++)
{
    if (mitings[i].Hour < startTime.Hour || mitings[i].Hour > endTime.Hour)
    {
        Console.WriteLine(mitings[i]);
    }
}

Console.WriteLine("\n\n");

//2
for (int i = 0;i < 10; i++)
{
    if (timeSpans[i].Minutes > 30)
    {
        Console.WriteLine(mitings[i]);
    }
}


//3

int count = 0;
for (int i = 0; i<10 ; i++)
{
    count += timeSpans[i].Minutes;
}

Console.WriteLine($"All mitings time   {count}");



