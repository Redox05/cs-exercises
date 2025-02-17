// See https://aka.ms/new-console-template for more information

// The code below outputs the number of bytes in memory that different types use and the minimum 
// and maximum values they can have.

// It was needed to enable unsafe code to use "sizeof" method for Int128, UInt128, and Half.

WriteLine("--------------------------------------------------------------------------------------------------------------");
WriteLine("{0,-10} {1,6} {2,32} {3,48}","Type", "Byte(s) of memory", "Min","Max") ;
WriteLine("--------------------------------------------------------------------------------------------------------------");
WriteLine("{0,-10} {1,0} {2,48} {3,48}", "sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
WriteLine("{0,-10} {1,0} {2,48} {3,48}", "byte", sizeof(byte), byte.MinValue, byte.MaxValue);
WriteLine("{0,-10} {1,0} {2,48} {3,48}", "short", sizeof(short), short.MinValue, short.MaxValue);
WriteLine("{0,-10} {1,0} {2,48} {3,48}", "ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
WriteLine("{0,-10} {1,0} {2,48} {3,48}", "int", sizeof(int), int.MinValue, int.MaxValue);
WriteLine("{0,-10} {1,0} {2,48} {3,48}", "uint", sizeof(uint), uint.MinValue, uint.MaxValue);
WriteLine("{0,-10} {1,0} {2,48} {3,48}", "long", sizeof(long), long.MinValue, long.MaxValue);
WriteLine("{0,-10} {1,0} {2,48} {3,48}", "ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
unsafe
{
    WriteLine("{0,-10} {1,0} {2,47} {3,48}", "Int128", sizeof(Int128), Int128.MinValue, Int128.MaxValue);
    WriteLine("{0,-10} {1,0} {2,47} {3,48}", "UInt128", sizeof(UInt128), UInt128.MinValue, UInt128.MaxValue);
    WriteLine("{0,-10} {1,0} {2,48} {3,48}", "Half", sizeof(Half), Half.MinValue, Half.MaxValue);
}
WriteLine("{0,-10} {1,0} {2,48} {3,48}", "float",sizeof(float), float.MinValue, float.MaxValue);
WriteLine("{0,-10} {1,0} {2,48} {3,48}", "double", sizeof(double), double.MinValue, double.MaxValue);
WriteLine("{0,-10} {1,0} {2,47} {3,48}", "decimal",sizeof(decimal), decimal.MinValue, decimal.MaxValue);
