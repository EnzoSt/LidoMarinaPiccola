using System;
using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
public class Class1
{
    public Class1()
    {
        foreach (var item in Converter)
        {
            Console.WriteLine(item);
            Console.WriteLine(item);
            Console.WriteLine(item);
            Console.WriteLine(item);

        }
    }
}


user