#region Problem 1
using System;
using System.Drawing;
using System.Text;

string x = null;
try
{
    int x2 = int.Parse(x);
}
catch
{
    int x3 = Convert.ToInt32(x);
}
// 'int.parse'  can not make null to integer but 'convert' accept that so that we use try catch to handling null inputs
#endregion

#region Problem 2
string f = Console.ReadLine();
if (int.TryParse(f,out int num))
{
    Console.WriteLine($"num is valid integer = {num}");
}
else
{
    Console.WriteLine(" Error ");
}
// 1. Graceful Error Handling
//  Parse: Throws an exception if the input is invalid (e.g., FormatException for non-numeric strings).
//  TryParse: Returns a boolean value (true or false) indicating success or failure, allowing the application to handle invalid input more gracefully without crashing.
#endregion

#region Problem 3
object obj;
 obj = 45;
Console.WriteLine($"Hash code => {obj.GetHashCode} ");
 obj = "hatem";
Console.WriteLine($"Hash code => {obj.GetHashCode} ");
 obj = true ;
Console.WriteLine($"Hash code => {obj.GetHashCode} ");
#endregion

#region Problem 4
/*class Point
{
    public int X { get; set; }
    public int Y { get; set; }
}*/

Point p1 = new Point(4, 5);
Point p2 = p1;
p1.X = 50;
Console.WriteLine(p2);
// P2.X WILL CHANGE WHEN WE CHANGE P1.X BECUASE BOTH REFERENCE TO THE SAME OBJECT
#endregion

#region Problem 5
string Text= "Hi Willy";
Console.WriteLine(Text.GetHashCode());
   Text= "Hi Mr /Willy";
Console.WriteLine(Text.GetHashCode());
//Why string is immutable in C# ? to be ,ore securety and effecient and esy to use
#endregion

#region Problem 6
StringBuilder message1;
message1 = new StringBuilder("Hi Willy");
Console.WriteLine(message1.GetHashCode());
message1 = new StringBuilder("Hi Mr /Willy");
Console.WriteLine(message1.GetHashCode());
/*StringBuilder is faster and more efficient than string when performing frequent or large-scale string modifications because it allows changes within the same object, reduces memory usage, and minimizes garbage collection overhead. */
#endregion

#region Problem 7
int input1 = int.Parse(Console.ReadLine());
int input2 = int.Parse(Console.ReadLine());
Console.WriteLine("sum = " +input1 +"+" +input2+" = "+input2+input1 );
Console.WriteLine($"sum = input1 + input2 = {input1 + input2}");
// String interpolation =>  Readability , Performance and Less Error-Prone


#endregion

#region Problem 8
StringBuilder message;
message = new StringBuilder("hi");
message.Append(" fady ");
Console.WriteLine(message); // hi fady
message.Insert(3, "mr/"); 
Console.WriteLine(message); // hi mr/fady
message.Remove(3, 3);
Console.WriteLine(message); // hi fady
// in StringBuilder you can edit the text without make a new abject but string can not do this
#endregion
