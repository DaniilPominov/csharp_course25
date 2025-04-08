using System;
using System.Dynamic;
using csharp_course.Exceptions;

namespace csharp_course;

public class math02
{
    //return a rectangle measure
    public  double begin31(double a, double b){
        if(a<0||b<0){
            throw new NegativeNumberException();
        }
        return a*b;

    }
    //return a rectangle perimeter
    public double begin32(double a, double b){
                if(a<0||b<0){
            throw new NegativeNumberException();
        }
        return 2*(a+b);
    }

}
