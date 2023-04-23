using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaSemaforo
{
	public class Semaforo
	{
		public Semaforo()
		{
			FaseFijoVerde = 5;
			FaseParpadeoVerde = 3;
			FijoAmarillo = 3;
			FijoRojo = 2;
			blnNorte_Sur = true;
			blnEste_Oeste = false;
			Fase = 1;
		}
		public Semaforo(int x,int y, int z, int w)
		{
			FaseFijoVerde = x;
			FaseParpadeoVerde = y;
			FijoAmarillo = z;
			FijoRojo = w;
			blnNorte_Sur = true;
			blnEste_Oeste = false;
			Fase = 1;
		}
		private static int FaseFijoVerde;
		private static int FaseParpadeoVerde;
		private static int FijoAmarillo;
		private static int FijoRojo;
		public bool blnNorte_Sur;
		public bool blnEste_Oeste;
		public int Fase;
		public Color colorLetrero = Color.Green;

		public int CicloSemaforo(double Contador)
		{
			switch (Fase)
			{
				case 1: // verde
					if (Contador < FaseFijoVerde+0.5)
					{
						colorLetrero = Color.Green;
					}
					else
					{
						Fase = 2;
						Contador = 1;
					}
					break;

				case 2: // parpadeo verde
					if (Contador < FaseParpadeoVerde+0.5)
					{
						if (Contador % 2 == 0)
						{
							colorLetrero = Color.Green;
						}
						else
						{
							
							if (Math.Floor(Contador) == Contador)
							{
								colorLetrero = Color.Green;
							}
							else
							{
								colorLetrero = Color.Gray;
							}
						}
					}
					else
					{
						Fase = 3;
						colorLetrero = Color.Yellow;
						Contador = 1;
					}
					break;

				case 3: // amarillo
					if (Contador < FijoAmarillo+0.5)
					{
						colorLetrero = Color.Yellow;
					}
					else
					{
						Fase = 4;
						colorLetrero = Color.Red;
						Contador = 1;
					}
					break;

				case 4: // rojo
					if (Contador < FijoRojo+0.5)
					{
						colorLetrero = Color.Red;
					}
					else
					{
						Fase = 1;
						colorLetrero = Color.Green;
						Contador = 1;
						if (blnNorte_Sur)
						{
							blnNorte_Sur = false;
							blnEste_Oeste = true;
						}
						else
						{
							blnEste_Oeste = false;
							blnNorte_Sur = true;
						}
					}
					break;
			}
			return (int)Contador;
		}

		public int SemaforoTiempo(double numero)
		{
			switch (numero)
			{
				case 1 when Fase == 1:
				case 1.5 when Fase == 1:
				case 2 when Fase == 1:
				case 2.5 when Fase == 1:
				case 3 when Fase == 1:
				case 3.5 when Fase == 1:
				case 4 when Fase == 1:
				case 4.5 when Fase == 1:
				case 5 when Fase == 1:
				case 5.5 when Fase == 1:
				case 6 when Fase == 1:
				case 6.5 when Fase == 1:
				case 7 when Fase == 1:
				case 7.5 when Fase == 1:
				case 8 when Fase == 1:
				case 8.5 when Fase == 1:
				case 9 when Fase == 1:
				case 9.5 when Fase == 1:
				case 10 when Fase == 1:
				case 10.5 when Fase == 1:
				case 11 when Fase == 1:
				case 11.5 when Fase == 1:
				case 12 when Fase == 1:
				case 12.5 when Fase == 1:
				case 13 when Fase == 1:
				case 13.5 when Fase == 1:
				case 14 when Fase == 1:
				case 14.5 when Fase == 1:
				case 15 when Fase == 1:
				case 15.5 when Fase == 1:
				case 15.5 when Fase == 1:
				case 16 when Fase == 1:
				case 16.5 when Fase == 1:
				case 17 when Fase == 1:
					colorLetrero = Color.Green;
					break;
				case 17.5 when Fase == 1:
					Fase = 2;
					numero = 1;
					colorLetrero = Color.Green;
					break;
				
				case 1.5 when Fase == 2:
				case 2.5 when Fase == 2:
					colorLetrero = Color.Gray;
					break;
				case 2 when Fase == 2:
				case 1 when Fase == 2:
				case 3 when Fase == 2:
					colorLetrero = Color.Green;
					break;
				case 3.5 when Fase == 2:
					Fase = 3;
					numero = 1;
					colorLetrero = Color.Yellow;
					break;
				case 1 when Fase == 3:
				case 1.5 when Fase == 3:
				case 2 when Fase == 3:
				case 2.5 when Fase == 3:
				case 3 when Fase == 3:
					colorLetrero = Color.Yellow;
					break;
				case 3.5 when Fase == 3:
					colorLetrero = Color.Red;
					Fase = 4;
					numero = 1;
					break;
				case 1 when Fase == 4:
				case 1.5 when Fase == 4:
				case 2 when Fase == 4:
					colorLetrero = Color.Red;
					break;
				case 2.5 when Fase == 4:
					colorLetrero = Color.Green;
					Fase = 1;
					numero = 1;
					if(blnNorte_Sur)
					{
						blnNorte_Sur = false;
						blnEste_Oeste = true;
					}
					else
					{
						blnEste_Oeste = false;
						blnNorte_Sur = true;
					}
					break;
				default:
					throw new Exception("Ocurrio algo inesperado");
			}
			return (int)numero;
		}
	}
}
