using System;

class MainClass {
  public static void Main (string[] args) {
 
 double speed;
 double totalSpeed = 0;

 for(int counter=1; counter<=7; counter++)
 {
   Console.WriteLine("Enter the distance covered by Car#" + counter);
   double dist = Convert.ToDouble(Console.ReadLine());
   Console.WriteLine("Enter the time taken by Car#" + counter);
   double time = Convert.ToDouble(Console.ReadLine());
   speed = dist/time;
   Console.WriteLine("The speed of this car is " + speed + " mph ");
   totalSpeed += speed;
  }
  Console.WriteLine("The average speed of the cars is " + totalSpeed/7 + " mph ");
  
  }
}