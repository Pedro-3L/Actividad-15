using System;

namespace Ejercicio__10
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int cantidad;
			bool correcto;
			do
			{
				Console.Clear();
				Console.WriteLine("Ingrese la cantidad de productos que desee:");
				correcto = int.TryParse(Console.ReadLine(), out cantidad);
				if (cantidad <= 0)
				{
					correcto = false;
					Console.WriteLine("Cantidad inválido, intentelo otra vez");
					Console.ReadKey();
				}
			} while (correcto == false);

			string[] productos = new string[cantidad];
			string nombre;

			for (int i = 0; i < cantidad; i++)
			{
				Console.Clear();
				Console.WriteLine($"Producto #{i + 1}");
				productos[i] = Console.ReadLine();
			}
			Console.Clear();
			Console.WriteLine("Lista de productos:");
			for (int i = 0; i < cantidad; i++)
			{
				Console.WriteLine(productos[i]);
			}
		}
	}
}
