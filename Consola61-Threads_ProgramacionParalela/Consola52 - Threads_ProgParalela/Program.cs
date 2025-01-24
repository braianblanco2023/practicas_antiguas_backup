using System;
using System.Threading;
using System.Threading.Tasks;   //Para esto usamos este namespace

//VAMOS A IMPLEMENTAR LA PROGRAMACION PARALELA, ES DECIR, QUE REALIZA TAREAS EN MULTIPLES NUCLEOS DE LA CPU

namespace Consola52___Threads_ProgParalela
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXISTEN TRES MANERAS DE CREAR INSTANCIAS
            Task tarea1 = new Task(new Action(Tarea));      //1- llamando al delegado Action
            Task tarea2 = new Task(delegate                 //2- usando una funcion anonima
            {
                Tarea();
            });
            Task tarea3 = new Task(() => Tarea());          //3- por medio de una expresion Lambda

            tarea1.Start();
            tarea2.Start();
            tarea3.Start();

            //PARA REALIZAR UNA MISMA CARGA DE TRABAJO A UN CONJUNTO DIREFENTE DE DATOS O PASAR PARAMETROS
            //en el caso de parametros a pasar, le indicamos el tipo en action, y su valor como 2do parametro
            Task tarea4 = new Task(new Action<object>(Tarea), "Tarea 4");   //1 -para Action
            //a la funciona anonima le pasamos el tipo de parametro y una variable
            Task tarea5 = new Task(delegate (object objeto)                 //2- para funcion anonima
            {
                Tarea(objeto);      //tambien aqui le pasamos la variable
            }, "Tarea 5");          //seguido de una coma, le pasamos el valor como segundo parametro
            //en la definicion Lambda
            Task tarea6 = new Task((objeto) => Tarea(objeto), "Tarea 6");   //3- para definicion Lambda

            tarea4.Start();
            tarea5.Start();
            tarea6.Start();

            //PARA RECIBIR VALORES RETORNADOS DE UN METODO (CON RETURN), DISPONEMOS DE TASK.RESULT
            //vemos el caso de Lambda
            Task<int> tarea7 = new Task<int>(() => Retorna());      //se le pasa el <tipo> retornado
            tarea7.Start();                                         //lo iniciamos
            Console.WriteLine("El retorno es {0}", tarea7.Result);  //y tomamos el retorno con Result

            //AHORA VAMOS A DEFINIR UNA TAREA QUE SE PUEDE CANCELAR (ej: por el usuario), USANDO UN TOKEN  
            Task tarea8 = new Task(() => puedeCancelarse(), token); //se le pasa un token como 2do parametro
            //este token tiene el nombre "token" porque se lo dimos así (no es arbitrario), abajo de todo...
            tarea8.Start();
            //Ahora vamos a dar aviso de que se puede cancelar con una tecla
            Console.WriteLine("Presione una tecla para CANCELAR la tarea de iteracion: ");
            Console.ReadKey();              //esperando cualquier tecla
            cancelar.Cancel();              //cancelamos
            Console.ReadKey();              //esto al final para que se muestre el WriteLine antes de salir
        }
        //los metodos para las tareas
        static void Tarea()                                             //metodo normal
        {
            Console.WriteLine("Una Tarea");
        }
        static void Tarea(object mensaje)                               //metodo con parametros
        {
            Console.WriteLine("Tarea con Parametros {0}", mensaje);
        }
        static int Retorna()                                            //metodo con retorno
        {
            int resultado = 10;
            return resultado;
        }
        static void puedeCancelarse()                                   //metodo que puede cancelarse
        {
            for (int i = 1; i<100; i++)
            {
                Console.WriteLine(i);
                //para que sea mas lento
                Thread.Sleep(500); 
                if (token.IsCancellationRequested)                      //consulta si es cancelado, entonces:
                {
                    Console.WriteLine("Tarea Cancelada");
                    return;                                             //retorna true en la cancelacion
                }
            }
        }
        //DEBEMOS CREAR EL TOKEN PARA DISPONER DE LA CANCELACION
        //lo establecimos static para acceder a el desde Main y fuera de Main (en otro metodo Tarea)
        static CancellationTokenSource cancelar = new CancellationTokenSource();
        static CancellationToken token = cancelar.Token;                     //creamos el token
    }
}
