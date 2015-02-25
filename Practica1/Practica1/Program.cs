using System;

	namespace Practica1 
	{ 
				class Program 
				{ 
					static void Main(string[] args) 
					{
						Console.Title = "Practica_1"; 
						Console.BackgroundColor = ConsoleColor.DarkBlue; 
						Console.ForegroundColor = ConsoleColor.White; Console.Clear(); 
							int primero, segundo; 
							float radio; 

						Console.WriteLine("Programa que realiza las operaciones basicas de dos numeros\n\n Selecciona una opcion: \n"); 
						Console.WriteLine("1= Suma\n2= Resta\n3= Multiplicacion\n4= Division\n5= Area de un triangulo\n6= Area de un circulo\n7= Area de un cuadrado\n"); 

			int opc = int.Parse(Console.ReadLine()); 

			switch (opc) { 

			case 1: 
					Console.WriteLine("Suma\n"); 
					Console.Write("Dame el primer numero: "); 
						primero = int.Parse(Console.ReadLine()); 
					Console.Write("Dame el primer segundo: "); 
						segundo = int.Parse(Console.ReadLine()); 

					Console.WriteLine("Resultado = " + (primero + segundo)); 

			break; 

			case 2: 

						Console.WriteLine("Resta\n"); 
						Console.Write("Dame el primer numero: "); 
							primero = int.Parse(Console.ReadLine());
						Console.Write("Dame el primer segundo: ");
							segundo = int.Parse(Console.ReadLine()); 
						Console.WriteLine("Resultado = " + (primero - segundo)); 

			break; 

			case 3: 

						Console.WriteLine("Multiplicacion\n"); 
						Console.Write("Dame el primer numero: "); 
							primero = int.Parse(Console.ReadLine()); 
						Console.Write("Dame el primer segundo: "); 
							segundo = int.Parse(Console.ReadLine()); 
						Console.WriteLine("Resultado = " + (primero * segundo)); 
			break; 

			case 4: 
						Console.WriteLine("Division\n"); 
						Console.Write("Dame el primer numero: ");
							primero = int.Parse(Console.ReadLine()); 
						Console.Write("Dame el primer segundo: ");
							segundo = int.Parse(Console.ReadLine()); 
						Console.WriteLine("Resultado = " + (float)(Math.Round((double) primero / segundo, 2))); 
			break; 
			
			case 5: 

						Console.WriteLine("Area de Triangulo\n"); 
						Console.Write("Dame la base: "); 
							primero = int.Parse(Console.ReadLine()); 
						Console.Write("Dame la altura: "); 
							segundo = int.Parse(Console.ReadLine()); 
						Console.WriteLine("Resultado = " + (float)(Math.Round((double) (primero * segundo) / 2, 2))); 
			break; 

			case 6: 

						Console.WriteLine("Area de Circulo\n"); 
						Console.Write("Dame el radio: "); 
							radio = float.Parse(Console.ReadLine()); 
						Console.WriteLine("Resultado = " + (float)(Math.Round((double)(radio * radio) * Math.PI, 2))); 
			break; 

			case 7: 

						Console.WriteLine("Area de Cuadrado"); 
						Console.Write("Dame el lado: "); 
							primero = int.Parse(Console.ReadLine()); 
						Console.WriteLine("Resultado = " + (primero * primero)); 
			break; 

					default: Console.WriteLine("Opcion invalida"); 

			break;

			} 

			Console.Write("Presiona una tecla para continuar. . . "); 
			Console.ReadKey(true);
		} 
	} 
}