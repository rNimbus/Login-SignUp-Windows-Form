
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Login_SignUp
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
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		
		void BtnLoginClick(object sender, EventArgs e)
		{
			if (Holder.Password == txtPassword.Text && Holder.Username == txtUserName.Text){
				MessageBox.Show("Welcome");
				Application.Exit();
			}
			else{
				txtUserName.ResetText();
				txtPassword.ResetText();
				if (Holder.Password != txtPassword.Text || Holder.Username != txtUserName.Text){
					MessageBox.Show("Wrong username or password");
				}
				else{
					MessageBox.Show("Not a recognized account");
				}
			
			}
		}
	
		void LlblSignupLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			groupBox1.Visible = true;
			gpbxLogin.Visible =false;
		}
		void TxtEnterPasswordTextChanged(object sender, System.EventArgs e)
		{
			Holder.Password = txtEnterPassword.Text;
		}
		void TxtEnterUsernameTextChanged(object sender, EventArgs e)
		{
			Holder.Username = txtEnterUsername.Text;
		}
		
		
		void SignUPClick(object sender, System.EventArgs e)
		{
			if(txtEnterPassword.Text.Length<8  ){
				txtConfirmPassword.ResetText();
				txtEnterPassword.ResetText();
				MessageBox.Show("Password needs to be 8 to 16 Characters");
			}
			else if(txtEnterUsername.Text.Length<8){
				txtEnterUsername.ResetText();
				MessageBox.Show("Username needs to be 8 to 16 Characters");
			}
			else{
				if(txtConfirmPassword.Text == txtEnterPassword.Text){
					groupBox1.Visible = false;
					gpbxLogin.Visible =true;
				}
				else{
						txtConfirmPassword.ResetText();
				}
			}
		}
		
		
		
		void CbShowPasswordLoginCheckedChanged(object sender, EventArgs e)
		{
			if(txtPassword.UseSystemPasswordChar == false){
				txtPassword.UseSystemPasswordChar = true;
			}
			else{
				txtPassword.UseSystemPasswordChar = false;
			}
		}
		
		void CbShowPassSignupCheckedChanged(object sender, EventArgs e)
		{
			if(txtEnterPassword.UseSystemPasswordChar == false && txtConfirmPassword.UseSystemPasswordChar ==false){
				txtEnterPassword.UseSystemPasswordChar = true; 
				txtConfirmPassword.UseSystemPasswordChar= true;
			}
			else{
				txtEnterPassword.UseSystemPasswordChar = false; 
				txtConfirmPassword.UseSystemPasswordChar= false;
			}
			
		}
	}
}
