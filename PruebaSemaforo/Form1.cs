using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Text;

namespace PruebaSemaforo
{
	public partial class Form1 : Form
	{
		[DllImport("gdi32.dll")]

		//Funcion de la DLL externa
		private static extern IntPtr AddFontMemResourceEx(IntPtr pFileView, uint cjSize, IntPtr pvResrved, [In] ref uint pNumFonts);

		public Form1()
		{
			InitializeComponent();
			// Inicializar el temporizador
			timer.Interval = 1000;
			timer.Tick += new EventHandler(Timer_Tick);

			//Cargar fuente personalizada
			Font fuente_DS_DIGI = new Font(CargarFuente(Properties.Resources.DS_DIGI), 27, FontStyle.Regular);
			Font fuente_DS_DIGIB = new Font(CargarFuente(Properties.Resources.DS_DIGIB), 27, FontStyle.Regular);
			Font fuente_DS_DIGII = new Font(CargarFuente(Properties.Resources.DS_DIGII), 27, FontStyle.Regular);
			Font fuente_DS_DIGIT = new Font(CargarFuente(Properties.Resources.DS_DIGIT), 40, FontStyle.Regular);

			lblContador.Font = fuente_DS_DIGIT;
		}
		static Timer timer = new Timer(); // Declarar un temporizador para contar los segundos
		static int segundos = 0; // Declarar la variable para el contador de segundos

		private void btnSalir_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		private void FormatoContador(string valor)
		{
			if(valor.Length > 1)
			{
				lblContador.Text = valor;
			}else
			{
				lblContador.Text = "0" + valor;
			}
		}
		private void Iniciar()
		{
			timer.Start(); // Iniciar el temporizador
			segundos = 0; // Reiniciar el contador de segundos
			FormatoContador("0"); // Actualizar la etiqueta con el valor inicial
		}

		private void btnIniciar_Click(object sender, EventArgs e)
		{
			Iniciar();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// Inicializar el temporizador
			//timer.Interval = 1000;
			//timer.Tick += new EventHandler(Timer_Tick);
		}
		// Función que se ejecuta cada segundo
		private void Timer_Tick(object sender, EventArgs e)
		{
			segundos++; // Incrementar el contador de segundos
			FormatoContador(segundos.ToString()); // Actualizar la etiqueta con el nuevo valor

			// Hacer algo específico cada segundo
			switch (segundos)
			{
				case 1:
					// Código para hacer algo en el segundo 1
					break;
				case 2:
					// Código para hacer algo en el segundo 2
					break;
					// Y así sucesivamente para cada segundo
			}
		}

		private void btnDetener_Click(object sender, EventArgs e)
		{
			timer.Stop(); // Detener el temporizador
		}
		private FontFamily CargarFuente(byte[] fuente)
		{
			FontFamily fuenteNueva;

			//Asignar memoria y copiar bytes
			IntPtr data = Marshal.AllocCoTaskMem(fuente.Length);
			Marshal.Copy(fuente, 0, data, fuente.Length);

			uint cFonts = 0;
			AddFontMemResourceEx(data, (uint)fuente.Length, IntPtr.Zero, ref cFonts);

			PrivateFontCollection fontCollection = new PrivateFontCollection();

			//Pasar fuente a PrivateFontCollection
			fontCollection.AddMemoryFont(data, fuente.Length);

			//Liberar memoria
			Marshal.FreeCoTaskMem(data);

			fuenteNueva = fontCollection.Families[0];

			return fuenteNueva;
		}
	}
}
