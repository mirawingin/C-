//Знакомство с языками программирования (семинары) домашнее задание №2

//Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

/*int number = 876;

if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine("Число кратно 7 и 23");
}
else
{
    Console.WriteLine("Число не кратно 7 и 23");
}

//Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y),
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

       /*int x = -200;
        int y = 456;

        int quadrant;

        if (x > 0 && y > 0)
        {
            quadrant = 1;
        }
        else if (x < 0 && y > 0)
        {
            quadrant = 2;
        }
        else if (x < 0 && y < 0)
        {
            quadrant = 3;
        }
        else
        {
            quadrant = 4;
        }

        Console.WriteLine("Точка находится в {0} координатной четверти.", quadrant);


//Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99]
//и показывает наибольшую цифру числа.

 /*int number = 95;

 int maxDigit = 0;

        while (number > 0)
        {
            int digit = number % 10;

            if (digit > maxDigit)
            {
                maxDigit = digit;
            }

            number /= 10;
        }

        Console.WriteLine("Наибольшая цифра числа: {0}", maxDigit);

//Задача 4: Напишите программу, которая на вход принимает натуральное число N, 
//а на выходе показывает его цифры через запятую.

int number = 45637;

{
    // Преобразуем число в строку
    string digitsString = number.ToString();

    // Выводим каждую цифру, кроме последней, с запятой
    for (int i = 0; i < digitsString.Length - 1; i++)
    {
        Console.Write(digitsString[i] + ", ");
    }

    // Выводим последнюю цифру без запятой
    Console.WriteLine(digitsString[digitsString.Length - 1]);
}