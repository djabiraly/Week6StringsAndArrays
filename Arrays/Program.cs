
string[] fruitBasket = { "kiwi", "mango", "apple", "avocado" };

Console.WriteLine($"There are {fruitBasket.Length} fruit in your Basket.");

//Console.WriteLine(fruitBasket[0]);
//Console.WriteLine(fruitBasket[1]);
//Console.WriteLine(fruitBasket[2]);
//Console.WriteLine(fruitBasket[3]);

//fruitBasket[3] = "plum";
//fruitBasket[1] = "coconut";

//Console.WriteLine(fruitBasket[0]);
//Console.WriteLine(fruitBasket[1]);
//Console.WriteLine(fruitBasket[2]);
//Console.WriteLine(fruitBasket[3]);

for(int i = 0; i < fruitBasket.Length; i++)
{
    Console.WriteLine(fruitBasket[i]);
}

fruitBasket[3] = "plum";
fruitBasket[1] = "coconut";


for (int i = 0; i < fruitBasket.Length; i++)
{
    Console.WriteLine(fruitBasket[i]);
}