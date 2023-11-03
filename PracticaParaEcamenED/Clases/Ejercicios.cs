using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace PracticaParaEcamenED.Clases
{
	internal class Ejercicios
	{
		/*Ejercicio 1 Busqueda Binaria en un arreglo de 100 numeros ramdom*/
		public void Ejercicio1()
		{
			int[] numeros = new int[99];
			Random random = new Random();
			int numeroActual = 0;

			//para llenar el arreglo con los numeros
			for (int i = 0; i < numeros.Length; i++)
				numeros[i] = random.Next(100);

			//para mostrar el arreglo desordenada
			Console.WriteLine("Arreglo desordenado:");
			Console.WriteLine(string.Join(" ",numeros));

			//Organizar arreglo de forma ascendente con burbuja
			/*for(int j = 0; j < numeros.Length -1; j++)
			{
				for(int l = j+1; l<numeros.Length; l++)
				{
					if (numeros[j] >= numeros[l])
					{
						numeroActual = numeros[j];
						numeros[j] = numeros[l];
						numeros[l] = numeroActual;
					}
				}
			}*/
			//organizar arreglo de forma descendente con burbuja
			for (int j = 0; j < numeros.Length - 1; j++)
			{
				for (int l = j + 1; l < numeros.Length; l++)
				{
					//para cambiar ente acsendente y decsendente lo unico que cambia
					//es la intruccion del if en el "<" o ">"
					if (numeros[j] <= numeros[l])
					{
						numeroActual = numeros[j];
						numeros[j] = numeros[l];
						numeros[l] = numeroActual;
					}
				}
			}
			//mostrar arreglo ordenado
			Console.WriteLine("Arreglo ordenado");
			Console.WriteLine(string.Join(" ", numeros));
			//busqueda binaria de forma descendente
			int inicio = 0;
			int fin = numeros.Length - 1;
			int centinela = -1;
			int objetivo = 75;

			while (inicio <= fin)
			{
				int medio = (inicio + fin) / 2;

				if (numeros[medio] == objetivo)
				{
					centinela = medio;
					break;
				}
				else if (numeros[medio] < objetivo)
				{
					fin = medio - 1; // Cambiar dirección de búsqueda
				}
				else
				{
					inicio = medio + 1; // Cambiar dirección de búsqueda
				}
			}

			if (centinela != -1)
			{
				Console.WriteLine($"El valor {objetivo} se encuentra en la posición {centinela} del arreglo.");
			}
			else
			{
				Console.WriteLine($"El valor no se encuentra en el arreglo.");
			}

			//encontrar el numero 75 con binario en el arreglo de forma ascendente
			/*
			int inicio = 0;
			int fin = numeros.Length - 1;
			int centinela = -1;
			int objetivo = 75;

			while (inicio <= fin)
			{
				int medio = (inicio + fin) / 2; // Calcular el punto medio en cada iteración

				if (numeros[medio] == objetivo)
				{
					centinela = medio;
					break; // Encontramos el número, así que salimos del bucle
				}
				else if (numeros[medio] > objetivo)
				{
					fin = medio - 1;
				}
				else
				{
					inicio = medio + 1;
				}
			}

			if (centinela != -1)
			{
				Console.WriteLine($"El valor {objetivo} se encuentra en la posición {centinela} del arreglo.");
			}
			else
			{
				Console.WriteLine($"El valor no se encuentra en el arreglo.");
			}
			*/

		}


		/*Ejercicio 2 sacar los datos de una curp*/
		public void Ejercicio2(string curp)
		{
			/*
			string cadenaCURP = curp;

			//para sacar el sexo de la CURP
			string sexo = " "; 
			int cadenaMoH = 11;
			if (cadenaCURP.Substring(cadenaMoH) == "M" || cadenaCURP.Substring(cadenaMoH) == "m")
			{
				sexo = "Mujer";
			}
			else
			{
				sexo = "Hombre";
			}
			Console.WriteLine(sexo);
			/*
			//para sacar la fecha de nacimiento
			int cadenaAñoInicio = 5;
			int cadenaAñoFin = 6;
			int cadenaMesInicio = 7;
			int cadenaMesFin = 8;
			string dia, mes, año;

			cadenaCURP.Substring(cadenaAñoInicio + cadenaAñoFin);
			cadenaCURP.Substring(cadenaMesInicio+cadenaMesFin);
			*/
			


		}

		/*ejercicio 3 tabla de ventas*/
		public void EjercicioVendedores()
		{
			int[,] ganacia = { 
				{ 500, 3000, 100, 400 }, 
				{ 1000, 150, 200, 500 }, 
				{ 250, 1800, 2900, 300 }, 
				{ 400, 130, 90, 2400 }, 
				{ 60, 20, 4000, 3600 } };
			int vendedor1 = 0;
			int vendedor2 = 0;
			int vendedor3 = 0;
			int vendedor4 = 0;
			int producto1 = 0;
			int producto2 = 0;
			int producto3 = 0;
			int producto4 = 0;
			int producto5 = 0;

			for (int i = 0; i < ganacia.GetLength(0); i++)
			{
				for (int j = 0; j < ganacia.GetLength(1); j++)
				{
					//no me acuer
					Console.WriteLine(ganacia[i, j].ToString().PadLeft(5));
					switch (j)
					{
						case 0:
							vendedor1 += ganacia[i, j];
							break;

						case 1:
							vendedor2 +=ganacia[i, j];
							break;
						case 2:
							vendedor3 += ganacia[i, j];
							break;
						case 3:
							vendedor4 +=ganacia[i, j];
							break;
					}

					switch (i)
					{
						case 0:
							producto1 += ganacia[i, j];
							break;

						case 1:
							producto2 += ganacia[i, j];
							break;
						case 2:
							producto3 += ganacia[i, j];
							break;
						case 3:
							producto4 += ganacia[i, j];
							break;
						case 4:
							producto5 += ganacia[i, j];
							break;
					}

				}
				Console.WriteLine();
			}
			Console.WriteLine($"ganancias del vendedor 1 {vendedor1}");
			Console.WriteLine($"ganancias del vendedor 2 {vendedor2}");
			Console.WriteLine($"ganancias del vendedor 3 {vendedor3}");
			Console.WriteLine($"ganancias del vendedor 4 {vendedor1}");
			Console.WriteLine($"ganancias del producto 1 {producto1}");
			Console.WriteLine($"ganancias del producto 2 {producto2}");
			Console.WriteLine($"ganancias del producto 3 {producto3}");
			Console.WriteLine($"ganancias del producto 3 {producto4}");
			Console.WriteLine($"ganancias del producto 3 {producto5}");
		}
	}
}
