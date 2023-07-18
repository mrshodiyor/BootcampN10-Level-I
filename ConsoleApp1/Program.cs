//using ConsoleApp1;
//using System.Reflection.PortableExecutable;

Console.ForegroundColor = ConsoleColor.Green;

//List<Student> student = new List<Student>()
//{
//    new Student(){ Id = 1, FullName = "Abdulxayev Jasurbek Anvar O'g'li",  Age = 18,  EduType = "DotNET", Payment = 2500000 },
//    new Student(){ Id = 2, FullName = "Abdumannonov Botirjon Davlat O'g'li",  Age = 20,  EduType = "Python", Payment = 2600000 },
//    new Student(){ Id = 3, FullName = "Abdurahmonov Azizbek Alisher O'g'li",  Age = 21,  EduType = "DotNET", Payment = 2500000 },
//    new Student(){ Id = 4, FullName = "Anvarjonov Ozodbek Avazxon O'g'li",  Age = 16,  EduType = "SMM", Payment = 2800000 },
//    new Student(){ Id = 5, FullName = "Asadov Firdavs Asqarbek O'g'li",  Age = 17,  EduType = "Dizayn", Payment = 2900000 },
//    new Student(){ Id = 6, FullName = "Eshmurodov Umarali Abduhalim O'g'li",  Age = 23,  EduType = "SMM", Payment = 2800000 },
//    new Student(){ Id = 7, FullName = "Jo'raboyev Boburjon Murodjon O'g'li",  Age = 22,  EduType = "Dizayn", Payment = 2900000 },
//    new Student(){ Id = 8, FullName = "Karimjonov Ilhom Ramzjon O'g'li",  Age = 21,  EduType = "DotNET", Payment = 2500000 },
//    new Student(){ Id = 9, FullName = "Komiljonov Muhammadaziz Abduraximovich",  Age = 19,  EduType = "Python", Payment = 2600000 },
//    new Student(){ Id = 10, FullName = "Rashidov Asadbek",  Age = 20,  EduType = "Dizayn", Payment = 2900000 },
//    new Student(){ Id = 11, FullName = "Sadriddinov Abdurahmon Jurabek O'g'li",  Age = 19,  EduType = "Python", Payment = 2600000 },
//    new Student(){ Id = 12, FullName = "Sattorova Habiba Shuxrat Qizi",  Age = 16,  EduType = "DotNET", Payment = 2500000 },
//    new Student(){ Id = 14, FullName = "Tolibov Firdavs Odil O'g'li",  Age = 24,  EduType = "DotNET", Payment = 2500000 },
//    new Student(){ Id = 15, FullName = "To'rayev Dinur Alisher O'g'li",  Age = 21,  EduType = "Python", Payment = 2600000 },
//    new Student(){ Id = 16, FullName = "Vositov Muhammadrizo Muhammadtolib O'g'li",  Age = 25,  EduType = "SMM", Payment = 2800000 },
//    new Student(){ Id = 17, FullName = "Xaybullayev Mexroj Mansurjonovich",  Age = 16,  EduType = "Dizayn", Payment = 2900000 },
//    new Student(){ Id = 18, FullName = "Xolmuratov Qurbonali Suxrob O'g'li",  Age = 23,  EduType = "DotNET", Payment = 2500000 },
//};



//Console.WriteLine("1-Talabaar ro'yxati: ");
//var chooseFirst = Console.ReadLine();
//if (chooseFirst == "1")
//{
//    Console.Clear();
//}

//Console.WriteLine("1- DotNET\n2- SMM\n3- Python\n4- Dizayn\nChoose: ");
//string chooseSecond = Console.ReadLine();

//foreach(var item in student) 
//switch (chooseSecond)
//{
//    case "1":



//                if (item.EduType == "DotNET")
//                    {
//                        Console.WriteLine($"{item.Id},{item.FullName},{item.Age},{item.EduType},{item.Payment}");
//                    }



//    break;  

//    case "2":

//                if (item.EduType == "SMM")
//                {
//                    Console.WriteLine($"{item.Id},{item.FullName},{item.Age},{item.EduType},{item.Payment}");
//                }

//    break;

//    case "3":
//            if (item.EduType == "Python")
//            {
//                Console.WriteLine($"{item.Id},{item.FullName},{item.Age},{item.EduType},{item.Payment}");
//            }
//    break;

//    case "4":
//            if (item.EduType == "Dizayn")
//            {
//                Console.WriteLine($"{item.Id},{item.FullName},{item.Age},{item.EduType},{item.Payment}");
//            }
//    break;


//    }



string[] names = { "Bob", "Adm", "Lee", "Sigma", "Faktus" };
DateTime[] birthday = new DateTime[5];
birthday[0] = new DateTime(2000, 12, 02);
birthday[1] = new DateTime(2012, 23, 11);
birthday[2] = new DateTime(2004, 19, 05);
birthday[3] = new DateTime(2002, 02, 14);
birthday[4] = new DateTime(2010, 10, 03);

for  (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (birthday[i].Day < birthday[j].Day)
        {
            int count = i;
        }
    }

}

Console.WriteLine(birthday[0].Day.ToString());