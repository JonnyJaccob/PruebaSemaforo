using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaSemaforo
{
	public partial class FomularioSecundario : Form
	{
		public FomularioSecundario()
		{
			InitializeComponent();
		}

		private void FomularioSecundario_Load(object sender, EventArgs e)
		{

		}
		public int verde1 { get; set; }
		public int verde2 { get; set; }
		public int ambar { get; set; }
		public int rojo { get; set; }

		private void FormularioSecundario_FormClosing(object sender, FormClosingEventArgs e)
		{
			int valor1, valor2, valor3, valor4;
			if (int.TryParse(txtVerde1.Text, out valor1) &&
				int.TryParse(txtVerde2.Text, out valor2) &&
				int.TryParse(txtAmbar.Text, out valor3) &&
				int.TryParse(txtRojo.Text, out valor4))
			{
				verde1 = valor1;
				verde2 = valor2;
				ambar = valor3;
				rojo = valor4;
			}
		}

		private void btnSeleccionar_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}
	}
}
