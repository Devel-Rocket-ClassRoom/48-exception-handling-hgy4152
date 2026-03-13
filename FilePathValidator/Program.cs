using System;

// README.md를 읽고 아래에 코드를 작성하세요.


FilePathValidator file = new FilePathValidator();

Console.WriteLine("=== 경로 검증 테스트 ===");

string path1 = "C:/Users/data/report.txt";
string path2 = null;
string path3 = "<C:/Users/data/report.exe";
string path4 = "C:/Users/data/report.exeC:/Users/data/report.exeC:/Users/data/report.exeC:/Users/data/report.exeC:/Users/data/report.exeC:/Users/data/report.exeC:/Users/data/report.exeC:/Users/data/report.exeC:/Users/data/report.exeC:/Users/data/report.exeC:/Users/data/report.exeC:/Users/data/report.exe";

string[] extension = { "txt", "csv" };

ValidPath(path1);
ValidPath(path2);
ValidPath(path3);
ValidPath(path4);

void ValidPath(string path)
{

    try
    {
        file.ValidatePath(path);
    }
    catch (ArgumentNullException e)
    {
        Console.WriteLine($"[{e.GetType().Name} 오류] {e.Message}");

    }
    catch (ArgumentOutOfRangeException e)
    {
        Console.WriteLine($"[{e.GetType().Name} 오류] {e.Message}");

    }
    catch (ArgumentException e)
    {
        Console.WriteLine($"[{e.GetType().Name} 오류] {e.Message}");

    }
}


Console.WriteLine("=== 확장자 검증 테스트 ===");
path1 = "C:/Users/data/report.txt";
path2 = "C:/Users/data/report.csv";
path3 = "C:/Users/data/report.exe";

ValidExtension(path1, extension);
ValidExtension(path2, extension);
ValidExtension(path3, extension);


void ValidExtension(string path, string[] extension)
{
    try
    {
        file.ValidateExtension(path, extension);
    }
    catch (ArgumentException e)
    {
        Console.WriteLine($"[{e.GetType().Name} 오류] {e.Message}");

    }
}