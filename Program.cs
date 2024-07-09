using CalculatorLib;

class Program
{
	static void Main()
	{
		do
		{
		Calculator calculator = new Calculator();
		// int result = calculator.Divided(6, 3);
		// // Console.WriteLine(result);
		
		//Take input user from Terminal
		Console.WriteLine("Masukkan angka : ");
		string inputUser = Console.ReadLine();
		Console.WriteLine("Masukkan angka kedua : ");
		string inputUser2 = Console.ReadLine();
		
		//Convert string to int using Parse
		int inputUserInt = int.Parse(inputUser);
		int inputUserInt2 = int.Parse(inputUser2);
		
		//Call calculator method
		int result = calculator.Min(inputUserInt, inputUserInt2);
		Console.WriteLine("Hasil = "+result);
		
		//while input user
		Console.WriteLine("Apakah anda ingin menghitung lagi? y/n");
		}
		while(Console.ReadLine() == "y");

		}
		
		
		
	}

