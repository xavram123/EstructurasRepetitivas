/** Hacer un programa que imprima el cubo y la raíz cuadrada de un numero ingresado 
por la pantalla; el programa debe estar confeccionado de tal manera que el proceso 
a efectuarse sea repetitivo. Debe terminar cuando al pedir el número se ingrese el 
valor 0. **/

using System;
class cubo
{
static void Main(String [] xavi)
{
double raiz,cubo,num,c;
c=0;

do
{
	c=c+1;
	Console.WriteLine("PROCESO Nยบ{0}:", c);
	Console.Write("Ingrese numero ");
	num=Convert.ToDouble(Console.ReadLine());
	if(num != 0)
	{
	cubo = Math.Pow(num,3);
	raiz = Math.Sqrt(num);	
	
	Console.WriteLine("El cubo es: " +cubo);
	Console.WriteLine("La raiz es: " +raiz);
	}
}
while (num != 0);
{
Console.Write("Fin del proceso: ");
}
}
}
