/*
 * Created by SharpDevelop.
 * User: franco
 * Date: 1/6/2017
 * Time: 19:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace AlmacenPepito
{
	class Program
	{
		public static void Main(string[] args)
		{
			/*
 			Articulo art=new Articulo(0,"A",20,5,2,(float) 12.3,1);
			Articulo art1=new Articulo(1,"A",20,5,2,(float) 12.3,1);
			Articulo art2=new Articulo(2,"A",20,5,2,(float) 12.3,1);
			Articulo art3=new Articulo(3,"A",20,5,2,(float) 12.3,1);
			Articulo art4=new Articulo(4,"A",20,5,2,(float) 12.3,1);
			
			ManejarListaArticulos listaArt = new ManejarListaArticulos();
			
			listaArt.agregarArticulo(art);
			listaArt.agregarArticulo(art1);
			listaArt.agregarArticulo(art2);
			listaArt.agregarArticulo(art3);
			listaArt.agregarArticulo(art4);
			
			Console.WriteLine("Lista de artículos");
			
			listaArt.todosLosArticulos();
			
			Console.WriteLine("_______");
			
			Console.WriteLine("Lista sin art 2");
			listaArt.eliminarArticulo(2);
			
			listaArt.todosLosArticulos();
			
			art1.Nombre = "b";
			
			listaArt.modificarArticulo(art1);
			
			Console.WriteLine("--Modifica un art");
			
			listaArt.todosLosArticulos();
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
			*/
			ManejarListaArticulos listaArt = new ManejarListaArticulos();
			Articulo art;
			int valor;
			do {
				Console.WriteLine("1- agregar artículo");
				Console.WriteLine("2- eliminar artículo");
				Console.WriteLine("3- modificar artículo");
				Console.WriteLine("4- mostrar lista de artículos");
				Console.WriteLine("0- SALIR");
				Console.Write("Ingrese opción");
				valor=Convert.ToInt32(Console.ReadLine());
				switch(valor){
						case 1: {art=carga_art(); listaArt.agregarArticulo(art); break;}
						case 2: elimina_art(listaArt); break;
						case 4: listaArt.todosLosArticulos();break;
				}
				Console.Write("Presione cualquier tecla para continuar . . . ");
				Console.ReadKey(true);
				Console.Clear();
			}while (valor != 0);
		}//fin main
		
		static Articulo carga_art(){
		int cod;
		string nomb;
		int sM;
		int sR;
		int ptoP;
		float precio;
		int idProveed=0;

				
		
		Console.Write("Código: ");
		cod=Int32.Parse(Console.ReadLine());
		Console.Write("Nombre: ");
		nomb=Console.ReadLine();
		Console.Write("Stock Máx: ");
		sM=Int32.Parse(Console.ReadLine());
		Console.Write("Stock Real: ");
		sR=Int32.Parse(Console.ReadLine());
		Console.Write("Punto de pedido: ");
		ptoP=Int32.Parse(Console.ReadLine());
		Console.Write("Precio unitario: ");
		precio=float.Parse(Console.ReadLine());
		Articulo art=new Articulo(cod,nomb,sM,sR,ptoP,precio,idProveed);
		return art;
		}
		
		static void elimina_art(ManejarListaArticulos lista){
			int cod;
			Console.Write("Código: ");
		cod=Int32.Parse(Console.ReadLine());
		lista.eliminarArticulo(cod);
		}
		
		}//fin clase
}