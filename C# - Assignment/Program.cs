namespace C____Assignment
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Q1: Enter a number

			/*
			1-	Write a program that allows the user to enter a number then print it.
			*/
			//Console.Write("Enter a number: ");
			//int number = int.Parse(Console.ReadLine());
			//Console.WriteLine("You entered: " + number);
			#endregion

			#region Q2: Assign one value type variable to another
			/*
			2-	Write C# program that Assigning one value type variable to another and
				modifying the value of one variable and mention what will happen
			*/
			/*
			int firstNumber = 10;
			int secondNumber = firstNumber;
			Console.WriteLine(secondNumber);
			firstNumber = 20;
			Console.WriteLine(firstNumber);
			Console.WriteLine(secondNumber);
			*/
			// secondNumber value is still 10 not 20

			#endregion

			#region Q3
			/*
			 * Write C# program that Assigning one reference type variable to another
			 * and modifying the object through one variable  and mention what will happen
			*/
			// Step 1: Create an array (reference type)
			int[] array1 = { 1, 2, 3 };
			Console.WriteLine("Initial values of array1: " + string.Join(", ", array1));

			// Step 2: Assign the reference of 'array1' to 'array2'
			int[] array2 = array1;
			Console.WriteLine("Values of array2 after assignment: " + string.Join(", ", array2));

			// Step 3: Modify the array through 'array1'
			array1[0] = 99;
			Console.WriteLine("Values of array1 after modification: " + string.Join(", ", array1));

			// Step 4: Display the values of 'array2' to see if it reflects the change
			Console.WriteLine("Values of array2 after modifying array1: " + string.Join(", ", array2));

			Console.ReadLine();

			#endregion


		}
	}
}
