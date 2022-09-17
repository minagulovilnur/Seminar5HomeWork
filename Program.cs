/*

Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет
 количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2

int[]randomarray(int size){
    int[]array = new int[size];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(100, 1000);

        } return array;
}
void showarray(int[]array){
   Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
int checkchet(int[]array){
   int count =0;
    for (int i = 0; i < array.Length; i++)
    {
        if ( array[i] % 2 == 0) count++;
    }
    return count;
}
   

Console.WriteLine("Input size a massive: " );
int size = Convert.ToInt32(Console.ReadLine());
int[]array = randomarray(size);
Console.WriteLine("Massive -  ");showarray(array);
        Console.WriteLine($"Количество четных элементов в массиве равно {checkchet(array)}");

*/


/*

Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на 
нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0


int[] randomarray(int size, int min, int max){
    int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = new Random().Next(min, max - 1);
        }
        return array;
}

void showarray(int[] array){
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int summnechEl(int[]array){  
    int summIndex = 0;
    for (int i = 1; i < array.Length; i++)
    {
        summIndex += array[i];
        i+=1;
    }   
    return summIndex;

}


Console.WriteLine("Input size");
int size  = Convert. ToInt32(Console.ReadLine());

Console.WriteLine("Input min");
int min  = Convert. ToInt32(Console.ReadLine());

Console.WriteLine("Input max");
int max  = Convert. ToInt32(Console.ReadLine());

int[]array = randomarray(size,min,max);
showarray(array);
Console.WriteLine($"Сумма элементов стоящих на нечетных позициях = {summnechEl(array)}");
*/


/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

double[] randomArray(double[] array){
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToDouble(new Random().Next(100, 1000));
        } return array;
}

void showArray(double[] array){
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
  
Console.WriteLine("Input size a massive: " );
int size = Convert.ToInt32(Console.ReadLine());
double[]array = new double[size];
randomArray(array);
Console.Write("Massive -  ");showArray(array);


double min = Int32.MaxValue; //Представляет наибольшее возможное значение типа Int32. Это поле является константой.
double max = Int32.MinValue; //Представляет наименьшее возможное значение типа Int32. Это поле является константой.

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
        else min = array[i];        
}

Console.WriteLine();
Console.WriteLine($"Разница между макс. и мин. элеменатами массива равна {max - min} ");



























