/*
 * Created by SharpDevelop.
 * User: DELL
 * Date: 16/12/2023
 * Time: 8:11 am
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HelpDeskPriorityManager
{
	public partial class Start : Form
	{
		public Start()
		{
			InitializeComponent();
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			OpenAdministratorForm(); // Open admin form for specific user
			this.Hide();
			return;
		}
		
		private void OpenAdministratorForm()
		{
		    MainForm adminForm = new MainForm();
		    adminForm.Show();
		}
		
		protected override void OnFormClosing(FormClosingEventArgs e)
	    {
	        base.OnFormClosing(e);
	
	        if (e.CloseReason == CloseReason.UserClosing)
	        {
	            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo);
	
	            if (result == DialogResult.Yes)
	            {
	                Application.Exit();
	            }
	            else
	            {
	                e.Cancel = true; // Cancel the form closing event
	            }
	        }
	    }
	}
}
