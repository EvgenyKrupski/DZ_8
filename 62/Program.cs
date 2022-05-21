﻿/*Заполните спирально массив 4 на 4.*/
/*1     2   3   4

12   13  14   5

11   16  15   6

10    9  8    7
*/

int a = 4;
int [,] spiralArray = new int[a,a];
int temp = 1;
int i = 0;
int j = 0;

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }
}

while(temp<=a*a)
{
    spiralArray[i,j] = temp;
    temp ++;
    if (i<=j+1 && i+j<a-1)
    {
        j++;
    }
    else if(i<j && i+j>=a-1)
    {
        i++;
    }
    else if(i>=j && i+j>a-1)
    {
        j--;
    }
    else
    {
        i--;
    }
}

PrintArray(spiralArray);
