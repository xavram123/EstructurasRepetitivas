/**  Mostrar en pantalla la siguiente serie de números: 100 98 96 94... 56 54 52 50 **/

using System;
class serienumeros
{
    static void Main(string[] args)
    {
        int Num;
        for (Num = 100; Num >= 50; Num = Num - 2)
        {
			Console.Write(Num + ", ");
		}
    }
}
