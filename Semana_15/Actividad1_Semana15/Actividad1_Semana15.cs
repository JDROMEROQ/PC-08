using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

class Estudiante{
    private string? _nombreEstudiante;
    public string nombreEstudiante{
        get{ return _nombreEstudiante != null ?_nombreEstudiante : "Ingrese el nombre del estudiante";}
        set{ _nombreEstudiante = value; }
    } 

    private double _edadEstudiante;
    public double edadEstudiante{
        get {return _edadEstudiante; }
        set {
            if(value > 17.0 && value < 90.0 ){//90 años como maximo de edad para un estudiante (Por tener algun limite)
                _edadEstudiante = value;
            }
            else
            {
                Console.WriteLine("Ingrese una edad valida...");
            }
        }
    }

    private string? _carrera;
    public string carrera{
        get{ return _carrera != null ? _carrera : "Ingrese la carrera que cursa el estudiante";}
        set{ _carrera = value; }
    } 
    private string? _carnet;
    public string carnet{
        get { return _carnet != null ? _carnet : "Ingrese el carnet del estudiante"; }
        set{ _carnet = value; }
    }
    
    private double _notaAdmision;
    public double notaAdmision{
        get {return _notaAdmision; }
        set {
            if(value > 0 && value < 100){
                _notaAdmision = value;
            }
            else
            {
                Console.WriteLine("La nota de admision debe ser valida...");
            }
        }
    }

    public Estudiante(string nombreEstudiante, double edadEstudiante, string carrera, string carnet, double notaAdmision){
        this.nombreEstudiante = nombreEstudiante;
        this.edadEstudiante = edadEstudiante;
        this.carrera = carrera;
        this.carnet = carnet;
        this.notaAdmision = notaAdmision;
    }

    public void MostrarResumen(){
        Console.WriteLine("Datos de Estudiante");
        Console.WriteLine($"Nombre del Estudiante: {nombreEstudiante}");
        Console.WriteLine($"Edad del Estudiante: {edadEstudiante}");
        Console.WriteLine($"Carrera del estudiante: {carrera}");
        Console.WriteLine($"Carnet del estudiante: {carnet}");
        Console.WriteLine($"Nota de admision que presenta el estudiante: {notaAdmision}");
    }

    public bool PuedeMatricularse(){
        return notaAdmision >= 75.0 && carnet.EndsWith("2025");
    }
}

class Program{
    public static double ValidacionDeDato(){

        double datoIngresado;
        string dato;

        do
        {
            Console.WriteLine("Ingrese el dato correspondiente: ");
            dato = Console.ReadLine();
            if(double.TryParse(dato, out datoIngresado)){
                break;
            }
            else
            {
                Console.WriteLine("El dato ingresado no es valido vuelva a intentarlo...");
            }
        }while(true);


        return datoIngresado;
    }

    public static void Main(String[] args){
        string nombre, carrera, carnet;
        double edad, nota;
        
        Console.WriteLine("Ingrese el nombre del estudiante: ");
        nombre = Console.ReadLine();
        
        Console.WriteLine("Ingrese la edad del estudiante: ");
        edad = ValidacionDeDato();
        
        Console.WriteLine("Ingrese la carrera del estudiante: ");
        carrera = Console.ReadLine();
        
        Console.WriteLine("Ingrese el carnet del estudiante: ");
        carnet = Console.ReadLine();

        Console.WriteLine("Ingrese la nota de admision del estudiante: ");
        nota = ValidacionDeDato();
    
        Estudiante estudiante1 = new Estudiante(nombre, edad, carrera, carnet, nota);

        if(estudiante1.PuedeMatricularse())
        {
            Console.WriteLine("El estudiante esta permitido a matricularse");
        }
        else
        {
            Console.WriteLine("El estudiante no esta permitido a matricularse. ¡Que pena!");
        }

        estudiante1.MostrarResumen();
    }
}