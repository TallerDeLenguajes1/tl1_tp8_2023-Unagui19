internal partial class Program
{
    const int CantidadDeTareas=10;
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
        CrearTareas(pendientes);
        MostrarTareas(pendientes);
        string? ingreso;

        for (int i = 0; i < CantidadDeTareas; i++)
        {
            Console.WriteLine("La tarea "+pendientes[i].TareaID +" fue realizada?");
            Console.WriteLine("0-SI\t 1-NO");
            ingreso=Console.ReadLine();
            int numero;
            bool exito = int.TryParse(ingreso, out numero);
            while (!exito && numero!=1 && numero!=2)
            {
                Console.WriteLine("Valor invalido, intente otra vez\n");
                Console.WriteLine("La tarea "+pendientes[i].TareaID +" fue realizada?");
                Console.WriteLine("0-SI\t 1-NO");
            
            }

            if (numero==0)
            {
                var tarea = pendientes[i];
                realizadas.Add(tarea);
            }
        }

        foreach (var tareita in realizadas)
        {
            pendientes.Remove(tareitas);
        }

    }
    private static void CrearTareas(List<Tarea> tareas)
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

    public enum Estado 
    {
        Pendiete = 0,   
        Completada = 1
    }
    
}

