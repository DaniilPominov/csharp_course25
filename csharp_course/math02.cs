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
    public (int,int) integer1(int number){
        int sum=0, product =1;
        int sub = number;
        while(sub!=0){
            sum+=sub%10;
            product*=sub%10;
            sub/=10;
        }
        return (sum,product);
    }
    public bool CompareTriple(int A, int B, int C){
        return A<B && B<C;
    }
    public double MinimalFromTriple(double A, double B, double C){

        var numbers = new List<double>(){A,B,C};

        return numbers.Min();
    }
    public int RootCount(double A, double B, double C){
        var D = Math.Pow(B,2)-4*A*C;
        if(D>0){
            return 2;
        }
        else if(D<0){
            return 0;
        }
        return 1;
    }

}
