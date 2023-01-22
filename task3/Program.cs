﻿/* Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

int GetNumber (string message){
    int result = 0;
    while(true){
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result)&&result>0) break;
        else Console.WriteLine("Введите коректное число");
    }
    return result;
    
}
int GetMatrixTrio(int n){
    int[] array = new int [n];
    for(int i = 1; i<n;i++){
        array[i-1] =(int)Math.Pow(i,3);
        array[^1] = (int)Math.Pow(i+1,3);
    }
    Console.WriteLine(string.Join(" ", array));
    return 0;
}
int number = GetNumber("Введите число: ");
int[] result = new int [GetMatrixTrio(number)];

Console.WriteLine(string.Join(" ", result));