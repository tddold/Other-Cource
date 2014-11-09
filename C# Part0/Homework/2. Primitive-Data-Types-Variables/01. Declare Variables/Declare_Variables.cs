// Problem 1.	Declare Variables
// Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000. Choose a large        enough type for each number to ensure it will fit in it. Try to compile the code. Submit the source code of     your Visual Studio project as part of your homework submission.


using System;

class Declare_Variables
{
    static void Main()
    {
        byte byteVar = 97;
        sbyte sbyteVar = -115;
        short shortVar = -1000;
        ushort ushortVar = 5213;
        uint uintVar = 4825932;
         
        Console.WriteLine("The type number is:");
        Console.WriteLine(byteVar + "  -> " + byteVar.GetTypeCode());
        Console.WriteLine(sbyteVar + " -> " + sbyteVar.GetTypeCode());
        Console.WriteLine(shortVar + " -> " + shortVar.GetTypeCode());
        Console.WriteLine(ushortVar + " -> " + ushortVar.GetTypeCode());
        Console.WriteLine(uintVar + " -> " + uintVar.GetTypeCode());
    }
}