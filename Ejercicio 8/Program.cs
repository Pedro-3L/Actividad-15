using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double resultado;
			double numero;
			bool correcto;
			do
			{
				Console.Clear();
				Console.WriteLine("Ingrese un numero");
				correcto = double.TryParse(Console.ReadLine(), out numero);
				if (numero < 0)
				{
					correcto = false;
					Console.WriteLine("Numero inválido, intentelo otra vez");
					Console.ReadKey();
				}

			} while (correcto == false);

			resultado = Math.Sqrt(numero);

			Console.WriteLine("La raíz cuadrada es: " + resultado);
		}
	}
}
