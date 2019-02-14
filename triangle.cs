using System;
using System.Collections.Generic;

class Triangle {
public int SideOne;
public int SideTwo;
public int SideThree;

public Triangle(int sideOne, int sideTwo, int sideThree){
SideOne=sideOne;
SideTwo=sideTwo;
SideThree=sideThree;
}
public string Calculate(){
if(SideOne + SideTwo < SideThree||SideTwo+SideThree<SideOne||SideOne+SideThree<SideTwo){
  return "Not a Triangle Nerd!";
}else if ((SideOne==SideTwo)&&(SideTwo==SideThree)) {
  return "This is a Equilateral Triangle Nerd!";
}else if (SideOne==SideTwo||SideOne==SideThree||SideTwo==SideThree) {
  return "This is a Isosceles Triangle Nerd!";
}else{
  return "This is a Scalene Triangle Nerd";
}

}

}

class Program{
  public static void Main(){

Console.WriteLine("Please enter a number!");
int inputOne=int.Parse(Console.ReadLine());
Console.WriteLine("Please enter a number!");
int inputTwo =int.Parse(Console.ReadLine());
Console.WriteLine("Please enter a number!");
int inputThree=int.Parse(Console.ReadLine());
    Triangle triangle1= new Triangle(inputOne, inputTwo, inputThree);
Console.WriteLine(triangle1.Calculate());
  }
}
