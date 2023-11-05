using PracticaParaEcamenED.Clases;

namespace PracticaParaEcamenED
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			Ejercicios ejer1 = new Ejercicios();
			ejer1.Ejercicio1();
			*/
			Ejercicios ejer2 = new Ejercicios();
			Console.WriteLine("dame tu CURP:");
			string curp = Console.ReadLine();
			ejer2.Ejercicio2(curp);
			
			/*
			Ejercicios ejer3 = new Ejercicios();
			ejer3.EjercicioVendedores();
			*/
		}
	}
}