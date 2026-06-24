using System;

class Program
{
    static void Main()
    {
        Console.Write("계산기 프로그램입니다. \n");
        Console.Write("첫 번째 숫자를 입력하세요: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("연산자를 입력하세요 (+, -, *, /): ");
        char op = Convert.ToChar(Console.ReadLine());

        Console.Write("두 번째 숫자를 입력하세요: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;
        switch (op)
        {
            case '+': result = num1 + num2; break;
            case '-': result = num1 - num2; break;
            case '*': result = num1 * num2; break;
            case '/': result = num2 != 0 ? num1 / num2 : 0; break;
            default: Console.WriteLine("잘못된 연산자입니다."); return;
        }

        Console.WriteLine("계산 결과: " + result);
    }
}
