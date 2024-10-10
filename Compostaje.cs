using System.Numerics;

class Compostaje : Reciclaje
{
    public object[] compostaje =
    {"Cáscaras de huevo", "Restos de verduras y frutas", "Residuos de origen animal",
    "Huesos", "Piel", "Carne", "Sangre" ,"Follaje", "Tallos frescos","Hojas secas","Abonos verdes"};
    public void MostrarMaterialesOrganicosPermitidos()
    {
        Console.WriteLine("Materiales permitidos para Compostaje:");
        foreach (var item in compostaje)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("Por favor asegurese que los materiales ingresados coinciden unicamente con los anterioes mencionados");
    }

    public double CalcularCompostaje(double pesoCalculado, int indice)
    {
        PreguntarYaIngresoTodosMateriales();
        double puntos = 1;
        double puntosObtenidos = pesoCalculado * puntos;
        Console.WriteLine($"Cantidad de puntos obtenidos por cada kg de {arregloCategorias[0, indice]} :{puntos} pts");
        Console.WriteLine($"Peso registrado por la maquina: {pesoCalculado} KG de {arregloCategorias[0, indice]}");
        Console.WriteLine($"Total de Puntos obtenidos: {puntosObtenidos} pts");
        double resultadoCalcularCompostaje = puntosObtenidos;
        return resultadoCalcularCompostaje;

    }
    public double Compostar()
    {
        double totalCompostado = 0;
        Random random = new Random();
        double pesoCalculado = random.Next(1, 100);
        MostrarMaterialesOrganicosPermitidos();
        totalCompostado = CalcularCompostaje(pesoCalculado, 4);
        return totalCompostado;
    }
}
