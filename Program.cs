internal partial class Program
{
    public class Tarea
    {
        private int tareaID;
        private string? descripcion;
        private int duracion;

        public Tarea(int tareaID, string? descripcion, int duracion)
        {
            this.tareaID = tareaID;
            this.descripcion = descripcion;
            this.duracion = duracion;
        }

        public int TareaID { get => tareaID; set => tareaID = value; }
        public string? Descripcion { get => descripcion; set => descripcion = value; }
        public int Duracion { get => duracion; set => duracion = value; }
    }
    private static void Main(string[] args)
    {
        
        var pendientes= new List<Tarea>();
        var realizadas= new List<Tarea>();
        int CantidadDeTareas=new Random().Next(1,5);
        CrearTareas(pendientes,CantidadDeTareas);
        MostrarTareas(pendientes);
        ControlDeTareas(pendientes,realizadas,CantidadDeTareas);
        // MostrarTareas(pendientes);
        MostrarTareasRealizadas(realizadas);
        BuscarTarea(pendientes);


    }
        private static void CrearTareas(List<Tarea> tareas, int CantidadDeTareas)
        {
            for (int i = 0; i < CantidadDeTareas; i++)
            {
                var TareaX= new Tarea(i, "Hola "+i, i*2);
                tareas.Add(TareaX);
            }
        }
   
    private static void MostrarTareas(List<Tarea> tareas)
    {
        foreach (Tarea TareaX in tareas)
        {
            Console.WriteLine("\t---Tarea " +(TareaX.TareaID+1)+ "-----");
            Console.WriteLine("Descripcion: "+TareaX.Descripcion);
            Console.WriteLine("Duracion: " +TareaX.Duracion+"\n");
        }
    }

    public static void ControlDeTareas(List<Tarea> realizadas, List<Tarea> pendientes,int CantidadDeTareas)
    {

        int numTrealizadas = 0;
        foreach (Tarea tarea in pendientes)
        {
            Console.WriteLine("Se realizo la tarea # ? (Si(1)/No(0))");
            int respuesta = Convert.ToInt32(Console.ReadLine());
            if (respuesta == 1)
            {
                realizadas.Add(tarea);
            }
            numTrealizadas++;
        }
        foreach (Tarea tarea in realizadas)
        {
            pendientes.Remove(tarea);
        }

    }

    public static void MostrarTareasRealizadas(List<Tarea> tareas)
    {
        foreach (Tarea TareaX in tareas)
        {
            Console.WriteLine("\t---Tareas Realizadas -----\n");
            Console.WriteLine("\t---Tarea " +(TareaX.TareaID+1)+ "-----");
            Console.WriteLine("Descripcion: "+TareaX.Descripcion);
            Console.WriteLine("Duracion: " +TareaX.Duracion+"\n");
        }
    }
     private static void BuscarTarea(List<Tarea> tareita)
    {
        string? descripcionbuscada;
        Console.WriteLine("Ingrese la descripcion de la tarea que desea buscar: ");
        descripcionbuscada = Console.ReadLine();
        int a = 0;

        foreach (var tar in tareita)
        {
            if (tar.Descripcion.Contains(descripcionbuscada))
            {
                a = 1;
                Console.WriteLine("Tarea encontrada!!!!!");
                Console.WriteLine("Tarea ID: " + tar.TareaID);
                Console.WriteLine("Descripcion: " + tar.Descripcion);
                Console.WriteLine("Duracion: " + tar.Duracion);
            }
            
        }

        if (a == 0)
        {
            Console.WriteLine("No se encontro la tarea");
        }
    }

      private static void GuardarArchivo(List<Tarea> tareita)
    {
        int suma = 0;
        string? ruta = @"F:\tercerAño\TallerDeLenguajeI\tp8\tl1_tp8_2023-Unagui19";

        foreach (var tar in tareita)
        {
            suma += tar.Duracion;
        }

        StreamWriter sw = new StreamWriter(ruta + "cantidad de horas trabajadas", true);
        sw.WriteLine("Horas trabajadas: " + suma);
        sw.Close();
    }


}

