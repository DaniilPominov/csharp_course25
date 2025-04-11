using System.ComponentModel;
using System.Numerics;

namespace EvaEnjoynersGalaxyDestroyer;

public class Destroyer
{

    public static double Add(double a, double b) => a + b;
    
    public static int Add(int a, int b) => a + b;
    
    public static string Add(string a, string b)
    {
        if (double.TryParse(a, out var numA) && double.TryParse(b, out var numB))
            return (numA + numB).ToString();
        throw new ArgumentException("Strings must contain valid numbers");
    }

    public static double Subtract(double a, double b) => a - b;
    
    public static int Subtract(int a, int b) => a - b;
    
    public static string Subtract(string a, string b)
    {
        if (double.TryParse(a, out var numA) && double.TryParse(b, out var numB))
            return (numA - numB).ToString();
        throw new ArgumentException("Strings must contain valid numbers");
    }


    public static double Multiply(double a, double b) => a * b;
    
    public static int Multiply(int a, int b) => a * b;
    
    public static string Multiply(string a, string b)
    {
        if (double.TryParse(a, out var numA) && double.TryParse(b, out var numB))
            return (numA * numB).ToString();
        throw new ArgumentException("Strings must contain valid numbers");
    }

    public static double Divide(double a, double b)
    {
        if (b == 0) throw new DivideByZeroException("Division by zero is not allowed");
        return a / b;
    }
    
    public static int Divide(int a, int b)
    {
        if (b == 0) throw new DivideByZeroException("Division by zero is not allowed");
        return a / b;
    }
    
    public static string Divide(string a, string b)
    {
        if (double.TryParse(a, out var numA) && double.TryParse(b, out var numB))
        {
            if (numB == 0) throw new DivideByZeroException("Division by zero is not allowed");
            return (numA / numB).ToString();
        }
        throw new ArgumentException("Strings must contain valid numbers");
    }

    public static double Power(double a, double b)
    {
        if (a == 0 && b < 0) throw new DivideByZeroException("Zero cannot be raised to a negative power");
        
        double result = 1;
        bool negativeExponent = b < 0;
        int iterations = (int)Math.Abs(b);
        double remaining = Math.Abs(b) - iterations;
        
        for (int i = 0; i < iterations; i++)
        {
            result *= a;
        }
        
        if (remaining > 0)
        {
            //ln(a^n) = n*ln(a)
            // Using an exponent Taylor series approximation for a^remaining
            double x = remaining * Math.Log(a);
            double approx = 1 + x + (x * x) / 2 + (x * x * x) / 6;
            result *= approx;
        }
        
        return negativeExponent ? 1 / result : result;
    }
    
    public static int Power(int a, int b)
    {
        if (b < 0) throw new DivideByZeroException("Integer power doesn't support negative exponents");
        
        int result = 1;
        for (int i = 0; i < b; i++)
        {
            result *= a;
        }
        return result;
    }
    public static string Power(string a, string b)
    {
        if (double.TryParse(a, out var numA) && double.TryParse(b, out var numB))
            return Power(numA, numB).ToString();
        throw new ArgumentException("Strings must contain valid numbers");
    }

    public static double SquareRoot(double a)
    {
        if (a < 0) throw new ArgumentException("Square root of negative number is not defined");
        if (a == 0) return 0;
        
        // Babylonian method (Heron's method)
        double epsilon = 0.000001;
        double guess = a / 2.0;
        
        while (Math.Abs(guess * guess - a) > epsilon)
        {
            guess = (guess + a / guess) / 2.0;
        }
        
        return guess;
    }
    
    public static int SquareRoot(int a)
    {
        if (a < 0) throw new ArgumentException("Square root of negative number is not defined");
        if (a == 0) return 0;
        
        //binary search
        int left = 1, right = a, result = 0;
        
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            
            if (mid <= a / mid)
            {
                left = mid + 1;
                result = mid;
            }
            else
            {
                right = mid - 1;
            }
        }
        
        return result;
    }
    
    public static string SquareRoot(string a)
    {
        if (double.TryParse(a, out var num))
            return SquareRoot(num).ToString();
        throw new ArgumentException("String must contain a valid number");
    }
    
}

