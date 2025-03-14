 
class clase_semana8
{
    static void Main()
    {
        Console.WriteLine("Ingrese un número: ");
        int numeroIngresado;

        do{
            if(int.TryParse(Console.ReadLine(), out numeroIngresado) && (numeroIngresado > 0 && numeroIngresado < 999999)){
                if(numeroIngresado == 1){
                    Console.WriteLine($"El numero {numeroIngresado} No es un numero primo");
                    break;
                }
                else
                {
                    bool esNumeroPrimo = true;

                    for(int i = 2; i <= Math.Sqrt(numeroIngresado); i++){
                        if(numeroIngresado % i == 0){
                            esNumeroPrimo = false;
                            break;
                        }
                    }
                    if (esNumeroPrimo)
                            {
                                Console.WriteLine($"El número {numeroIngresado} es un número primo.");
                                
                            }
                            else
                            {
                                Console.WriteLine($"El número {numeroIngresado} no es un número primo.");
                                
                            }
                            break;
                }
            }
            else
            {
                Console.WriteLine("Numero invalido... El numero debe de ser mayor a 0 y menor de 6 digitos por favor");
                Console.WriteLine("Vuelve a ingresar un numero"); 
            }
        }while(true);
    }
 
}
 
 