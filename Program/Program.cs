using System;
//Данные на входе по условию
string[] array_one = new string[4] {"hello", "2", "worla", ":-)"}; //От количества элементов массива надо поменять значение кол-во элементов
string[] array_second = new string[array_one.Length]; //Второй массив, который программа формирует на выходе

void ArraySecond(string[] array_one, string[] array_second)
{
    int count = 0;
    for (int i = 0; i < array_one.Length; i++)
    {
    if(array_one[i].Length <= 3)
        {
        array_second[count] = array_one[i];
        count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++) //Цикл по схеме
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
ArraySecond(array_one, array_second); //Второй массив
PrintArray(array_second); //Вывод массива