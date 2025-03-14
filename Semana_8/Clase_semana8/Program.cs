class clase_semana8
{
    static void Main()
    {
        int nota1 = 10, nota2 = 20, nota3 = 30, nota4 = 40;
        float precio = 12.20999f;
        double distancia = 12345.6789;
        char inicial = 'J';
        string nombre = "Ana López";
        bool esMayorDeEdad = true;
        string entrada = "123";
        decimal salario = 75000.00m;
        int numero = 0;
       
        Console.WriteLine("Nombre: " + nombre + ", Nota1: " + nota1);
        Console.WriteLine($"Nombre: {nombre}, Nota2: {nota2}");
        Console.WriteLine(String.Format("Nombre: {0}, Nota3: {1}, Nota4 {2}", nombre, nota3, nota4));
        Console.WriteLine($"Precio: {precio:F2}");
       
        while (true)
        {
            Console.Write("Ingrese un número válido: ");
            entrada = Console.ReadLine();
 
            if (int.TryParse(entrada, out numero))
            {
                break;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Inténtalo de nuevo.");
            }
        }
 
        Console.WriteLine($"Número válido ingresado: {numero}");
    }
 
}