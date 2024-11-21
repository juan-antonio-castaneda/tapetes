/*
 * Created by SharpDevelop.
 * User: CC2_PC9
 * Date: 20/11/2024
 * Time: 08:11 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace tapetes
{
	partial class materiales
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
			this.btnretun = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnretun
			// 
			this.btnretun.Location = new System.Drawing.Point(255, 171);
			this.btnretun.Name = "btnretun";
			this.btnretun.Size = new System.Drawing.Size(75, 23);
			this.btnretun.TabIndex = 0;
			this.btnretun.Text = "regresa";
			this.btnretun.UseVisualStyleBackColor = true;
			this.btnretun.Click += new System.EventHandler(this.BtnretunClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(23, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(253, 27);
			this.label1.TabIndex = 1;
			this.label1.Text = "Bulto de aserrín (25-50 kg)\t            $50 - $150 MXN";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(307, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(279, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Litro de pintura \t                              $30 - $150 MXN";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(23, 57);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(253, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Frutos secos por kg\t                       $80 - $300 MXN";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(307, 57);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(279, 23);
			this.label4.TabIndex = 4;
			this.label4.Text = "Costo de alimentos por presona              $50 - 150 MXN\r\n";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(23, 93);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(253, 23);
			this.label5.TabIndex = 5;
			this.label5.Text = "Costo del litro de agua             \t$1 - $2.5 MXN";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(307, 93);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(279, 23);
			this.label6.TabIndex = 6;
			this.label6.Text = "Flores por docena                            \t$30 - $150 MXN";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(12, 131);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(264, 21);
			this.label7.TabIndex = 7;
			this.label7.Text = "Costo por hora de diseño\t  $100 - $300 MXN por hora";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(307, 131);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(279, 37);
			this.label8.TabIndex = 8;
			this.label8.Text = "Costo de mano de obra por persona (por día)\t   $150 - $500 MXN por persona";
			// 
			// materiales
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(598, 196);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnretun);
			this.Name = "materiales";
			this.Text = "materiales";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnretun;
	}
}
