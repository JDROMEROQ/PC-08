class clase_semana8_actividad2{
    static void Main(string [] args)
    {
        Console.WriteLine("Ingrese un numero entero que sea positivo: ");
        int numeroEntero;
        do{

            if (int.TryParse(Console.ReadLine(), out  numeroEntero) && numeroEntero >= 0)
            {
                int resultadoFactorial = CalcularFactorial(numeroEntero);
                Console.WriteLine($"El factorial del numero {numeroEntero} es: {resultadoFactorial}");
                break;
            }
            else
            {
                Console.WriteLine("Ingrese un numero entero que sea positivo mamahuevo.");
                Console.WriteLine("Vuelva a ingresar un numero: ");
            }
        }while(true);
    }

    public  static int CalcularFactorial(int numeroEntero)
    {

        if (numeroEntero == 0)
        {
            return 1;
        }
        else
        {
            int factorial = 1;
            for (int i = 1; i <= numeroEntero; i++)
            {
                factorial *= i;
            }   
            return factorial; 
        }

    }

}
