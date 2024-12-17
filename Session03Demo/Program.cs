namespace Session03Demo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region ValueTypeCasting
			#region ImplicitCasting


			int x = 4;
			long y = x;


			#region ExplicitCasting

			#endregion


			#endregion
			#endregion

			#region SwitchCase
			/*
			Console.WriteLine("Enter age: ");
			int Age = int.Parse(Console.ReadLine());

			switch (Age)
			{
				case > 22:
					Console.WriteLine("Age greater than 22");
					break;

				case < 22:
					Console.WriteLine("Age is less than 22");
					break;

				default:
					Console.WriteLine("Age is 22");
					break;
			}
			*/
			#endregion


			#region C# 07
			/*
			object obj = new object();
			obj = "Mohamed";
			obj = 10;
			//obj = true;

			switch(obj)
			{
				case int Number when Number > 10 && Number < 20:
					Console.WriteLine($"{Number} is int");
					break;

				case string Name:
					Console.WriteLine($"{Name} is string");
					break;


				case bool Flag:
					Console.WriteLine($"{Flag} is bool");
					break;

			}

			*/
			#endregion


			#region C# Switch 08
			/*
			Console.WriteLine("Enter option");
			int option = int.Parse(Console.ReadLine());

			string Message = option switch
			{
				1 => "Option 01",
				2 => "Option 02",
				3 => "Option 3",
				_ => "Invalid"
			};

			Console.WriteLine(Message);
			*/
			#endregion

			#region ObjectsAndSwitchCases
			/*
			Employee E01 = new Employee();
			E01.Name = "Ali";
			E01.Id = 10;
			E01.Age = 22;

			string Message = E01 switch
			{
				{ Id: 10, Name: "Alaa", Age: 22 or 23 } => $"{E01.Id} : {E01.Name} : {E01.Age}",
				{ Id: 10, Name: "Ali", Age: 22 } => $"{E01.Id} : {E01.Name} : {E01.Age}",
				{ Id: 20, Name: "Alaa", Age: 22 } => $"{E01.Id} : {E01.Name} : {E01.Age}",
			};

			Console.WriteLine(Message);
			*/
			#endregion
			/*
			Console.WriteLine("Enter a number!:");
			int option = int.Parse(Console.ReadLine());
			switch (option)
			{
				case 3000:
					Console.WriteLine("Option 1");
					Console.WriteLine("Option 2");
					goto case 5000;
				

				case 2000:
					Console.WriteLine("Option 3");
					goto case 3000;

				case 5000:
					Console.WriteLine("Option 5");
				break ;
			}
			*/

			Console.WriteLine("Enter a month number:");
			int monthNumber = int.Parse(Console.ReadLine());


			if (monthNumber == 1)
			{
				Console.WriteLine("Month is jan!");	
			}

			else if (monthNumber == 2)
			{
				Console.WriteLine("Month is feb!");
			}  

			else if (monthNumber == 3)
			{
				Console.WriteLine("Month is mar!");
			}

			else
			{
				Console.WriteLine("Invalid input");
			}
		}
		}
	}

