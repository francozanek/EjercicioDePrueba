/*
 * Created by SharpDevelop.
 * User: franco
 * Date: 13/6/2017
 * Time: 19:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace AlmacenPepito
{
	/// <summary>
	/// Description of MovimientosHistoricos.
	/// </summary>
	public class MovimientosHistoricos
	{
		private Cliente cliente;
		private DateTime fecha;
		private string tipo;
		private double monto;			
			
		public MovimientosHistoricos(Cliente cliente, DateTime fecha, string tipo, double monto)
		{
			this.cliente = cliente;
			this.fecha = fecha;
			this.tipo = tipo;
			this.monto = monto;
		}
		
		public Cliente manejarCliente{
			get{return cliente;}
			set{cliente = value;}
		}
		
		public double manejarMonto{
			get{return monto;}
			set{monto = value;}
		}
		
		public string manejarTipo{
			set{tipo = value;}
			get{return tipo;}
		}
		
		public DateTime manejarFecha{
			set{fecha = value;}
			get{return fecha;}
		}
		
		
	}
}
