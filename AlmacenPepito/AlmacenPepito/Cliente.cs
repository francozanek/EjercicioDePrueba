/*
 * Created by SharpDevelop.
 * User: franco
 * Date: 13/6/2017
 * Time: 19:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 //
 
using System;

namespace AlmacenPepito
{
	/// <summary>
	/// Description of Cliente.
	/// </summary>
	public class Cliente
	{
		private int idCliente;
		private string nombre;
		
		public Cliente(int idCliente, string nombre)
		{
			this.idCliente = idCliente;
			this.nombre = nombre;
		}
		
		public int manejarId{
			get{return idCliente;}
			set{idCliente = value;}
		}
		
		public string manejarNombre{
			get{ return nombre;}
			set{ nombre =value;}
		}
		public  void mostrar_estado(){
			
			Console.WriteLine("Código: {0} nombre {1}", idCliente, nombre);
								
			//Console.Write("Presione cualquier tecla para continuar . . . ");
			//Console.ReadKey(true);
			
			Console.WriteLine();
		}
	}
}
