

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesAndTypeCasting
{
    public enum week
    {
        Monday=1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("DATA TYPE ASSIGNMENT \n");
            Console.WriteLine("Task 1 : Declare and initialize variables using the following data types & Print their values to the console. int, float, double, decimal string, bool");
            int inttype = 10;
            float floattype = 10.0F;
            double doubletype = 50.02D;
            decimal decimaltype = 45.2M;
            string stringtype = "Maitri";
            bool booltype=true;
            Console.WriteLine("Sol:");
            Console.WriteLine($"int: {inttype}, float: {floattype}, double: {doubletype}, decimal: {decimaltype}, string: {stringtype}, bool: {booltype}\n");

            Console.WriteLine("Task 2 : Print minimum, maximum and default values for various datatypes.");

            Console.WriteLine("Sol:");
            Console.WriteLine("Minimum , maximum and default values of datatypes are");
       

            Console.WriteLine($"int: Min = {int.MinValue}, Max = {int.MaxValue}, Default = {default(int)}");
            Console.WriteLine($"float: Min = {float.MinValue}, Max = {float.MaxValue}, Default = {default(float)}");
            Console.WriteLine($"double: Min = {double.MinValue}, Max = {double.MaxValue}, Default = {default(double)}");
            Console.WriteLine($"decimal: Min = {decimal.MinValue}, Max = {decimal.MaxValue}, Default = {default(decimal)}");
            Console.WriteLine($"bool: Default = {default(bool)}");
            Console.WriteLine($"string: Default = {(default(string) == null ? "null" : default(string))}\n");

            Console.WriteLine("Task 3 : Difference between default values if the datatypes are made nullable.");
            int? nullableInttype =default;
            float? nullableFloattype=default ;
            double? nullableDoubletype = default ;
            decimal? nullableDecimaltype=default;
            string nullableStringtype = default;
            bool? nullableBooltype =default;
            Console.WriteLine("Sol:");
            Console.WriteLine($"Default value of nullable int: {(nullableInttype == null ? "null" : nullableInttype.ToString())}");
            Console.WriteLine($"Default value of nullable float: {(nullableFloattype == null ? "null" : nullableFloattype.ToString())}");
            Console.WriteLine($"Default value of nullable double: {(nullableDoubletype == null ? "null" : nullableDoubletype.ToString())}");
            Console.WriteLine($"Default value of nullable decimal: {(nullableDecimaltype == null ? "null" : nullableDecimaltype.ToString())}");
            Console.WriteLine($"Default value of nullable string: {(nullableStringtype == null ? "null" : nullableStringtype)}");
            Console.WriteLine($"Default value of nullable bool: {(nullableBooltype == null ? "null" : nullableBooltype.ToString())}");
            Console.WriteLine();
            Console.WriteLine("Task 4 : Write a program using enum to print the day of week in text, if input is provided as a number.Example : If input is 4, expected output is Thursday!");
            Console.WriteLine("Enter the number (1-7) corresponding to the day of week you want to print");
            int day=int.Parse(Console.ReadLine());
            foreach(var item in Enum.GetValues(typeof(week)))
            {
                if ((int)item == day)
                {
                    Console.WriteLine($"The day of week is {item}");
                }
            }

            Console.WriteLine();
            Console.WriteLine("TYPE CASTING ASSIGNMENT \n");

            Console.WriteLine("1. Convert an Integer to a Double:Declare an int variable and assign a value.Convert it to a double using implicit casting.Print both values.");
            int a =15;
            double b = a;
            Console.WriteLine($"Integer : {a}");
            Console.WriteLine($"Double : {b}");
            Console.WriteLine();

            Console.WriteLine("2. Convert a Character to an Integer (ASCII Value):Declare a char variable (e.g., 'A').Convert it to an int to get its ASCII value.Print the result.");
            char charVar = 'A';
            int intVar = charVar;
            Console.WriteLine($"Character : {charVar}");
            Console.WriteLine($"Integer : {intVar}");
            Console.WriteLine();

            Console.WriteLine("3. Convert a Double to an Integer:Declare a double variable with a decimal value.Explicitly cast it to an int.Print both values and observe the data loss.");
            double doubleVar = (double)15.75M;
            int integerVar = (int)doubleVar;
            Console.WriteLine($"Double : {doubleVar}");
            Console.WriteLine($"Integer : {integerVar}");
            Console.WriteLine();

            Console.WriteLine("4. Truncate a Float Value:Declare a float variable with a decimal value.Convert it to an int using explicit casting.Print both values and note the truncated decimal.");
            float floatVar = (float)375.26M;
            int integerVar1 = (int)floatVar;
            Console.WriteLine($"Float : {floatVar}");
            Console.WriteLine($"Integer : {integerVar1}");
            Console.WriteLine();

            Console.WriteLine("5. Convert a String to an Integer:Declare a string variable with a numeric value (e.g., \"100\").Convert it to an int using Convert.Print the result.");
            string s = "989";
            Console.WriteLine("Using Convert");
            Console.WriteLine($"{Convert.ToInt32(s)}");

            Console.WriteLine();


            Console.WriteLine("6. Convert a Boolean to an Integer:Declare a bool variable (true or false).Convert it to an int using Convert.Print the result (true => 1, false => 0).");
            bool boolVar = false;
            int integerVar2 = Convert.ToInt32(boolVar);
            Console.WriteLine($"Bool : {boolVar}");
            Console.WriteLine($"Integer : {integerVar2}");
            Console.WriteLine();

            Console.WriteLine("7. Convert a String to an Integer using Parse():Declare a string with a numeric value.Convert it to an int using int.Parse().Print the result.");
            string s1 = "561";
            Console.WriteLine("Using Parse");
            Console.WriteLine($"{int.Parse(s1)}");
            Console.WriteLine();

            Console.WriteLine("8.Handle Non-Numeric String using TryParse():\r\nDeclare a string variable with a non-numeric value (e.g., \"ABC\").\r\nTry to convert it to an int using int.TryParse().\r\nPrint whether the conversion was successful.\r\n");
            string s2= "abc";

            if (int.TryParse(s2, out int i))
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine($"Conversion Unsuccesful as you entered {s2}");
            }

            Console.WriteLine("9. User Input Conversion:Read a number from the console as a string.Convert it to double using Convert.ToDouble().Multiply the number by 10 and print the result.");
            double doubleans=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Result is {doubleans*10}") ;
            Console.WriteLine();


            Console.WriteLine("10. Temperature Converter (Celsius to Fahrenheit):Take a user input in string format for temperature in Celsius.Convert it to double and apply the formula.Display the converted temperature in Fahrenheit.");
            Console.WriteLine("Enter temperature in celsius") ;
            double cel = Convert.ToDouble(Console.ReadLine());
            double far = (cel * 1.8 + 32);
            Console.WriteLine($"Temperature in Fahrenheit is {far}");
            Console.WriteLine();

        }
    }
}
