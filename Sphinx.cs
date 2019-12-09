using System;
using System.Collections.Generic;

class Clock
{


  static void Main()
{
  Console.WriteLine("What hour is it?");
  int hour = int.Parse(Console.ReadLine());

  Console.WriteLine("What minute is it?");
  int minute = int.Parse(Console.ReadLine());

  int resultHour = hour * 30;
  int resultMinute = minute * 6;
  int result = resultHour - resultMinute;

  if(result > 180)
  {
    result = 360 - result;
  }
  Console.WriteLine("The degree between the two hands is " + result );

}
  
}