using System;
public class Program
{
int numero;
string cadena;
public static void Main()
{
Program objetoProgram = new Program(3, "hola");
objetoProgram.show();
}
Program(int numero, string cadena) {
this.numero = numero;
this.cadena = cadena;
}
void show() {
Console.WriteLine(this.numero);
Console.WriteLine(this.cadena);
}
}