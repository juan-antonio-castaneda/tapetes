/*
 * Created by SharpDevelop.
 * User: CC2_PC9
 * Date: 20/11/2024
 * Time: 07:26 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace tapetes
{
	partial class pequeño
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnregresa = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.btncosto = new System.Windows.Forms.Button();
			this.txttamaño = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtagua = new System.Windows.Forms.TextBox();
			this.txtcomida = new System.Windows.Forms.TextBox();
			this.txtpintura = new System.Windows.Forms.TextBox();
			this.txtsserrin = new System.Windows.Forms.TextBox();
			this.frutos = new System.Windows.Forms.TextBox();
			this.txtflores = new System.Windows.Forms.TextBox();
			this.txtpresonas = new System.Windows.Forms.TextBox();
			this.txthoras = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.txtcalcula = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnregresa
			// 
			this.btnregresa.Location = new System.Drawing.Point(410, 301);
			this.btnregresa.Name = "btnregresa";
			this.btnregresa.Size = new System.Drawing.Size(21, 23);
			this.btnregresa.TabIndex = 0;
			this.btnregresa.Text = "<";
			this.btnregresa.UseVisualStyleBackColor = true;
			this.btnregresa.Click += new System.EventHandler(this.BtnregresaClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(158, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "tapete pequeno";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(292, 9);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(126, 23);
			this.label10.TabIndex = 18;
			this.label10.Text = "tamaño de 0.5 a 1 metro";
			// 
			// btncosto
			// 
			this.btncosto.Location = new System.Drawing.Point(21, 270);
			this.btncosto.Name = "btncosto";
			this.btncosto.Size = new System.Drawing.Size(46, 23);
			this.btncosto.TabIndex = 19;
			this.btncosto.Text = "costo";
			this.btncosto.UseVisualStyleBackColor = true;
			this.btncosto.Click += new System.EventHandler(this.BtncostoClick);
			// 
			// txttamaño
			// 
			this.txttamaño.Location = new System.Drawing.Point(113, 228);
			this.txttamaño.Name = "txttamaño";
			this.txttamaño.Size = new System.Drawing.Size(100, 20);
			this.txttamaño.TabIndex = 59;
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(9, 226);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(100, 23);
			this.label12.TabIndex = 58;
			this.label12.Text = "tamaño";
			// 
			// txtagua
			// 
			this.txtagua.Location = new System.Drawing.Point(331, 187);
			this.txtagua.Name = "txtagua";
			this.txtagua.Size = new System.Drawing.Size(100, 20);
			this.txtagua.TabIndex = 57;
			// 
			// txtcomida
			// 
			this.txtcomida.Location = new System.Drawing.Point(331, 149);
			this.txtcomida.Name = "txtcomida";
			this.txtcomida.Size = new System.Drawing.Size(100, 20);
			this.txtcomida.TabIndex = 56;
			// 
			// txtpintura
			// 
			this.txtpintura.Location = new System.Drawing.Point(331, 101);
			this.txtpintura.Name = "txtpintura";
			this.txtpintura.Size = new System.Drawing.Size(100, 20);
			this.txtpintura.TabIndex = 55;
			// 
			// txtsserrin
			// 
			this.txtsserrin.Location = new System.Drawing.Point(331, 58);
			this.txtsserrin.Name = "txtsserrin";
			this.txtsserrin.Size = new System.Drawing.Size(100, 20);
			this.txtsserrin.TabIndex = 54;
			// 
			// frutos
			// 
			this.frutos.Location = new System.Drawing.Point(113, 187);
			this.frutos.Name = "frutos";
			this.frutos.Size = new System.Drawing.Size(100, 20);
			this.frutos.TabIndex = 53;
			// 
			// txtflores
			// 
			this.txtflores.Location = new System.Drawing.Point(113, 149);
			this.txtflores.Name = "txtflores";
			this.txtflores.Size = new System.Drawing.Size(100, 20);
			this.txtflores.TabIndex = 52;
			// 
			// txtpresonas
			// 
			this.txtpresonas.Location = new System.Drawing.Point(113, 104);
			this.txtpresonas.Name = "txtpresonas";
			this.txtpresonas.Size = new System.Drawing.Size(100, 20);
			this.txtpresonas.TabIndex = 51;
			// 
			// txthoras
			// 
			this.txthoras.Location = new System.Drawing.Point(113, 55);
			this.txthoras.Name = "txthoras";
			this.txthoras.Size = new System.Drawing.Size(100, 20);
			this.txthoras.TabIndex = 50;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(239, 190);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(86, 23);
			this.label9.TabIndex = 49;
			this.label9.Text = "agua";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(10, 190);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(97, 23);
			this.label8.TabIndex = 48;
			this.label8.Text = "frutos secos kg";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(239, 152);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(86, 23);
			this.label7.TabIndex = 47;
			this.label7.Text = "alimentos";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(239, 104);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(86, 23);
			this.label6.TabIndex = 46;
			this.label6.Text = "pintura";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(10, 152);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(97, 23);
			this.label5.TabIndex = 45;
			this.label5.Text = "flores por decena";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(10, 91);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 33);
			this.label4.TabIndex = 44;
			this.label4.Text = "numero de presonas";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(239, 55);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 23);
			this.label3.TabIndex = 43;
			this.label3.Text = "bultos de aserrin";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(10, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 23);
			this.label2.TabIndex = 42;
			this.label2.Text = "horas de trabajo";
			// 
			// textBox1
			// 
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(331, 228);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 65;
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(239, 231);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(86, 23);
			this.label13.TabIndex = 64;
			this.label13.Text = "total";
			// 
			// txtcalcula
			// 
			this.txtcalcula.Location = new System.Drawing.Point(195, 289);
			this.txtcalcula.Name = "txtcalcula";
			this.txtcalcula.Size = new System.Drawing.Size(75, 23);
			this.txtcalcula.TabIndex = 63;
			this.txtcalcula.Text = "calcula";
			this.txtcalcula.UseVisualStyleBackColor = true;
			// 
			// pequeño
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(441, 336);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.txtcalcula);
			this.Controls.Add(this.txttamaño);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.txtagua);
			this.Controls.Add(this.txtcomida);
			this.Controls.Add(this.txtpintura);
			this.Controls.Add(this.txtsserrin);
			this.Controls.Add(this.frutos);
			this.Controls.Add(this.txtflores);
			this.Controls.Add(this.txtpresonas);
			this.Controls.Add(this.txthoras);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btncosto);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnregresa);
			this.Name = "pequeño";
			this.Text = "pequeño";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button txtcalcula;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox txthoras;
		private System.Windows.Forms.TextBox txtpresonas;
		private System.Windows.Forms.TextBox txtflores;
		private System.Windows.Forms.TextBox frutos;
		private System.Windows.Forms.TextBox txtsserrin;
		private System.Windows.Forms.TextBox txtpintura;
		private System.Windows.Forms.TextBox txtcomida;
		private System.Windows.Forms.TextBox txtagua;
		private System.Windows.Forms.TextBox txttamaño;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button btncosto;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnregresa;
	}
}
