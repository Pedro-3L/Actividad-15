using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
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
				Console.WriteLine("Ingrese la cantidad de estudiantes del curso");
				correcto = int.TryParse(Console.ReadLine(), out cantidad);
				if (cantidad<0)
				{
					correcto = false;
					Console.WriteLine("Cantidad invalida, intentelo otra vez");
					Console.ReadKey();
				}

			} while (!correcto);
			Console.WriteLine("Cantidad valida");
		}
	}
}
