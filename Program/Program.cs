using System;

string[] array_one = new string[5] {"123", "23", "hello", "world", "res"};
string[] array_second = new string[array_one.Length];

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
