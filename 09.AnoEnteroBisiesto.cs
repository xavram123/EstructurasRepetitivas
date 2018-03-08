/** Ingresar año como entero. Mostrar si el año es bisiesto. Un año es bisiesto 
si el año es divisible por 4 y no es divisible por 100 o es divisible por 400. 
El lazo deberá ser controlado por el usuario. **/

using System;
class año
{
 static void Main(string[] args)
{
int año;
int c;
	c=0;
do
{
	c=c+1;				
	Console.WriteLine("Ingrese año");
	año = int.Parse(Console.ReadLine());
if(año % 4 == 0 && año % 100 != 0 || año % 400 == 0)
{
	Console.Write("El año ingresado es bisiesto: ");
}
else
{
	Console.Write("Año no es bisiesto: ");
}
}
while(año !=0);
{
	Console.Write("Año ingresado no valido");
}
}
}
	
