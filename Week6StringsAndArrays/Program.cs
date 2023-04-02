

String username = "Djabiraly";
Console.WriteLine(username.Length);
 Console.WriteLine($"The first latter in your name is {username[0]}.");

Console.WriteLine($"The Last latter in your name is {username[username.Length - 1]}.");

//Console.WriteLine(username[0]);
//Console.WriteLine(username[1]);
//Console.WriteLine(username[2]);
//Console.WriteLine(username[3]);
//Console.WriteLine(username[4]);
//Console.WriteLine(username[5]);
//Console.WriteLine(username[6]);
//Console.WriteLine(username[7]);
//Console.WriteLine(username[8]);

////a-counter

//int counter = 0;

//for (int i = 0; i < username.Length; i++)
//{
// if (username[i] == 'j')
//    {
//        counter++; //counter = counter + 1
//    }

//}

//Console.WriteLine($"Your name has {counter} j-latters.");

//replace
//a - 4

string updateUserName = username.Replace('d', '3').Replace('j', '9').Replace('a', '2');
Console.WriteLine(updateUserName);