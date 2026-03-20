using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double salario;
			bool correcto;
			do
			{
				Console.Clear();
				Console.WriteLine("Ingrese el salario de un empelado ");
				correcto = double.TryParse(Console.ReadLine(), out salario);
				if (salario<0)
				{
					correcto = false;
					Console.WriteLine("Salario invalido, intentelo otra vez");
					Console.ReadKey();
				}

			} while (!correcto);
			Console.WriteLine("Salario valido");
		}
	}
}
