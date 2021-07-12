using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValeriaLopezEjercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
			//Definir Perimetro, Hipotenusa, Superficie, CatetoA, CatetoB Como Real;
			//Escribir "Ingresar el Valor del Cateto A";
			//Leer CatetoA;
			//Escribir "Ingresar el Valor del Cateto B";
			//Leer CatetoB;
			//Superficie = (CatetoA + CatetoB) / 2;
			//Hipotenusa = rc(CatetoA ^ 2 + CatetoB ^ 2);
			//Perimetro = CatetoA + CatetoB + Hipotenusa;
			//Escribir "Dados los catetos el Valor de la Hipotenusa es: ",Hipotenusa;
			//Escribir "La Superficie del Triangulo es: ", Superficie;
			//Escribir "El Perimetro es: ",Perimetro;
			Console.Title = "Ejercicio 01";
			Double Perimetro, Hipotenusa, Superficie, CatetoA, CatetoB;
			Console.Write("Ingrese el Cateto A: ");
			CatetoA = Convert.ToDouble(Console.ReadLine());
			Console.Write("Ingrese el Cateto B: ");
			CatetoB = Convert.ToDouble(Console.ReadLine());
			Superficie = (CatetoA + CatetoB) / 2;
			Hipotenusa = Math.Sqrt((Math.Pow(CatetoA,2) + Math.Pow(CatetoB,2)));
            Perimetro = CatetoA + CatetoB + Hipotenusa;
            Console.WriteLine($"Dados los catetos el Valor de la Hipotenusa es: {Hipotenusa}");
			Console.WriteLine($"La Superficie del Triangulo es: {Superficie}");
			Console.WriteLine($"El Perimetro es:  {Perimetro}");
			Console.ReadLine();

        }
	}
}
