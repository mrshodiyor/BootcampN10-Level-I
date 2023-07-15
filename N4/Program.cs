//string str = "IBROHIMJONOV SHODIIYOOR ZIYODALI";

//string[] arr = new string[3];  
//for (int i = 0; i<3;i++)
//{
//    arr[i] = str.Split('');
//}

string input = "IBROHIMJONOV SHODIIYOOR ZIYODALIVICH";
string[] words = input.Split(' ');  

for (int i = 0; i < words.Length; i++)
{
    char firstLetter = char.ToUpper(words[i][0]);
    string restOfWord = words[i].Substring(1).ToLower();
    words[i] = firstLetter + restOfWord;
}

string output = string.Join(" ", words);
Console.WriteLine(output);
