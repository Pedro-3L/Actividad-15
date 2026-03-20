// See https://aka.ms/new-console-template for more information

int numero;
bool correcto;
do
{
	Console.Clear();
	Console.WriteLine("Ingrese un numero");
	correcto = int.TryParse(Console.ReadLine(), out numero);
	if (!correcto)
	{
		Console.WriteLine("Numero invalido, intentelo otra vez");
		Console.ReadKey();
	}

} while (!correcto);
if (numero % 2 == 0)
{
	Console.WriteLine("Numero valido, es par");
}
else
{
	Console.WriteLine("Numero valido, es impar");
}
