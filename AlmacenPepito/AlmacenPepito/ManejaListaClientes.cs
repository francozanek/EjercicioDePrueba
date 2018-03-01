/*
 * Created by SharpDevelop.
 * User: Franco
 * Date: 23/02/2018
 * Time: 9:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace AlmacenPepito
{
	/// <summary>
	/// Description of ManejaListaClientes.
	/// </summary>
	public class ManejaListaClientes
	{
		List<Cliente> clientes;		
		public ManejaListaClientes()
		{
			clientes = new List<Cliente>();
		}
		
		public void agregarCliente(Cliente cli){
			int cod = buscarCliente(cli.manejarId);
			if(cod == -1){
				clientes.Add(cli);
			}else{
				Console.WriteLine("ya existe un cliente con el código ingresado");
				Console.ReadKey(true);
			}
		}
		
		public void todoslosClientes(){
			if (clientes.Count==0)
				Console.WriteLine("Lista vacía");
			else
				foreach(Cliente item in clientes){
				item.mostrar_estado();
			}
		}
		
		private int buscarCliente(int codigo){
			int i = 0;
			bool encontrado = false;
			
			while((i<clientes.Count) && (!encontrado)){
				if(clientes[i].manejarId == codigo){
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
		
		public void eliminarCliente(int codigo){
			int cod = buscarCliente(codigo);
			if (cod > -1){
				clientes.Remove(clientes[cod]);
			}else{
				Console.WriteLine("No existe el Cliente para eliminar");
				Console.ReadKey(true);
			}
		}
		
		public void modificarCliente(Cliente cli){
			int cod = buscarCliente(cli.manejarId);
			
			if(cod > -1){
				clientes[cod] = cli;
			}else{
				Console.WriteLine("No existe el cliente que desea modificar");
				Console.ReadKey(true);
			}
		}
	}
}
