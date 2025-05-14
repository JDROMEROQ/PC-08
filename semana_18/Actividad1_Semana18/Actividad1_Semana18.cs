using System;
using System.Net.Mail;

class Program 
{
    public static void Menu(NotasDeEstudiantes notas)
    {
        int opcion;
        do{
            Console.WriteLine("\n------ MENÚ PRINCIPAL ------");
            Console.WriteLine("[1] Ingresar nombres y notas de estudiantes");
            Console.WriteLine("[2] Mostrar Estudiantes y notas aprobadas");
            Console.WriteLine("[3]. Mostrar Estudiantes y notas reprobadas");
            Console.WriteLine("[4] Mostrar Promedio de Estudiantes y de Grupo");
            Console.WriteLine("[5] Salir");
            Console.Write("Seleccione una opción: ");

            opcion = notas.ValidacionDato();

            switch (opcion)
            {
                case 1:
                    notas.NombresDeEstudiantes();
                    break;
                case 2:
                    notas.MostrarNotasAprobadas();
                    break;
                case 3:
                    notas.MostrarNotasReprobadas();
                    break;
                case 4:
                    notas.PromedioEstudiantes();
                    break;
                case 5:
                    Console.WriteLine("Saliendo del programa...");
                    return;
                default:
                    Console.WriteLine("Opción inválida. Intente de nuevo.");
                    break;
            }

            if (opcion != 5)
            {
                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcion != 5);
    }
    
    public static void Main(String[] args)
    {

    NotasDeEstudiantes notas = new NotasDeEstudiantes(new string[10], new int[10, 10], new double[10]);
    Menu(notas);  
        
    }
}

class NotasDeEstudiantes
{
    private string[] _nombreYApellidoEstudiante = new string[10];
        
    public string[] nombreYApellidoEstudiante
    {
        get { return _nombreYApellidoEstudiante; }
        set { _nombreYApellidoEstudiante = value; }
    }

    private int[,] _notaDelEstudiante = new int[10, 10];

    public int[,] notaDelEstudiante
    {
        get { return _notaDelEstudiante; }
        set { _notaDelEstudiante = value; }
    }

    private double[] _promediosDeEstudiantes = new double[10];

    public double[] promediosDeEstudiantes
    {
        get { return _promediosDeEstudiantes; }
        set { _promediosDeEstudiantes = value; }
    }



    public NotasDeEstudiantes(string[] nombreYApellidoEstudiante, int[,] notaDelEstudiante, double[] promediosDeEstudiantes){
        this.nombreYApellidoEstudiante = nombreYApellidoEstudiante;
        this.notaDelEstudiante = notaDelEstudiante;
        this.promediosDeEstudiantes = promediosDeEstudiantes;
    }

    public int ValidacionDato(){
            string datoIngresado;
            int datoValido;

            do{
                datoIngresado = Console.ReadLine();
                if(int.TryParse(datoIngresado, out datoValido)){
                    break;
                }else{
                    Console.WriteLine("El valor ingresado no es valido... Vuelva a intentarlo");
                }
            }while(true);
            
            return datoValido;
        }

    public void NombresDeEstudiantes(){
        
        for (int filaEstudiante = 0; filaEstudiante < nombreYApellidoEstudiante.GetLength(0); filaEstudiante++)
        {
            Console.Write($"Ingrese el nombre del estudiante #{filaEstudiante + 1}: ");
            nombreYApellidoEstudiante[filaEstudiante] = Console.ReadLine();

            for (int columnaNotasDeEstudiante = 0; columnaNotasDeEstudiante < notaDelEstudiante.GetLength(1); columnaNotasDeEstudiante++)
            {
                Console.Write($"Ingrese la nota #{columnaNotasDeEstudiante + 1} de {nombreYApellidoEstudiante[filaEstudiante]}: ");
                notaDelEstudiante[filaEstudiante, columnaNotasDeEstudiante] = ValidacionDato();
            }
        }


    }

    public void PromedioEstudiantes(){
        
        double promedioAcumulado = 0;
        Console.WriteLine("Nombre del estudiante:  \t Notas del Estudiante:  \t Promedios:  ");

        for(int filaPromedio = 0; filaPromedio < nombreYApellidoEstudiante.GetLength(0); filaPromedio++){

            double suma = 0;
            string mostraNotas = "";
            for(int columnaPromedio = 0; columnaPromedio < notaDelEstudiante.GetLength(1); columnaPromedio++){
                suma += notaDelEstudiante[filaPromedio, columnaPromedio];
                mostraNotas = notaDelEstudiante[filaPromedio, columnaPromedio].ToString();
            }

            promediosDeEstudiantes[filaPromedio] = suma / 10; 
            promedioAcumulado += promediosDeEstudiantes[filaPromedio];

            Console.WriteLine($"{nombreYApellidoEstudiante[filaPromedio]}  \t{mostraNotas}  \t{promediosDeEstudiantes[filaPromedio]}");
        }
        double promedioDeGrupo = promedioAcumulado / 10;
        Console.WriteLine($"El promedio del grupo es: {promedioDeGrupo:F2}");
    }

    public void MostrarNotasAprobadas()
    {
        Console.WriteLine(" Alumnos con notas Aprobadas");
        for (int filaAprobados = 0; filaAprobados < 10; filaAprobados++)
        {
            Console.Write($"{nombreYApellidoEstudiante[filaAprobados]}: ");
            for (int columnaAprobados = 0; columnaAprobados < 10; columnaAprobados++)
            {
                if (notaDelEstudiante[filaAprobados, columnaAprobados] >= 65)
                    Console.Write($"{notaDelEstudiante[filaAprobados,  columnaAprobados]} ");
            }
        }
    }

    public void MostrarNotasReprobadas()
    {
        Console.WriteLine(" Alumnos con notas Reprobadas");
        for (int filaAprobados = 0; filaAprobados < 10; filaAprobados++)
        {
            Console.Write($"{nombreYApellidoEstudiante[filaAprobados]}: ");
            for (int columnaAprobados = 0; columnaAprobados < 10; columnaAprobados++)
            {
                if (notaDelEstudiante[filaAprobados, columnaAprobados] < 65)
                    Console.Write($"{notaDelEstudiante[filaAprobados,  columnaAprobados]} ");
            }
        }
    }

}
