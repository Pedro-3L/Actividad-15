using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime fecha;
			bool correcto;
			do
			{
				Console.Clear();
				Console.WriteLine("Ingrese una fecha");
				correcto = DateTime.TryParse(Console.ReadLine(), out fecha);
				if (!correcto)
				{
					Console.WriteLine("Fecha invalida, intentelo otra vez");
					Console.ReadKey();
				}

			} while (!correcto);
			Console.WriteLine("Fecha valida " + fecha);
		}
	}
}
