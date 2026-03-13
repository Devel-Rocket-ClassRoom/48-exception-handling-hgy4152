using System;
using System.Collections.Generic;
using System.Text;

class SafeCalculator
{
    
    public int Divide(string num1, string num2)
    {
        int result = 0;
        try
        {
            int d1 = int.Parse(num1);
            int d2 = int.Parse(num2);

            result = d1 / d2;
            Console.WriteLine($"{d1} / {d2} = {result}");
        }
        catch(FormatException e)
        {
            Console.WriteLine("올바른 숫자를 입력하세요");
        }
        catch(DivideByZeroException e) 
        {
            Console.WriteLine("0으로 나눌 수 없습니다.");
        }
        finally
        {
            Console.WriteLine("계산기를 종료합니다");
        }

        return result;
    }
}