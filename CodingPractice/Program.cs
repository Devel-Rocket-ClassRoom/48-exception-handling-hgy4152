using System;
using System.Collections.Generic;

// README.md를 읽고 코드를 작성하세요.


try
{
    int[] ints = { 1, 2, };
    ints[100] = 1;
}
catch
{
    Console.WriteLine("에러가 발생했습니다.");
}

try
{
    int[] ints = { 1, 2, };
    ints[100] = 1;
}
catch(Exception ex)
{
    Console.WriteLine($"에외 발생: {ex}");
}

try
{
    int a = 3.14;
}
catch
{
    Console.WriteLine("에러가 발생했습니다.");
}

