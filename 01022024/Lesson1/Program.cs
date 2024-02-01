
using System.Reflection;

int[] numbers = { 10, 20, 30, -5, -33, 11, 45, 67,0,-10,44 };



Console.WriteLine(SumEven(numbers));
Console.WriteLine(SumOdd(numbers));
Console.WriteLine(SumPositive(numbers));
Console.WriteLine(Sum(numbers, IsEven));
Console.WriteLine(Sum(numbers, IsOdd));
Console.WriteLine(Sum(numbers,delegate(int n) { return n % 2 == 0; }));
Console.WriteLine(Sum(numbers, x=>x%2==0));
Console.WriteLine(SumCalc(numbers,Add));

CheckNumber method1 = IsEven;
CheckNumber method2 = IsOdd;




Console.WriteLine(method1(45));
Console.WriteLine(method2(45));
Console.WriteLine(method1.Invoke(45));

Calc calculation = Add;
calculation += Multiply;

calculation.Invoke(10, 20);

foreach (var item in calculation.GetInvocationList())
{
    Console.WriteLine(item.DynamicInvoke(10, 20));
}

CheckNumber method3 = delegate (int num)
{
    return num > 0;
};

Console.WriteLine(method3.Invoke(45));

Calc powSum = delegate (int x, int y)
{
    return x * x + y * y;
};

powSum = (x, y) => x * x + y * y;

Console.WriteLine(powSum(2,4));

CheckNumber method4 = (x) => { return x % 2 == 0; };
method4 = (x) => x % 2 == 0;

Print print1 = (x) => Console.WriteLine(x*x);


Func<string> func1 = GetValue;
Func<int, bool> func2 = IsEven;
func2 = x => x % 10 == 0;
Func<int, int, int> func3 = Add;

Action<int> numPrint = (x) => Console.WriteLine(x);
Action<int, int, int, int, int> sumPrint = (n1, n2, n3, n4, n5) => Console.WriteLine(n1+n2+n3+n4+n5);

Predicate<int> predicate1 = IsEven;
Predicate<string> nullChecker = (str) => str == null;


int SumEven(int[] arr)
{
    int total = 0;
	foreach (var num in arr)
	{
		if (IsEven(num))
		{
            total += num;
        }
    }

	return total;
}

int SumOdd(int[] arr)
{
    int total = 0;
    foreach (var num in arr)
    {
        if (IsOdd(num))
        {
            total += num;
        }
    }

    return total;
}

int SumPositive(int[] arr)
{
    int total = 0;
    foreach (var num in arr)
    {
        if (num > 0)
        {
            total += num;
        }
    }

    return total;
}

bool IsEven(int n)
{
    return n % 2 == 0;
}

bool IsOdd(int n)
{
    return n % 2 == 1;
}


int Sum(int[] arr, Func<int,bool> checker)
{
    int total = 0;
    foreach (var num in arr)
    {
        if (checker(num))
        {
            total += num;
        }
        
    }
    return total;
}


int SumCalc(int[] arr,Calc calc)
{
    int total = 0;
    foreach (var num in arr) 
    {
        total += calc(num, num);
    }

    return total;
}

int Add(int num1,int num2)
{
    Console.WriteLine("Add is called");
    return num1 + num2;
}

int Subtract(int num1,int num2)
{
    Console.WriteLine("Subtract is called");
    return num1 - num2;
}

int Multiply(int num1,int num2)
{
    Console.WriteLine("Multiply is called");
    return num1 * num2;
}

string GetValue()
{
    var value = Console.ReadLine();
    return value;
}

public delegate bool CheckNumber(int number);
public delegate int Calc(int x, int y);
public delegate void Print(int n);



