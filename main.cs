using System;

class Program {
  public static void Main (string[] args) {

    //the ratio of inches to centimeters
    //multiply inches by inToCm to convert
    const double inToCm = 2.54;

    //values in inches
    var in1 = 5;
    var in2 = 50;
    var in3 = -15;
    var in4 = 15994;

    //prints the number of inches converted to centimeters
    Console.WriteLine("{0} inches is {1} centimeters", in1, in1 * inToCm);
    Console.WriteLine("{0} inches is {1} centimeters", in2, in2 * inToCm);
    Console.WriteLine("{0} inches is {1} centimeters", in3, in3 * inToCm);
    Console.WriteLine("{0} inches is {1} centimeters", in4, in4 * inToCm);
  }
}