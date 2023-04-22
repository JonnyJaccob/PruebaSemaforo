using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaSemaforo
{
	public class Semaforo
	{
		public Semaforo()
		{
			FaseFijoVerde = 17;
			FaseParpadeoVerde = 3;
			FijoAmarillo = 3;
			FijoRojo = 2;
			blnNorte_Sur = true;
			blnEste_Oeste = false;
			Fase = 1;
		}
		public static int FaseFijoVerde;
		public static int FaseParpadeoVerde;
		public static int FijoAmarillo;
		public static int FijoRojo;
		public bool blnNorte_Sur;
		public bool blnEste_Oeste;
		public int Fase;
	}
}
