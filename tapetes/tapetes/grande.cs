/*
 * Created by SharpDevelop.
 * User: CC2_PC9
 * Date: 20/11/2024
 * Time: 07:26 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace tapetes
{
	/// <summary>
	/// Description of grande.
	/// </summary>
	public partial class grande : Form
	{
		string s;
		double h ;
		double j,f,p,g,w,q,a;
		public grande()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnregresaClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void BtncostoClick(object sender, EventArgs e)
		{
			materiales materiales = new materiales();
			materiales.Show();
		}
		
		void TxthorasTextChanged(object sender, EventArgs e)
		{
			s = txthoras.Text;
			h = Int32.Parse(s);
			h *= 100;
			
		}
				
		void TxtcalculaClick(object sender, EventArgs e)
		{
			h += j + h + f + p + g + w + q + a;
			lbltotal.Text = h.ToString();
		}
		
		void TxtpresonasTextChanged(object sender, EventArgs e)
		{
			string s1 = txthoras.Text;
			j = Int32.Parse(s1);
			j *= 150;
		}
		
		void TxtfloresTextChanged(object sender, EventArgs e)
		{
			string s1 = txthoras.Text;
			f = Int32.Parse(s1);
			f *= 30;
		}
		
		void FrutosTextChanged(object sender, EventArgs e)
		{
			string s1 = txthoras.Text;
			p = Int32.Parse(s1);
			p *= 80;
		}
		
		
		void TxtsserrinTextChanged(object sender, EventArgs e)
		{
			string s1 = txthoras.Text;
			g = Int32.Parse(s1);
			g *= 80;
		}
		
		void TxtpinturaTextChanged(object sender, EventArgs e)
		{
			string s1 = txthoras.Text;
			w = Int32.Parse(s1);
			w *= 150;
		}
		
		void TxtcomidaTextChanged(object sender, EventArgs e)
		{
			string s1 = txthoras.Text;
			q = Int32.Parse(s1);
			q *= 50;
		}
		
		void TxtaguaTextChanged(object sender, EventArgs e)
		{
			string s1 = txthoras.Text;
			a = Int32.Parse(s1);
			a *= 1;
		}
	}
}
