class Datos:Reciclaje
{
       
    public double EscogerLugar(){
          Console.WriteLine("");
    Console.WriteLine("---------------------------SEDE---------------------------------");
        Console.WriteLine("Selecciones el CENTRO DE RECICLAJE donde se ubica actualmente");
        for (int i = 0; i < centros.GetLength(0); i++)
        {
            Console.WriteLine($"Digite {i} para {centros[0,i]}");
        }
        double puntoSeleccionado=double.Parse(Console.ReadLine());
        if (puntoSeleccionado==1)
        {
            // aca creando la condicion paara seleccionar el punto pero est creo que no me servira
        }
        return puntoSeleccionado;


    }
        public Boolean CicloReciclaje(){
        bool salida=false;
            Console.WriteLine("Desea Ralizar otro otro Registro de Materiales?");
            Console.WriteLine(" Si, digite (S)|| No, digite (N)");
            string respuesta=Console.ReadLine().ToLower();
            if (respuesta=="s")
            {
                salida=false;
            }
            if (respuesta=="n")
            {
                salida=true;
            }
            return salida;
            }
            
    public Boolean Ciclo(){
        bool salida=false;
            Console.WriteLine("Desea Ralizar otro otro Registro?");
            Console.WriteLine(" Si, digite (S)|| No, digite (N)");
            string respuesta=Console.ReadLine().ToLower();
            if (respuesta=="s")
            {
                salida=false;
            }
            if (respuesta=="n")
            {
                salida=true;
            }
            
    return salida;
    }
    public void menu(){
            Console.WriteLine("A continuacion Se deplegara un Menu con la opciones disponibles");
    Console.WriteLine("Digite en numero de la accion que va a realiar");
    Console.WriteLine("");
    Console.WriteLine("---------------------------MENU---------------------------------");
    Console.WriteLine("1----------------- RECICLAJE");
    Console.WriteLine("2----------------- COMPOSTAJE");
    Console.WriteLine("3----------------- INCENTIVOS");
    Console.WriteLine("4----------------- TALLERES, REGULACIONES Y MULTAS");
    Console.WriteLine("5----------------- SALIR");
    }
    public void TalleresyDemas(){
        Console.WriteLine("Seleccione ");
    }

}