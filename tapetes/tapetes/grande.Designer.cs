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
	partial class grande
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
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.btncosto = new System.Windows.Forms.Button();
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.txtcalcula = new System.Windows.Forms.Button();
			this.label13 = new System.Windows.Forms.Label();
			this.lbltotal = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.txtarea = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnregresa
			// 
			this.btnregresa.Location = new System.Drawing.Point(415, 243);
			this.btnregresa.Name = "btnregresa";
			this.btnregresa.Size = new System.Drawing.Size(15, 23);
			this.btnregresa.TabIndex = 0;
			this.btnregresa.Text = "<";
			this.btnregresa.UseVisualStyleBackColor = true;
			this.btnregresa.Click += new System.EventHandler(this.BtnregresaClick);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(-68, 106);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 33);
			this.label4.TabIndex = 21;
			this.label4.Text = "numero de presonas";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(151, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 23);
			this.label1.TabIndex = 18;
			this.label1.Text = "tapete grande";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(293, 9);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(122, 23);
			this.label11.TabIndex = 36;
			this.label11.Text = "tamaño de 2 a 4 metros";
			// 
			// btncosto
			// 
			this.btncosto.Location = new System.Drawing.Point(9, 243);
			this.btncosto.Name = "btncosto";
			this.btncosto.Size = new System.Drawing.Size(75, 23);
			this.btncosto.TabIndex = 37;
			this.btncosto.Text = "costo";
			this.btncosto.UseVisualStyleBackColor = true;
			this.btncosto.Click += new System.EventHandler(this.BtncostoClick);
			// 
			// txtagua
			// 
			this.txtagua.Location = new System.Drawing.Point(330, 167);
			this.txtagua.Name = "txtagua";
			this.txtagua.Size = new System.Drawing.Size(100, 20);
			this.txtagua.TabIndex = 57;
			this.txtagua.TextChanged += new System.EventHandler(this.TxtaguaTextChanged);
			// 
			// txtcomida
			// 
			this.txtcomida.Location = new System.Drawing.Point(330, 129);
			this.txtcomida.Name = "txtcomida";
			this.txtcomida.Size = new System.Drawing.Size(100, 20);
			this.txtcomida.TabIndex = 56;
			this.txtcomida.TextChanged += new System.EventHandler(this.TxtcomidaTextChanged);
			// 
			// txtpintura
			// 
			this.txtpintura.Location = new System.Drawing.Point(330, 81);
			this.txtpintura.Name = "txtpintura";
			this.txtpintura.Size = new System.Drawing.Size(100, 20);
			this.txtpintura.TabIndex = 55;
			this.txtpintura.TextChanged += new System.EventHandler(this.TxtpinturaTextChanged);
			// 
			// txtsserrin
			// 
			this.txtsserrin.Location = new System.Drawing.Point(330, 38);
			this.txtsserrin.Name = "txtsserrin";
			this.txtsserrin.Size = new System.Drawing.Size(100, 20);
			this.txtsserrin.TabIndex = 54;
			this.txtsserrin.TextChanged += new System.EventHandler(this.TxtsserrinTextChanged);
			// 
			// frutos
			// 
			this.frutos.Location = new System.Drawing.Point(112, 167);
			this.frutos.Name = "frutos";
			this.frutos.Size = new System.Drawing.Size(100, 20);
			this.frutos.TabIndex = 53;
			this.frutos.TextChanged += new System.EventHandler(this.FrutosTextChanged);
			// 
			// txtflores
			// 
			this.txtflores.Location = new System.Drawing.Point(112, 129);
			this.txtflores.Name = "txtflores";
			this.txtflores.Size = new System.Drawing.Size(100, 20);
			this.txtflores.TabIndex = 52;
			this.txtflores.TextChanged += new System.EventHandler(this.TxtfloresTextChanged);
			// 
			// txtpresonas
			// 
			this.txtpresonas.Location = new System.Drawing.Point(112, 84);
			this.txtpresonas.Name = "txtpresonas";
			this.txtpresonas.Size = new System.Drawing.Size(100, 20);
			this.txtpresonas.TabIndex = 51;
			this.txtpresonas.TextChanged += new System.EventHandler(this.TxtpresonasTextChanged);
			// 
			// txthoras
			// 
			this.txthoras.Location = new System.Drawing.Point(112, 35);
			this.txthoras.Name = "txthoras";
			this.txthoras.Size = new System.Drawing.Size(100, 20);
			this.txthoras.TabIndex = 50;
			this.txthoras.TextChanged += new System.EventHandler(this.TxthorasTextChanged);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(238, 170);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(86, 23);
			this.label9.TabIndex = 49;
			this.label9.Text = "agua";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(9, 170);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(97, 23);
			this.label8.TabIndex = 48;
			this.label8.Text = "frutos secos kg";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(238, 132);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(86, 23);
			this.label7.TabIndex = 47;
			this.label7.Text = "alimentos";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(238, 84);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(86, 23);
			this.label6.TabIndex = 46;
			this.label6.Text = "pintura";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(9, 132);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(97, 23);
			this.label5.TabIndex = 45;
			this.label5.Text = "flores por decena";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(9, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 33);
			this.label2.TabIndex = 44;
			this.label2.Text = "numero de presonas";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(238, 35);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 23);
			this.label3.TabIndex = 43;
			this.label3.Text = "bultos de aserrin";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(9, 38);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(97, 23);
			this.label10.TabIndex = 42;
			this.label10.Text = "horas de trabajo";
			// 
			// txtcalcula
			// 
			this.txtcalcula.Location = new System.Drawing.Point(194, 263);
			this.txtcalcula.Name = "txtcalcula";
			this.txtcalcula.Size = new System.Drawing.Size(75, 23);
			this.txtcalcula.TabIndex = 60;
			this.txtcalcula.Text = "calcula";
			this.txtcalcula.UseVisualStyleBackColor = true;
			this.txtcalcula.Click += new System.EventHandler(this.TxtcalculaClick);
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(238, 211);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(86, 23);
			this.label13.TabIndex = 61;
			this.label13.Text = "total";
			// 
			// lbltotal
			// 
			this.lbltotal.Location = new System.Drawing.Point(330, 208);
			this.lbltotal.Name = "lbltotal";
			this.lbltotal.Size = new System.Drawing.Size(100, 23);
			this.lbltotal.TabIndex = 62;
			this.lbltotal.Text = ". . .";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(9, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(114, 32);
			this.label12.TabIndex = 67;
			this.label12.Text = "numeros de presonas: 10-18";
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(19, 211);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(87, 23);
			this.label14.TabIndex = 68;
			this.label14.Text = "tamaño";
			// 
			// txtarea
			// 
			this.txtarea.Location = new System.Drawing.Point(112, 205);
			this.txtarea.Name = "txtarea";
			this.txtarea.Size = new System.Drawing.Size(100, 20);
			this.txtarea.TabIndex = 69;
 
			// 
			// grande
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(439, 307);
			this.Controls.Add(this.txtarea);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.lbltotal);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.txtcalcula);
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
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.btncosto);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnregresa);
			this.Name = "grande";
			this.Text = "grande";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtarea;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label lbltotal;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button txtcalcula;
		private System.Windows.Forms.TextBox txthoras;
		private System.Windows.Forms.TextBox txtpresonas;
		private System.Windows.Forms.TextBox txtflores;
		private System.Windows.Forms.TextBox frutos;
		private System.Windows.Forms.TextBox txtsserrin;
		private System.Windows.Forms.TextBox txtpintura;
		private System.Windows.Forms.TextBox txtcomida;
		private System.Windows.Forms.TextBox txtagua;
		private System.Windows.Forms.Button btncosto;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btnregresa;
	}
}
