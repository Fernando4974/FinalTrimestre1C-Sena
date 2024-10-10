class Incentivo : Reciclaje
{
   
    public void mostrarIncentivosBase()
    {
        Console.WriteLine("Cantidad de puntos obtenidos por kg de Materiales Reciclados/Compostados");
        Console.WriteLine(" ");
        for (int i = 0; i < arregloCategorias.GetLength(1); i++)
        {


            for (int j = 0; j < arregloCategorias.GetLength(0); j++)
            {

                Console.Write(arregloCategorias[j, i] + " ");
                if (j == 1)
                {
                    Console.WriteLine(" Pts");
                }

            }
        }
    }



    public double CalcularPuntosLugar(double lugar,double resultadoCalcularReciclado){
        Console.WriteLine($"Puntos obtenidos para la Sede de {lugar}");
        double puntosGanadosEnLugar=resultadoCalcularReciclado;
        return Math.Round(puntosGanadosEnLugar,0);
    }
    public object CalcularIncentivo(double puntosTotales ){
        Random random2=new Random();
        int codigo= random2.Next(900,9000);
        object[] arregloIncentivo ={$"Bono de 5000 pesos EDS Primax CODIGO{codigo}",$"Descuento del 2% en el Cobro de la Dian CODIGO{codigo}"};
        object incentivo=0;
        
        
        if (puntosTotales>=10)
        {
            incentivo=0;
        }

        return incentivo;
    }
}
 
   