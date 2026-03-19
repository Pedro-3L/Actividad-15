using System;

namespace Ejercicio_4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int año;
			bool correcto;
			do
			{
				Console.Clear();
				Console.WriteLine("Ingrese un año de nacimiento");
				correcto = int.TryParse(Console.ReadLine(), out año);
				if (año < 1900 || año>2026)
				{
					correcto = false;
					Console.WriteLine("Año invalido, intentelo otra vez");
					Console.ReadKey();
				}

			} while (!correcto);
			Console.WriteLine("Año valido");

		}
	}
}
