// namespace EspacioTareas
// {    
    
//     public class ListaTareas
//     {
//         const int CantidadDeTareas=10;
//         public void CrearTareas(List<Tarea> tareas)
//             {
//                 for (int i = 0; i < CantidadDeTareas; i++)
//                 {
//                     var TareaX= new Tarea(i, "Hola "+i, i*2);
//                     tareas.Add(TareaX);
//                 }
//             }
    
//         public void MostrarTareas(List<Tarea> tareas)
//         {
//             foreach (Tarea TareaX in tareas)
//             {
//                 Console.WriteLine("\t---Tarea " +(TareaX.TareaID+1)+ "-----");
//                 Console.WriteLine("Descripcion: "+TareaX.Descripcion);
//                 Console.WriteLine("Duracion: " +TareaX.Duracion+"\n");
//             }
//         }

//         public void ControlDeTareas(List<Tarea> realizadas, List<Tarea> pendientes)
//         {
//             for (int i = 0; i < CantidadDeTareas; i++)
//             {
//                 Console.WriteLine("La tarea "+realizadas[i].TareaID +" fue realizada?");
//                 Console.WriteLine("0-SI\t 1-NO");
//                 string? ingreso=Console.ReadLine();
//                 int numero;
//                 bool exito = int.TryParse(ingreso, out numero);
//                 while (!exito && numero!=1 && numero!=2)
//                 {
//                     Console.WriteLine("Valor invalido, intente otra vez\n");
//                     Console.WriteLine("La tarea "+pendientes[i].TareaID +" fue realizada?");
//                     Console.WriteLine("0-SI\t 1-NO");
                
//                 }

//                 if (numero==0)
//                 {
//                     var tarea = pendientes[i];
//                     realizadas.Add(tarea);
//                 }
//             }

//             foreach (var tareita in realizadas)
//             {
//                 pendientes.Remove(tareita);
//             }
//         }

//         public void MostrarTareasRealizadas(List<Tarea> tareas)
//         {
//             foreach (Tarea TareaX in tareas)
//             {
//                 Console.WriteLine("\t---Tareas Realizadas -----\n");
//                 Console.WriteLine("\t---Tarea " +(TareaX.TareaID+1)+ "-----");
//                 Console.WriteLine("Descripcion: "+TareaX.Descripcion);
//                 Console.WriteLine("Duracion: " +TareaX.Duracion+"\n");
//             }
//         }
//     }
// }