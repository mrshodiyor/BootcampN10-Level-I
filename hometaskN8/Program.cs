
Console.ForegroundColor = ConsoleColor.Green;

// N1

// List
//1 -> Sinfxonani list deb olsak bo'ladi, U o'z ichida o'quvchilarni saqlab turadi
//2 -> Katta moshinalar turadigan stoyankani list ga o'xshatsak bo'ladi, u ko'plab mashinalarni o'z ichida saqlab turadi
//3 -> Telefondagi Settings programmani listga o'xshatsa bo'ladi, u o'z ichida ko'plab mini setings bo'limlarini o'z ichiga oladi

// Stack
//1 -> kompyuter korzinkasi, oxirgi o'chirilgan ma'lumot birinchida turadi
//2 -> mashina tashidgan yuk mashinasi, birinchi solingan mashina oxirgi bo'lib chiqadi
//3 -> masalan qavat - qavat solingan mevali muzqaymoq, birinchii solingan qavatiini oxirgi bo'lib yeymiz

// Queue  
//1 -> ekskalator, birinchi bo'ib zinaga chiqqan birinchib bo'lib tushibketadi
//2 -> zavoddagi ranga bo'yash xonasi, 1-kirgani 1-chiqdi
//3 -> telegdamda kanalda avtodelet funksyasi, pirinchi qo'yilgan post avtomatik 1 kunda o'chib ketaveradi

//LinkedList
//1 -> 

//Dictionary
//1 -> list ni olsak boladi, uni indexsi orqali qiymatiga murojat qilolamiz
//2 -> Instagram URL , url profilga tegishli bo'ladi
//3 -> 




// N2

var names = new List<string>();
names.Add("G'ayrat");
names.Add("Falonchi");
names.Add("Bob");
names.Add("John");

TimeSpan[] planesTimme = new TimeSpan[3];
planesTimme[0] = new TimeSpan(12, 0, 0);
planesTimme[1] = new TimeSpan(9, 30, 0);
planesTimme[2] = new TimeSpan(15, 0, 0);

var emails = new List<string>();
emails.Add("G'ayrat@gmail.com");
emails.Add("Falonchi@gmail.com");
emails.Add("Bob@gmail.com");
emails.Add("John@gmail.com");



start:
Console.Write("1 - Ro'yxatdan O'tish\n2 - Biletllarni olish\nChoose: ");
var chooseFirst = Console.ReadLine();
Console.Clear();

switch (chooseFirst)
{
    case "1":
        Console.Write("Ismingizni kiriting: ");
        var name = Console.ReadLine();
        names.Add(name);
        Console.Write("Emailingizni kiriting: ");
        var email = Console.ReadLine();
        emails.Add(email);
        Console.Write("Yoshingizni kiriting: ");
        int age = int.Parse(Console.ReadLine());
        if (age < 18)
        {
            Console.WriteLine($"Uzr, hurmatli {name} siz loyidan foydalanish uchun kichkinasiz");
        }
        else if (age > 90)
        {
            Console.WriteLine($"Uzr, hurmatli {name} loyiha yoshlar uchun mo'ljallangan");
        }
        else if (age < 90 && age > 18)
        {
            Console.Clear();
            Console.WriteLine("Sucesfully Add\n\n");
            Console.Write("1 - Orqaga: ");
            int chooseCase1 = int.Parse(Console.ReadLine());
            if (chooseCase1 == 1)
            {
                Console.Clear();
                goto start;
            }
            goto start;

        }
        break;



    case "2":
        Random random = new Random();
        int fly = random.Next(0, 3);
        Console.WriteLine($"Uchish vaqti -> {planesTimme[fly]}");

        Console.Write("1 - Message: ");
        int chooseCase2 = int.Parse(Console.ReadLine());
        if (chooseCase2 == 1)
        {
            Console.Clear();
            for (int i = 0; i < names.Count; i++)
            {


                Console.WriteLine($"\n\nHello {names[i]}. Welcome to onboard. AviaSale Team. \nYour data is being processed and we will inform updates for you as soon as possible. \nAviaSale Team . Congratulations! Your flight ticket is booked for {planesTimme[fly]}. AviaSale Team.");
            }
        }

        break;

}

//string pattern = @"^[a-zA-Z0-9.]+@[a-zA-Z0-9]+\.[a-zA-Z0-9]+$";


