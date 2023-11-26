using System.Text.RegularExpressions;

class Programm{

  static void  Main(){
     Console.WriteLine("enter number");
     int number = Convert.ToInt32(Console.ReadLine());
      if(number % 7 ==0 && number % 23 == 0){
         Console.WriteLine($"Число {number} кратно числу 7 и числу 23");
        }
      else{
          Console.WriteLine($"Число {number} не кратно числу 7 и числу 23");
      }  
  }
 
 
}

