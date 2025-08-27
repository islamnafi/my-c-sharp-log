namespace data_types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Data Types!");
        }
    }
}

/*

+---------------+---------------------------------------------------+--------------------------------+--------------------------------------------+
| Data Type     | Why It Exists                                     | Range                          | Casting                                    |
+---------------+---------------------------------------------------+--------------------------------+--------------------------------------------+
| byte          | For small, unsigned integers (memory efficiency)  | 0 to 255                       | (byte) otherType                           |
| sbyte         | Small signed integers                             | -128 to 127                    | (sbyte) otherType                          |
| short         | Signed small integers                             | -32,768 to 32,767              | (short) otherType                          |
| ushort        | Unsigned small integers                           | 0 to 65,535                    | (ushort) otherType                         |
| int           | Default integer type for general-purpose numbers  | -2,147,483,648 to              | (int) otherType                            |
|               |                                                   |  2,147,483,647                 |                                            |
| uint          | Unsigned 32-bit integers                          | 0 to 4,294,967,295             | (uint) otherType                           |
| long          | Large signed integers                             | -9,223,372,036,854,775,808     | (long) otherType                           |
|               |                                                   | to 9,223,372,036,854,775,807   |                                            |
| ulong         | Large unsigned integers                           | 0 to 18,446,744,073,709,551,615| (ulong) otherType                          |
| float         | Single-precision floating point (fast, less mem.) | ±1.5e−45 to ±3.4e38            | (float) otherType, Convert.ToSingle()      |
| double        | Default floating point (precision)                | ±5.0e−324 to ±1.7e308          | (double) otherType, Convert.ToDouble()     |
| decimal       | High-precision decimals (e.g. money)              | ±1.0e−28 to ±7.9e28            | (decimal) otherType, Convert.ToDecimal()   |
| char          | Represents a single Unicode character             | U+0000 to U+FFFF               | (char) otherType, Convert.ToChar()         |
| string        | Sequence of characters (text)                     | Depends on memory              | Convert.ToString(), or .ToString() method  |
| bool          | True/False logical values                         | true or false                  | (bool) expressions, Convert.ToBoolean()    |
| object        | Base type of all types                            | Any data type                  | Requires casting to actual type            |
| var           | Implicitly typed local variable                   | Inferred at compile-time       | Not directly cast; depends on actual type  |
| dynamic       | Runtime-resolved type                             | Any data type                  | Cast at runtime; compiler does not check   |
+---------------+---------------------------------------------------+---------------------------+-------------------------------------------------+

+-----------------------------------------------------------------------------------------------------------+
| Type          | Example       | Default Type Without Suffix | Why Suffix Needed?                          |
+---------------+---------------+-----------------------------+---------------------------------------------+
| int           | 100           | int                         | Default for whole numbers                   |
| uint (U/u)    | 100u          | uint                        | To specify unsigned int                     |
| long (L/l)    | 100L          | long                        | To specify 64-bit signed integer            |
| ulong (UL)    | 100UL         | ulong                       | To specify 64-bit unsigned integer          |
| float (F/f)   | 3.14f         | double                      | Float needs suffix because decimal literals |
|               |               |                             | default to double in C#                     |
| double        | 3.14          | double                      | Default for decimals, no suffix needed      |
| decimal (M/m) | 3.14m         | decimal                     | Needed because default is double            |
+---------------+---------------+-----------------------------+---------------------------------------------+
 
*/