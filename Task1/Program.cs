// Напишите программу, которая будет принимать на вход двк числа и выводить, 
// является ли второе число кратным первому.
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

//1. В программу вводится первое число
//2. В программу вводится второе число
//3. Найти остаток от деления ч1 и ч2
// проверить: если сотаток не равен 0, то показать его
// иначе показать сообщение "кратно"

//Console.WriteLine('start')

int firstNumber = 25;
int secondNumber = 6;

int remainder = firstNumber % secondNumber;

if (remainder != 0)
{
    Console.WriteLine(remainder);
}
else
{
    Console.WriteLine("Кратно");
}

//Console.WriteLine('end')