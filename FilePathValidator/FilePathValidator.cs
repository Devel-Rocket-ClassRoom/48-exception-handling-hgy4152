using System;
using System.Collections.Generic;
using System.Text;


class FilePathValidator
{
    public void ValidatePath(string path)
    {
        if (string.IsNullOrEmpty(path))
        {
            string comment = "경로는 null이거나 비어있을 수 없습니다.";
            throw new ArgumentNullException(null, comment);
        }
        else if (path.Length > 260)
        {
            throw new ArgumentOutOfRangeException(null, "경로 길이가 260자를 초과합니다.");

        }

        foreach (var s in path)
        {
            if(s == '<' || s == '>' || s == '|' || s == '"' || s == '*' || s == '?' )
            {
                throw new ArgumentException($"경로에 금지 문자 '{s}'가 포함되어 있습니다."); // 얜 파라미터이름이 뒤, 하위애들은 앞
            }
        }


        Console.WriteLine("경로가 유효합니다.");
        
    }

    public void ValidateExtension(string path, string[] allowedExtensions)
    {
        path = path.Split(".")[1];

        if (Array.IndexOf(allowedExtensions, path) >= 0)
            Console.WriteLine($"확장자가 유효합니다: .{path}");
        else
            throw new ArgumentException($"허용되지 않은 확장자입니다: .{path}");
    }
}