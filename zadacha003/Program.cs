using System;

class Programm{
    static void Main(){
     Console.WriteLine("Введите число из отрезка [10;23]:");
     int number = Convert.ToInt32(Console.ReadLine());


     int a = number / 10;
     int b = number % 10;
     int max = a;
    
     if (max < b){
     max = b;
     }
     else{
        max = a;
     }
        Console.WriteLine(max);
    }

    

}