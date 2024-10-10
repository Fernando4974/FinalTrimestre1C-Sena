public class Persona
{
    public string Nombre { get; set; }
    public string Cedula { get; set; }
    public double Puntos { get; set; }

    // Constructor para inicializar los atributos
    public Persona(string nombre, string cedula, double puntos)
    {
        Nombre = nombre;
        Cedula = cedula;
        Puntos = puntos;
    }

    public override string ToString()
    {
        return $"Nombre: {Nombre}, Cédula: {Cedula}, Puntos: {Puntos}";
    }

    // Método estático para crear una instancia de Persona pidiendo datos al usuario
    public static Persona CrearPersona(double PuntosAcumularPersona)
    {
        Console.Write("Ingrese el su nombre para almacenar sus datos y calcular los Premios obtenidos: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese la cédula: ");
        string cedula = Console.ReadLine();

        double puntos=0;
        puntos +=PuntosAcumularPersona;
        

        return new Persona(nombre, cedula, puntos);
    }
    
}