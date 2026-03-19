using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double producto;
			bool correcto;
			do
			{
				Console.Clear();
				Console.WriteLine("Ingrese el precio de un producto");
				correcto = double.TryParse(Console.ReadLine(), out producto);
				if (producto <=0)
				{
					correcto = false;
					Console.WriteLine("Producto invalido, intentelo otra vez");
					Console.ReadKey();
				}

			} while (correcto == false);
			Console.WriteLine("Producto Valido");
		}
	}
}
