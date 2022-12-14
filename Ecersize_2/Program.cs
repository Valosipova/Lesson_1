// Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите два числа:");

string first =  Console.ReadLine();
string second =  Console.ReadLine();
 
int number1 = int.Parse(first);
int number2 = int.Parse(second);
 
    if (number1 > number2)
  
    {
 
        Console.WriteLine($"{0} наибольшее число", number1);
    }
        
    else
 
    {
 
        Console.WriteLine("{0} наибольшее число ", number2);
 
    }
 
Console.ReadLine();