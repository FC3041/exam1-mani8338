using System.ComponentModel;
using static System.Math;

namespace Exam1;

public class Q1_Add
{
    public int x;
    public int y;

    public static int Add(int x,int y)
    {
        return x+y;
    }

    public static void Q2_MultiplyAndReset(ref int v,ref int f)
    {
        v = v * f; 
        f = 1; 
    }
}

public class Basics
{
    public int v;
    public int f;
    public static void Q2MultiplyAndReset(ref int v,ref int f)
    {
        v = v * f;
        f = 1;
    }


}

public struct Type1
{
    public int Count;
}
public class Type2
{
    public int Count;
}
 
public class Q3_Increment_AllCases
{
    public Type2 v;
    public Type1 f;
}

public class Q4Person
{
    public string Name;
    public int Age;

    public Q4Person(string name,int age)
    {
        this.Name = name; this.Age = age;
    }

    public string Introduce() => $"Hello, my name is {this.Name} and I am {this.Age} years old.";
}

public class Q6Temperature
{
    public static double t;
    public static double s;
    public double Celsius {get; set;}
    public double Fahrenheit {get;set;} = 1.8*t+32;

}

public interface IShape
{
    double GetArea() => 0;
    double GetPerimeter() => 0;
    
}

public class Q7Circle: IShape
{
    public double r;
    public Q7Circle(double r){this.r = r;}
    public double GetArea() => r*r*Math.PI;
    public double GetPerimeter() => 2*r*Math.PI;
}

public class Q7Rectangle: IShape
{
    public double l;
    public double w;
    public Q7Rectangle(double l,double w){this.l = l; this.w = w;}

    public double GetArea() => l*w;
    public double GetPerimeter() => 2*(l+w);
}

public class ShapeUtils
{
    public static double Q7TotalArea(IShape[] shapes)
    {
        double sum = 0;
        foreach(IShape s in shapes){
            sum += s.GetArea();
        }
        return sum;
    }
}
