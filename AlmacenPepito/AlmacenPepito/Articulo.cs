/*
 * Created by SharpDevelop.
 * User: Marcela López
 * Date: 15/6/2017
 * Time: 18:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace AlmacenPepito
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class Articulo
	{
		private int codigo;
		private string nombre;
		private int stockM;
		private int stockR;
		private int puntoPedido;
		private float precio;
		private int idProveed;
				
		public Articulo(int cod, string nom, int sM, int sR, int pP, float pre, int idP)
		{
			this.codigo=cod;
			this.nombre=nom;
			this.stockM=sM;
			this.stockR=sR;
			this.puntoPedido=pP;
			this.precio=pre;
			this.idProveed=idP;
		}
		
		public int Codigo{
			get{return codigo;}
		}
		
		public string Nombre{
			get{return nombre;}
			set{nombre = value;}
		}
		public float Precio{
			get{return precio;}
			set{precio=value;}
		}
		public int StockReal{
			get{return stockR;}
		}
		
		public void cambiar_stock_M(int sm, int pp){
			this.stockM=sm;
			this.puntoPedido=pp;
		}
		
		public  void mostrar_estado(){
			
			Console.WriteLine("Código: {0} nombre {1} precio {2} cantidad en stock {3}", codigo, nombre, precio, stockR);
								
			//Console.Write("Presione cualquier tecla para continuar . . . ");
			//Console.ReadKey(true);
			
			Console.WriteLine();
		}
		
		public void actualiza_stock(int cant){
			stockR+=cant;
		}
	}
}
