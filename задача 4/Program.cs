//Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, 
//добавляя индексы каждого элемента.
int[,,] my3Array = new int[3,3,2];
int count = 10;


for (var i = 0; i < my3Array.GetLength(0); i++)
{
    for (var j = 0; j < my3Array.GetLength(1); j++)
    {
        for (var k = 0; k < my3Array.GetLength(2); k++)
        {
            my3Array[i,j,k] = count;
            count++;
        }
    }
}

for (var i = 0; i < my3Array.GetLength(0); i++)
{
    for (var j = 0; j < my3Array.GetLength(1); j++)
    {
        for (var k = 0; k < my3Array.GetLength(2); k++)
        {
            Console.WriteLine(my3Array[i,j,k] + $" - Строка: {i + 1}; Столбец: {j + 1}; Ширина: {k + 1}");
        }
    }
}