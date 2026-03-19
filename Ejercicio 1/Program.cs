using System;

namespace Ejercicio_1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int edad;
			bool correcto;
			do
			{
				Console.Clear();
				Console.WriteLine("Ingrese una edad");
				correcto = int.TryParse(Console.ReadLine(), out edad);
				if (edad <1  || edad > 100)
				{
					correcto = false;
					Console.WriteLine("Edad Invalida, intentelo otra vez");
					Console.ReadKey();
				}

			} while (correcto==false);
				Console.WriteLine("Edad Valida");


		}
	}
}
