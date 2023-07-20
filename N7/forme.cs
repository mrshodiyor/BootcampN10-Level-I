using N7;
List<Student> student = new List<Student>()
{
    new Student(){ Id = 1, FullName = "Abdulxayev Jasurbek Anvar O'g'li",  BirthDay = new DateTime(2005, 12, 12),  EduType = "DotNET", Payment = 2400000, PaymentAmount = 2000000 },
    new Student(){ Id = 2, FullName = "Abdumannonov Botirjon Davlat O'g'li",  BirthDay = new DateTime(2004, 1, 17),  EduType = "Python", Payment = 1600000, PaymentAmount = 500000 },
    new Student(){ Id = 3, FullName = "Abdurahmonov Azizbek Alisher O'g'li",  BirthDay = new DateTime(2003, 12, 12),  EduType = "DotNET", Payment = 2400000, PaymentAmount = 3000000 },
    new Student(){ Id = 4, FullName = "Anvarjonov Ozodbek Avazxon O'g'li",  BirthDay = new DateTime(2003, 11, 1),  EduType = "SMM", Payment = 1450000, PaymentAmount = 2500000 },
    new Student(){ Id = 5, FullName = "Asadov Firdavs Asqarbek O'g'li",  BirthDay = new DateTime(2006, 7, 18),  EduType = "Dizayn", Payment = 1900000, PaymentAmount = 0 },
    new Student(){ Id = 6, FullName = "Eshmurodov Umarali Abduhalim O'g'li",  BirthDay = new DateTime(2005, 12, 12),  EduType = "SMM", Payment = 1450000, PaymentAmount = 900000 },
    new Student(){ Id = 7, FullName = "Jo'raboyev Boburjon Murodjon O'g'li",  BirthDay = new DateTime(2007, 4, 12),  EduType = "Dizayn", Payment = 1900000, PaymentAmount = 2000000 },
    new Student(){ Id = 8, FullName = "Karimjonov Ilhom Ramzjon O'g'li",  BirthDay = new DateTime(2005, 8, 1),  EduType = "DotNET", Payment = 2400000, PaymentAmount = 2500000 },
    new Student(){ Id = 9, FullName = "Komiljonov Muhammadaziz Abduraximovich",  BirthDay = new DateTime(2002, 1, 12),  EduType = "Python", Payment = 1600000, PaymentAmount = 1500000 },
    new Student(){ Id = 10, FullName = "Rashidov Asadbek",  BirthDay = new DateTime(2001, 3, 12),  EduType = "Dizayn", Payment = 1900000, PaymentAmount = 1900000 },
    new Student(){ Id = 11, FullName = "Sadriddinov Abdurahmon Jurabek O'g'li",  BirthDay = new DateTime(2003, 5, 12),  EduType = "Python", Payment = 1600000, PaymentAmount = 1700000 },
    new Student(){ Id = 12, FullName = "Sattorova Habiba Shuxrat Qizi",  BirthDay = new DateTime(2006, 2, 7),  EduType = "DotNET", Payment = 2400000, PaymentAmount = 2000000 },
    new Student(){ Id = 14, FullName = "Tolibov Firdavs Odil O'g'li",  BirthDay = new DateTime(2003, 5, 6),  EduType = "DotNET", Payment = 2400000, PaymentAmount = 2700000 },
    new Student(){ Id = 15, FullName = "To'rayev Dinur Alisher O'g'li",  BirthDay = new DateTime(2002, 8, 22),  EduType = "Python", Payment = 1600000, PaymentAmount = 2000000 },
    new Student(){ Id = 16, FullName = "Vositov Muhammadrizo Muhammadtolib O'g'li",  BirthDay = new DateTime(2000, 11, 20),  EduType = "SMM", Payment = 1450000, PaymentAmount = 1400000 },
    new Student(){ Id = 17, FullName = "Xaybullayev Mexroj Mansurjonovich",  BirthDay = new DateTime(2005, 2, 12),  EduType = "Dizayn", Payment = 1900000, PaymentAmount = 2000000 },
    new Student(){ Id = 18, FullName = "Xolmuratov Qurbonali Suxrob O'g'li",  BirthDay = new DateTime(2006, 5, 9),  EduType = "DotNET", Payment = 2400000, PaymentAmount = 2400000 },
};

Console.Write("1 - Talabalar Ro'yxati\n2 - To'lovlar");
char chooseFirst = char.Parse(Console.ReadLine());
Console.Clear();

if (chooseFirst == '1')
{
    
        Console.Write("1 - DotNet developers\n2 - SMM\n3 - Dizayner\n4 - Python\nChoose: ");
        var chooseSecond = Console.ReadLine();
        if (chooseSecond == "1")
        {
            foreach (var item in student)
            {
                if (item.EduType == "DotNET")
                {
                    Console.WriteLine($"{item.FullName}  -  {item.EduType}  -  {item.Payment}");
                }
            }
        }
        if (chooseSecond == "2")
        {
            foreach (var item in student)
            {
                if (item.EduType == "DotNET")
                {
                        Console.WriteLine($"{item.FullName}  -  {item.EduType}  -  {item.Payment}");
                }
            }
        }
        if (chooseSecond == "3")
        {
        foreach (var item in student)
            {
                if (item.EduType == "DotNET")
                {
                    Console.WriteLine($"{item.FullName}  -  {item.EduType}  -  {item.Payment}");
                }
            }
        }
        if (chooseSecond == "4")
        {
            foreach (var item in student)
            {
                if (item.EduType == "Python")
                {
                    Console.WriteLine($"{item.FullName}  -  {item.EduType}  -  {item.Payment}");
                }
            }
        }
}
else if(chooseFirst == '2')
{
    Console.Write("1 - DotNet developers\n2 - SMM\n3 - Dizayner\n4 - Python\n5 - Jami\nChoose: ");
    var chooseSecond = Console.ReadLine();
    if (chooseSecond == "5")
    {
        Console.Clear();
        foreach (var item in student)
        {
            Console.WriteLine(item.FullName.PadRight(45, ' ') +$"       {item.Payment}" + $"       {item.PaymentAmount()}"+ $"       {item.GetAmount()}");
        }
        
    }
}













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


