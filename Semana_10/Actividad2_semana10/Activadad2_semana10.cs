class clase_semana8
{
    static void Main()
    {
    Console.WriteLine("Lista de numeros");
        do{
            int[] listaDeNumeros = new int[8];
            double sumaDeLista = 0, promedioDeLista = 0; 
            
            for(int i = 0; i < listaDeNumeros.Length; i++){

                Console.WriteLine($"Ingrese el valor para el número {i + 1}");
                string numeroIngresado = Console.ReadLine();

                if(int.TryParse(numeroIngresado, out int numeroEntero) && numeroEntero >= 0){
                    listaDeNumeros[i] = numeroEntero;
                    sumaDeLista += numeroEntero;
                }
                else
                {
                    Console.WriteLine("Ingrese un valor valido... ");
                    Console.Write("Vuelva a ingresar un número.");
                    i--;
                }     
            }

            promedioDeLista = sumaDeLista / listaDeNumeros.Length;
                
            Console.WriteLine("Los números ingresados son: ");
            for(int i = 0; i < listaDeNumeros.Length; i++){
                Console.WriteLine($"Dato {i+1}: {listaDeNumeros[i]}");
            }
            
            Console.WriteLine($"La suma de la lista de datos es: {sumaDeLista}");
            Console.WriteLine($"El promedio de la lista de datos es: {promedioDeLista}"); 
        break;
        }while(true);
    }
}