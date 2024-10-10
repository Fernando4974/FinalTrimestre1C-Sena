// See https://aka.ms/new-console-template for more information
using System.Data;

Console.WriteLine("Binvenido al Programa de Gestion Ambiental");
Console.WriteLine("");
var lugar = new Datos();


double acumuladoMedellin = 0;
double puntosAcumularPersona=0;
double acumuladoBello = 0;
bool banderaSalida = false;
double puntosAcumular;

List<Persona> personas = new List<Persona>();
do
{


    double puntoSeleccionado = lugar.EscogerLugar();
    lugar.menu();
    int opcion = int.Parse(Console.ReadLine());
    switch (opcion)
    {
        case 1:
        
            byte banderaSalidaCase = 0;
            do
            {


                var Reciclar_1 = new Reciclaje { };
                puntosAcumular = Reciclar_1.Reciclar();

                if (puntoSeleccionado == 0)
                {
                    acumuladoMedellin += puntosAcumular;
                    puntosAcumularPersona += puntosAcumular;
                }
                if (puntoSeleccionado == 1)
                {
                    acumuladoBello += puntosAcumular;
                    puntosAcumularPersona += puntosAcumular;

                }

                Console.WriteLine("Desea Resiclar otro material? ||| Marque ( 0 ) para SI ó ( 1 ) para NO");
                banderaSalidaCase = byte.Parse(Console.ReadLine());

            } while (banderaSalidaCase == 0);


            break;

        case 2:
            do
            {



                var compostaje_1 = new Compostaje { };
                puntosAcumular = compostaje_1.Compostar();
                if (puntoSeleccionado == 0)
                {
                    acumuladoMedellin += puntosAcumular;
                    puntosAcumularPersona += puntosAcumular;
                }
                if (puntoSeleccionado == 1)
                {
                    acumuladoBello += puntosAcumular;
                    puntosAcumularPersona += puntosAcumular;
                }
                Console.WriteLine("Desea Compostar otro material? ||| Marque ( 0 ) para SI ó ( 1 ) para NO");
                banderaSalidaCase = byte.Parse(Console.ReadLine());
            } while (true);
            break;

        case 3:
            var incentivo_1 = new Incentivo { };
            incentivo_1.mostrarIncentivosBase();
            break;

        case 4:
            break;

        case 5:
            Console.WriteLine("Fin Del Programa");
            break;


        default:

            break;
            var salidaObjeto = new Datos();
            salidaObjeto.CicloReciclaje();

    }
    // Crear una nueva instancia de Persona y agregarla a la lista
    Persona persona = Persona.CrearPersona(puntosAcumularPersona);
    personas.Add(persona);
    // Mostrar todas las personas en la lista
    MostrarPersonas(personas);
    static void MostrarPersonas(List<Persona> personas)
    {
        Console.WriteLine("\nLista de Personas:");
        foreach (var persona in personas)
        {
            Console.WriteLine(persona);
        }
    }
    var salida = new Datos();
    banderaSalida = salida.Ciclo();
}
while (banderaSalida == false);
Console.WriteLine($"Puntos acumulados Sede Medellin: {acumuladoMedellin}");
Console.WriteLine($"Puntos acumulados Sede Bello: {acumuladoBello}");
