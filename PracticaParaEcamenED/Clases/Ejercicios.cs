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
			
			string cadenaCURP = curp;

			//para sacar el sexo de la CURP
			string sexo = " "; 
			string cadenaMoH = cadenaCURP.Substring(10,1);
		
			if (cadenaMoH == "M" || cadenaMoH == "m")
			{
				sexo = "Mujer"; 
			}
			else
			{
				sexo = "Hombre";
			}

			//para sacar la fecha de nacimiento
			string añoNacimiento = cadenaCURP.Substring(4,2);
			string mesNacimiento = cadenaCURP.Substring(6, 2);
			string diaNacimienro = cadenaCURP.Substring(8,2);
			Console.WriteLine($"{diaNacimienro}/{mesNacimiento}/{ añoNacimiento}");


			Console.WriteLine($"Usted es del sexo: {sexo}");
			
		}






		/*ejercicio 3 tabla de ventas   CORREGIDO EN SU MAYORIA*/
		public void EjercicioVendedores()
		{
			int[,] ganacia = { 
				{ 500, 3000, 100, 400 }, 
				{ 1000, 150, 200, 500 }, 
				{ 250, 1800, 2900, 300 }, 
				{ 400, 130, 90, 2400 }, 
				{ 60, 20, 4000, 3600 } };
			int[] vendedores = new int[4]; //se pone uno mas del que enrelidad necesitas sino da un error de fura de rango del array
			int[] productos = new int[5]; //porque? quien sabe la mera neta ¯\(o_o)/¯
			
			

			for (int i = 0; i < ganacia.GetLength(0); i++)
			{
				for (int j = 0; j < ganacia.GetLength(1); j++)
				{
					
					Console.WriteLine(ganacia[i, j]);
					switch (j)
					{
						case 0:
							vendedores[0] += ganacia[i, j];
							break;

						case 1:
							vendedores[1] +=ganacia[i, j];
							break;
						case 2:
							vendedores[2] += ganacia[i, j];
							break;
						case 3:
							vendedores[3] +=ganacia[i, j];
							break;
					}

					switch (i)
					{
						case 0:
							productos[0] += ganacia[i, j];
							break;

						case 1:
							productos[1] += ganacia[i, j];
							break;
						case 2:
							productos[2] += ganacia[i, j];
							break;
						case 3:
							productos[3] += ganacia[i, j];
							break;
						case 4:
							productos[4] += ganacia[i, j];
							break;
					}

				}
				Console.WriteLine();
			}
			for(int x=0; x<vendedores.Length; x++)
			{
				Console.WriteLine($"ganancias del vendedor {x}: {vendedores[x]}");
			}
			for (int z = 0; z <= vendedores.Length; z++)
			{
				Console.WriteLine($"ganancias del producto {z}: {productos[z]}");
			}
		}

	}

}
