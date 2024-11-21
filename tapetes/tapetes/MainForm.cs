/*
 * Created by SharpDevelop.
 * User: CC2_PC9
 * Date: 20/11/2024
 * Time: 07:14 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace tapetes
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			pequeño pequeño = new pequeño ();
				pequeño.Show();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			mediano mediano = new mediano();
			mediano.Show();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			grande grande = new grande();
			grande.Show();
		}
		
		void BtnsaliClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
