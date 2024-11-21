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
	/// Description of pequeño.
	/// </summary>
	public partial class pequeño : Form
	{
		public pequeño()
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
	}
}
