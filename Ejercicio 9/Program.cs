using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int nota;
			bool correcto;
			do
			{
				Console.Clear();
				Console.WriteLine("Ingrese la nota del estudiante");
				correcto = int.TryParse(Console.ReadLine(), out nota);
				if (nota < 0 || nota > 100)
				{
					correcto = false;
					Console.WriteLine("Nota invalida, intentelo otra vez");
					Console.ReadKey();
				}
			} while (correcto == false);
			Console.WriteLine("Nota valida");
			if (nota >= 61)
			{
				Console.WriteLine("Aprobo");
			}
			else
			{
				Console.WriteLine("Reprobo");
			}


		}
	}
}
