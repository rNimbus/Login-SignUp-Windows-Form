
namespace Login_SignUp
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.lblUsername = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.btnLogin = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.gpbxLogin = new System.Windows.Forms.GroupBox();
			this.cbShowPasswordLogin = new System.Windows.Forms.CheckBox();
			this.llblSignup = new System.Windows.Forms.LinkLabel();
			this.lblAccconfirm = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtConfirmPassword = new System.Windows.Forms.TextBox();
			this.cbShowPassSignup = new System.Windows.Forms.CheckBox();
			this.lblConfirmPasswornd = new System.Windows.Forms.Label();
			this.lblSignUp = new System.Windows.Forms.Label();
			this.btnSignUp = new System.Windows.Forms.Button();
			this.lblEnterUsername = new System.Windows.Forms.Label();
			this.txtEnterPassword = new System.Windows.Forms.TextBox();
			this.lblEnterPassword = new System.Windows.Forms.Label();
			this.txtEnterUsername = new System.Windows.Forms.TextBox();
			this.gpbxLogin.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtUserName
			// 
			this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(227)))));
			this.txtUserName.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtUserName.Location = new System.Drawing.Point(82, 89);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(154, 20);
			this.txtUserName.TabIndex = 0;
			// 
			// txtPassword
			// 
			this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(227)))));
			this.txtPassword.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtPassword.Location = new System.Drawing.Point(82, 128);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(154, 20);
			this.txtPassword.TabIndex = 1;
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// lblUsername
			// 
			this.lblUsername.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
			this.lblUsername.BackColor = System.Drawing.Color.Transparent;
			this.lblUsername.CausesValidation = false;
			this.lblUsername.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblUsername.Location = new System.Drawing.Point(82, 70);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(123, 16);
			this.lblUsername.TabIndex = 2;
			this.lblUsername.Text = "Username";
			// 
			// lblPassword
			// 
			this.lblPassword.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
			this.lblPassword.BackColor = System.Drawing.Color.Transparent;
			this.lblPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblPassword.Location = new System.Drawing.Point(82, 112);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(123, 16);
			this.lblPassword.TabIndex = 3;
			this.lblPassword.Text = "Password";
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.Color.Transparent;
			this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
			this.btnLogin.FlatAppearance.BorderSize = 10;
			this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(212)))), ((int)(((byte)(221)))));
			this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(212)))), ((int)(((byte)(221)))));
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnLogin.Location = new System.Drawing.Point(120, 178);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(85, 26);
			this.btnLogin.TabIndex = 6;
			this.btnLogin.Text = "Log in";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.BtnLoginClick);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.label1.Location = new System.Drawing.Point(111, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 29);
			this.label1.TabIndex = 8;
			this.label1.Text = "Login";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// gpbxLogin
			// 
			this.gpbxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(212)))), ((int)(((byte)(221)))));
			this.gpbxLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gpbxLogin.BackgroundImage")));
			this.gpbxLogin.Controls.Add(this.txtPassword);
			this.gpbxLogin.Controls.Add(this.cbShowPasswordLogin);
			this.gpbxLogin.Controls.Add(this.llblSignup);
			this.gpbxLogin.Controls.Add(this.lblAccconfirm);
			this.gpbxLogin.Controls.Add(this.label1);
			this.gpbxLogin.Controls.Add(this.btnLogin);
			this.gpbxLogin.Controls.Add(this.lblUsername);
			this.gpbxLogin.Controls.Add(this.lblPassword);
			this.gpbxLogin.Controls.Add(this.txtUserName);
			this.gpbxLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gpbxLogin.Location = new System.Drawing.Point(26, 45);
			this.gpbxLogin.Name = "gpbxLogin";
			this.gpbxLogin.Size = new System.Drawing.Size(316, 247);
			this.gpbxLogin.TabIndex = 9;
			this.gpbxLogin.TabStop = false;
			// 
			// cbShowPasswordLogin
			// 
			this.cbShowPasswordLogin.BackColor = System.Drawing.Color.Transparent;
			this.cbShowPasswordLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbShowPasswordLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.cbShowPasswordLogin.Location = new System.Drawing.Point(82, 147);
			this.cbShowPasswordLogin.Name = "cbShowPasswordLogin";
			this.cbShowPasswordLogin.Size = new System.Drawing.Size(104, 24);
			this.cbShowPasswordLogin.TabIndex = 11;
			this.cbShowPasswordLogin.Text = "Show Password";
			this.cbShowPasswordLogin.UseVisualStyleBackColor = false;
			this.cbShowPasswordLogin.CheckedChanged += new System.EventHandler(this.CbShowPasswordLoginCheckedChanged);
			// 
			// llblSignup
			// 
			this.llblSignup.BackColor = System.Drawing.Color.Transparent;
			this.llblSignup.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.llblSignup.Location = new System.Drawing.Point(195, 212);
			this.llblSignup.Name = "llblSignup";
			this.llblSignup.Size = new System.Drawing.Size(100, 23);
			this.llblSignup.TabIndex = 10;
			this.llblSignup.TabStop = true;
			this.llblSignup.Text = "Sign up";
			this.llblSignup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlblSignupLinkClicked);
			// 
			// lblAccconfirm
			// 
			this.lblAccconfirm.BackColor = System.Drawing.Color.Transparent;
			this.lblAccconfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAccconfirm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblAccconfirm.Location = new System.Drawing.Point(68, 213);
			this.lblAccconfirm.Name = "lblAccconfirm";
			this.lblAccconfirm.Size = new System.Drawing.Size(137, 21);
			this.lblAccconfirm.TabIndex = 10;
			this.lblAccconfirm.Text = "Doesn\'t have an account?";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(212)))), ((int)(((byte)(221)))));
			this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
			this.groupBox1.Controls.Add(this.txtConfirmPassword);
			this.groupBox1.Controls.Add(this.cbShowPassSignup);
			this.groupBox1.Controls.Add(this.lblConfirmPasswornd);
			this.groupBox1.Controls.Add(this.lblSignUp);
			this.groupBox1.Controls.Add(this.btnSignUp);
			this.groupBox1.Controls.Add(this.lblEnterUsername);
			this.groupBox1.Controls.Add(this.txtEnterPassword);
			this.groupBox1.Controls.Add(this.lblEnterPassword);
			this.groupBox1.Controls.Add(this.txtEnterUsername);
			this.groupBox1.Location = new System.Drawing.Point(26, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(316, 297);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Visible = false;
			// 
			// txtConfirmPassword
			// 
			this.txtConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(227)))));
			this.txtConfirmPassword.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtConfirmPassword.Location = new System.Drawing.Point(80, 191);
			this.txtConfirmPassword.MaxLength = 16;
			this.txtConfirmPassword.Name = "txtConfirmPassword";
			this.txtConfirmPassword.Size = new System.Drawing.Size(154, 20);
			this.txtConfirmPassword.TabIndex = 16;
			this.txtConfirmPassword.UseSystemPasswordChar = true;
			// 
			// cbShowPassSignup
			// 
			this.cbShowPassSignup.BackColor = System.Drawing.Color.Transparent;
			this.cbShowPassSignup.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.cbShowPassSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbShowPassSignup.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.cbShowPassSignup.Location = new System.Drawing.Point(81, 209);
			this.cbShowPassSignup.Name = "cbShowPassSignup";
			this.cbShowPassSignup.Size = new System.Drawing.Size(104, 24);
			this.cbShowPassSignup.TabIndex = 17;
			this.cbShowPassSignup.Text = "Show Password";
			this.cbShowPassSignup.UseVisualStyleBackColor = false;
			this.cbShowPassSignup.CheckedChanged += new System.EventHandler(this.CbShowPassSignupCheckedChanged);
			// 
			// lblConfirmPasswornd
			// 
			this.lblConfirmPasswornd.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
			this.lblConfirmPasswornd.BackColor = System.Drawing.Color.Transparent;
			this.lblConfirmPasswornd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblConfirmPasswornd.Location = new System.Drawing.Point(80, 172);
			this.lblConfirmPasswornd.Name = "lblConfirmPasswornd";
			this.lblConfirmPasswornd.Size = new System.Drawing.Size(123, 16);
			this.lblConfirmPasswornd.TabIndex = 15;
			this.lblConfirmPasswornd.Text = "Confirm password";
			// 
			// lblSignUp
			// 
			this.lblSignUp.BackColor = System.Drawing.Color.Transparent;
			this.lblSignUp.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.lblSignUp.Location = new System.Drawing.Point(107, 33);
			this.lblSignUp.Name = "lblSignUp";
			this.lblSignUp.Size = new System.Drawing.Size(94, 29);
			this.lblSignUp.TabIndex = 11;
			this.lblSignUp.Text = "SignUp";
			this.lblSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnSignUp
			// 
			this.btnSignUp.BackColor = System.Drawing.Color.Transparent;
			this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSignUp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
			this.btnSignUp.FlatAppearance.BorderSize = 10;
			this.btnSignUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(212)))), ((int)(((byte)(221)))));
			this.btnSignUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(212)))), ((int)(((byte)(221)))));
			this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSignUp.ForeColor = System.Drawing.Color.Aqua;
			this.btnSignUp.Location = new System.Drawing.Point(116, 238);
			this.btnSignUp.Name = "btnSignUp";
			this.btnSignUp.Size = new System.Drawing.Size(85, 26);
			this.btnSignUp.TabIndex = 11;
			this.btnSignUp.Text = "Sign up";
			this.btnSignUp.UseVisualStyleBackColor = false;
			this.btnSignUp.Click += new System.EventHandler(this.SignUPClick);
			// 
			// lblEnterUsername
			// 
			this.lblEnterUsername.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
			this.lblEnterUsername.BackColor = System.Drawing.Color.Transparent;
			this.lblEnterUsername.CausesValidation = false;
			this.lblEnterUsername.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblEnterUsername.Location = new System.Drawing.Point(80, 87);
			this.lblEnterUsername.Name = "lblEnterUsername";
			this.lblEnterUsername.Size = new System.Drawing.Size(123, 16);
			this.lblEnterUsername.TabIndex = 13;
			this.lblEnterUsername.Text = "Enter username";
			// 
			// txtEnterPassword
			// 
			this.txtEnterPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(227)))));
			this.txtEnterPassword.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtEnterPassword.Location = new System.Drawing.Point(80, 148);
			this.txtEnterPassword.MaxLength = 16;
			this.txtEnterPassword.Name = "txtEnterPassword";
			this.txtEnterPassword.Size = new System.Drawing.Size(154, 20);
			this.txtEnterPassword.TabIndex = 12;
			this.txtEnterPassword.UseSystemPasswordChar = true;
			this.txtEnterPassword.TextChanged += new System.EventHandler(this.TxtEnterPasswordTextChanged);
			// 
			// lblEnterPassword
			// 
			this.lblEnterPassword.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
			this.lblEnterPassword.BackColor = System.Drawing.Color.Transparent;
			this.lblEnterPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblEnterPassword.Location = new System.Drawing.Point(80, 129);
			this.lblEnterPassword.Name = "lblEnterPassword";
			this.lblEnterPassword.Size = new System.Drawing.Size(123, 16);
			this.lblEnterPassword.TabIndex = 14;
			this.lblEnterPassword.Text = "Enter password";
			// 
			// txtEnterUsername
			// 
			this.txtEnterUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(227)))));
			this.txtEnterUsername.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtEnterUsername.Location = new System.Drawing.Point(80, 106);
			this.txtEnterUsername.MaxLength = 16;
			this.txtEnterUsername.Name = "txtEnterUsername";
			this.txtEnterUsername.Size = new System.Drawing.Size(154, 20);
			this.txtEnterUsername.TabIndex = 11;
			this.txtEnterUsername.TextChanged += new System.EventHandler(this.TxtEnterUsernameTextChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(231)))), ((int)(((byte)(225)))));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(360, 346);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.gpbxLogin);
			this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login&SignUp";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.gpbxLogin.ResumeLayout(false);
			this.gpbxLogin.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.CheckBox cbShowPassSignup;
		private System.Windows.Forms.CheckBox cbShowPasswordLogin;
		private System.Windows.Forms.TextBox txtConfirmPassword;
		private System.Windows.Forms.Label lblConfirmPasswornd;
		private System.Windows.Forms.TextBox txtEnterUsername;
		private System.Windows.Forms.Label lblEnterPassword;
		private System.Windows.Forms.TextBox txtEnterPassword;
		private System.Windows.Forms.Label lblEnterUsername;
		private System.Windows.Forms.Button btnSignUp;
		private System.Windows.Forms.Label lblSignUp;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblAccconfirm;
		private System.Windows.Forms.LinkLabel llblSignup;
		private System.Windows.Forms.GroupBox gpbxLogin;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtUserName;
		
		
		
		
		
		
		
		
		
		
		
		
	}
}
