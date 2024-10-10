using System.IO.Compression;
using System.Net.NetworkInformation;

class Reciclaje
{
    public static double medellin { get; set; }
    public static double bello { get; set; }
    public string categoria { get; set; }
    // public int indiceArticulos { get; set; }
    public object[,] centros ={{"MEDELLIN","BELLO"},
    {medellin,bello}};
    public double peso { get; set; }
    public object[,] arregloCategorias ={
        {"Plastico","Papel", "Vidrio", "Metales","Composta"},
        {1.8,0.9,2.5,3.5,1}
    };
    public int indiceCategorias = 0;
    public double Reciclar()
    {
        double totalReciclado = 0;
        Random random = new Random();
          Console.WriteLine("");
    Console.WriteLine("---------------------------ARTICULOS---------------------------------");
       
       Console.WriteLine($"Seleccione Articulo que va a ser procesado");
        for (indiceCategorias = 0; indiceCategorias < 4; indiceCategorias++)
        {
            Console.WriteLine($"{indiceCategorias}----------------- {arregloCategorias[0, indiceCategorias]} ");

        }
        categoria = Console.ReadLine();
        indiceCategorias = int.Parse(categoria);
        double pesoCalculado;
        switch (categoria)
        {
            case "0":

                // el peso se calcula con un numero random
                pesoCalculado = random.Next(1, 100);
                totalReciclado = CalcularReciclado(pesoCalculado, indiceCategorias);
                ///


                break;

            case "1":


                pesoCalculado = random.Next(1, 10);
                totalReciclado = CalcularReciclado(pesoCalculado, indiceCategorias);

                break;

            case "2":
                pesoCalculado = random.Next(1, 20);
                totalReciclado = CalcularReciclado(pesoCalculado, indiceCategorias);

                break;

            case "3":
                pesoCalculado = random.Next(1, 100);
                totalReciclado = CalcularReciclado(pesoCalculado, indiceCategorias);

                break;

            default:
                break;

        }







        return totalReciclado;


    }



    public double CalcularIncentivo(double Puntos)
    {

        double totalIncentivo = 0;



        return totalIncentivo;

    }





    public int PreguntarYaIngresoTodosMateriales()
    {
        int respuestaIngresoMateriales = 0;
        int validar = 0;
          Console.WriteLine("");
    Console.WriteLine("---------------------------PESAJE---------------------------------");
        Console.WriteLine("Inicio el proceso de pesado de materiales...");
        while (validar == 0)
        {


            Console.WriteLine("Ingrese en la ranura corespondiete los materiales para ser pesados");
            Console.WriteLine("Pesando...");
            Console.WriteLine("Presione la tecla ( 1 ) cuando alla finalizado el ingreso de todos los materiales ");
            validar = int.Parse(Console.ReadLine());
            if (validar == 1)
            {
                Console.WriteLine("Confirme que ya a terminado de ingresar todos los materiales");
                Console.WriteLine("Digite nuevamente la tecla ( 1 ) para confirmar o presione ( 2 ) para seguir ingresando");
                int confirmarValidar = int.Parse(Console.ReadLine());
                if (confirmarValidar == 1)
                {
                    respuestaIngresoMateriales = 1;
                }
                else
                {
                    validar = 0;
                }
            }
            else
            {
                validar = 0;
            }

        }

        return respuestaIngresoMateriales;

    }




    public double CalcularReciclado(double pesoCalculado, int indice)
    {
        PreguntarYaIngresoTodosMateriales();
        double puntos = Convert.ToDouble(arregloCategorias[1, indice]);
        double puntosObtenidos = pesoCalculado * puntos;
          Console.WriteLine("");
    Console.WriteLine("---------------------------PUNTOS---------------------------------");
        Console.WriteLine($"Cantidad de puntos obtenidos por cada kg de {arregloCategorias[0, indice]} :{puntos} pts");
        Console.WriteLine($"Peso registrado por la maquina: {pesoCalculado} KG de {arregloCategorias[0, indice]}");
        Console.WriteLine($"Total de Puntos obtenidos: {puntosObtenidos} pts");
        double resultadoCalcularReciclado = puntosObtenidos;
        return resultadoCalcularReciclado;
    }

}