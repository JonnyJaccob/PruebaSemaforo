namespace PruebaSemaforo
{
	partial class FomularioSecundario
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtVerde1 = new System.Windows.Forms.TextBox();
			this.txtVerde2 = new System.Windows.Forms.TextBox();
			this.txtAmbar = new System.Windows.Forms.TextBox();
			this.txtRojo = new System.Windows.Forms.TextBox();
			this.btnSeleccionar = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtRojo);
			this.groupBox1.Controls.Add(this.txtAmbar);
			this.groupBox1.Controls.Add(this.txtVerde2);
			this.groupBox1.Controls.Add(this.txtVerde1);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(13, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(295, 141);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Datos";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Verde Fijo";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(102, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Verde Parpadeando";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 87);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Ambar Fijo";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(5, 113);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Rojo Fijo";
			// 
			// txtVerde1
			// 
			this.txtVerde1.Location = new System.Drawing.Point(83, 20);
			this.txtVerde1.Name = "txtVerde1";
			this.txtVerde1.Size = new System.Drawing.Size(190, 20);
			this.txtVerde1.TabIndex = 4;
			this.txtVerde1.Text = "17";
			// 
			// txtVerde2
			// 
			this.txtVerde2.Location = new System.Drawing.Point(115, 49);
			this.txtVerde2.Name = "txtVerde2";
			this.txtVerde2.Size = new System.Drawing.Size(158, 20);
			this.txtVerde2.TabIndex = 5;
			this.txtVerde2.Text = "3";
			// 
			// txtAmbar
			// 
			this.txtAmbar.Location = new System.Drawing.Point(83, 84);
			this.txtAmbar.Name = "txtAmbar";
			this.txtAmbar.Size = new System.Drawing.Size(158, 20);
			this.txtAmbar.TabIndex = 6;
			this.txtAmbar.Text = "3";
			// 
			// txtRojo
			// 
			this.txtRojo.Location = new System.Drawing.Point(83, 110);
			this.txtRojo.Name = "txtRojo";
			this.txtRojo.Size = new System.Drawing.Size(158, 20);
			this.txtRojo.TabIndex = 7;
			this.txtRojo.Text = "2";
			// 
			// btnSeleccionar
			// 
			this.btnSeleccionar.Location = new System.Drawing.Point(96, 149);
			this.btnSeleccionar.Name = "btnSeleccionar";
			this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
			this.btnSeleccionar.TabIndex = 1;
			this.btnSeleccionar.Text = "Seleccionar";
			this.btnSeleccionar.UseVisualStyleBackColor = true;
			this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
			// 
			// FomularioSecundario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(332, 180);
			this.Controls.Add(this.btnSeleccionar);
			this.Controls.Add(this.groupBox1);
			this.Name = "FomularioSecundario";
			this.Text = "FomularioSecundario";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormularioSecundario_FormClosing);
			this.Load += new System.EventHandler(this.FomularioSecundario_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtRojo;
		private System.Windows.Forms.TextBox txtAmbar;
		private System.Windows.Forms.TextBox txtVerde2;
		private System.Windows.Forms.TextBox txtVerde1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSeleccionar;
	}
}