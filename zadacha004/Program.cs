using System;

class Programm{
    static void Main(){
        Console.Write("Введите натуральное число N ");
        int N = Convert.ToInt32(Console.ReadLine());

        if(N <0 ){
            Console.WriteLine(N);
        }
        else{
            while(N > 0){
                int count = N % 10;
                N /= 10;
                if(N > 0){
                    Console.Write(count + ",");
                }
                else{
                    Console.WriteLine(count);
                }
            }
        }
    }


}
