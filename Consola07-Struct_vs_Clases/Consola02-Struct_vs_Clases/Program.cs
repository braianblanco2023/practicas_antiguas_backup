using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola02_Struct_vs_Clases
{
    struct Coordenada
    {
        public int x, y;                    //puede tener propiedades publicas para ser accedidas
        private string posicion;            //o privadas para no ser accesibles desde el objweto de struct
        public Coordenada(int a, int b)     //puede tener constructores
        {
             setCoords(a, b)
            //pero en un constructor todos los valores deben inicializarse
        }
        public string getCoords()             //puede tener getters y setters
        {
            return posicion;
        }
        public void setCoords(int a, int b)
        {
            x = a;
            y = b;
           posicion = y.ToString() + "," + x.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Coordenada miCoord = new Coordenada(5, 8);
            Console.WriteLine("Coordenadas: x: {0}, y: {1}", miCoord.x, miCoord.y);     //acceso directo
            Console.WriteLine("Posicion: " + miCoord.getCoords());                      //uso de get
            miCoord.setCoords(10, 3);                                                   //uso de set
            Console.WriteLine("Posicion ahora: " + miCoord.getCoords());
    	    
	    //ADEMAS DE SER MAS LIGERA QUE UNA CLASE, LA PRINCIPAL DIFERENCIA CON LAS CLASES ES QUE UN OBJETO  
    	    //DE UN STRUCT ES UN TIPO POR VALOR, MIENTRAS QUE EL OBJETO DE CLASE ES UN TIPO POR REFERENCIA            
  	        //Aqui la diferencia al copiar objetos:
	        Boligrafo bol1 = new Boligrafo("Rojo");	//Primero copiamos un objeto de clase en otro
	        Boligrafo bol2 = bol1;
            Coordenada miCoord2 = miCoord;		//Luego copiamos un objeto de struct en otro
            //Ahora cambiamos la propiedad de uno de los objetos y vemos como afecta al segundo
	        bol2.color = "Azul";			//Primero una propiedad del objeto de clase
	        miCoord2.x = 80;				//Luego una propiedad del objeto de struct
	        //Vamos a ver como resulta
	        Console.WriteLine("bol1.color: " + bol1.color);	    //Paso de Rojo a Azul
	        Console.WriteLine("bol2.color: " + bol2.color);	    //Sigue en Azul
	        Console.WriteLine("miCoord1.x: " + miCoord.x);      //Sigue en 10
            Console.WriteLine("miCoord2.x: " + miCoord2.x);	    //Sigue en 80
            /*Estp ocurre ya que se copió no el objeto de la clase bol1 en bol2, sino una referencia
            * y con cambios en el objeto bol2, que referencia a bol1 en memoria, tambien cambia bol1.*/

            Console.ReadKey();
        }
    }
    
    public class Boligrafo
    {
	public string color;
	public Boligrafo(string color)
	{
	    this.color = color;
	}
    }
}
