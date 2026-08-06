using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllPrograms.Programs.String
{
	internal class StringExamples
	{
		public void EscapeSequenceExamples()
			{
				Console.WriteLine("========== CHARACTER ESCAPE SEQUENCES ==========\n");

				// --------------------------------------------------
				// \n - New Line
				// --------------------------------------------------
				Console.WriteLine("Hello\nWorld");
				Console.WriteLine("\n------------------------------------------\n");

				// --------------------------------------------------
				// \t - Tab Inserts a horizontal tab space
				// --------------------------------------------------
				Console.WriteLine("Name\tAge");
				Console.WriteLine("John\t25");
				Console.WriteLine("\n------------------------------------------\n");

				// --------------------------------------------------
				// \" - Double Quote -  Prints double quotes inside a string
				// --------------------------------------------------
				Console.WriteLine("My name is \"Abhishek\"");
				Console.WriteLine("\n------------------------------------------\n");

				// --------------------------------------------------
				// \\ - Backslash  Prints a single backslash (\\)
				// --------------------------------------------------
				Console.WriteLine("C:\\Users\\Abhishek\\Desktop");
				Console.WriteLine("\n------------------------------------------\n");
			}
	
		public void VerbatimStringExamples()
			{
				Console.WriteLine("\n========== VERBATIM STRING ==========\n");
				//A verbatim string starts with @.. It treats backslashes (\\) as normal characters and allows multi-line strings
				string path = @"C:\Users\Abhishek\Desktop\Test\File.txt";
				Console.WriteLine(path);
				Console.WriteLine("\n------------------------------------------\n");

				Console.WriteLine("Example 2: Multi-line String");
				string message = @"Hello Students,
									Welcome to C# Programming.
									Today we are learning Verbatim Strings.";

				Console.WriteLine(message);
			}
	
		public void StringInterpolationExamples()
			{
				Console.WriteLine("\n========== STRING INTERPOLATION ==========\n");

				Console.WriteLine("Description:");
				Console.WriteLine("String Interpolation allows us to insert variables or expressions directly inside a string using $ and {}.\n");

				string name = "Abhishek";
				int age = 27;
				double salary = 55000.50;

				Console.WriteLine("Example 1:");
				Console.WriteLine($"Name : {name}");
				Console.WriteLine($"Age : {age}");
				Console.WriteLine($"Salary : ₹{salary}");

				Console.WriteLine("\n------------------------------------------\n");

				Console.WriteLine("Example 2: Expression Inside Interpolation");

				int a = 10;
				int b = 20;

				Console.WriteLine($"The sum of {a} and {b} is {a + b}");

				Console.WriteLine("\n------------------------------------------\n");
			}
	}
}
