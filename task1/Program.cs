/* Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да */
int GetNumber(string message){
    int result = 0;
    while(true){
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result)&& (result > 10000)&&(result<100000)) break;
        else Console.WriteLine("Вы ввели не коректное число");       
    }
    return result;
}
int GetPalimdroms(int x){
    int num1 = x/10000;
    int num5 = x % 10;
    int num2 = x/1000%10;
    int num4 = x % 100/10;
    if((num1==num5)&&(num2==num4))return 1;
    else return 0;
}

int number = GetNumber("Введите число:");
int result = GetPalimdroms(number);
if(result==1) Console.WriteLine($"число {number} является палиндромом");
else Console.WriteLine($"число {number} не является палиндромом");



 
