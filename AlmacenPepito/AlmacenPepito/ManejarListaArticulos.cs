/*
 * Created by SharpDevelop.
 * User: franco
 * Date: 25/6/2017
 * Time: 18:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace AlmacenPepito
{
	/// <summary>
	/// Description of ManejarListaArticulos.
	/// </summary>
	public class ManejarListaArticulos
	{
		List<Articulo> articulos;
		public ManejarListaArticulos()
		{
			articulos = new List<Articulo>();
		}
		
		public void agregarArticulo(Articulo art){
			int cod = buscarArticulo(art.Codigo);
			if(cod == -1){
				articulos.Add(art);
			}else{
				Console.WriteLine("ya existe un artículo con el código ingresado");
				Console.ReadKey(true);
			}
		}
		
		public void todosLosArticulos(){
			if (articulos.Count==0)
				Console.WriteLine("Lista vacía");
			else
				foreach(Articulo item in articulos){
				item.mostrar_estado();
			}
		}
		
		private int buscarArticulo(int codigo){
			int i = 0;
			bool encontrado = false;
			
			while((i<articulos.Count) && (!encontrado)){
				if(articulos[i].Codigo == codigo){
					encontrado = true;
				}else{
					i++;
				}
			}
			if(!encontrado){
				i = -1;
			}
			return i;
			
		}
		
		public void eliminarArticulo(int codigo){
			int cod = buscarArticulo(codigo);
			if (cod > -1){
				articulos.Remove(articulos[cod]);
			}else{
				Console.WriteLine("No existe el artículo para eliminar");
				Console.ReadKey(true);
			}
		}
		
		public void modificarArticulo(Articulo art){
			int cod = buscarArticulo(art.Codigo);
			
			if(cod > -1){
				articulos[cod] = art;
			}else{
				Console.WriteLine("No existe el artículo que desea modificar");
				Console.ReadKey(true);
			}
		}
	}
}
