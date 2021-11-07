using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deltwareLogin
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            clearScreen(0);
            loginScreen();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {

        }

        public void clearScreen(int id)
        {
            switch (id)
            {
                case 0:
                    loginButton.Visible = false;
                    registerButton.Visible = false;
                    break;
                default:
                    break;
            }
        }

        //login
        private System.Windows.Forms.TextBox usernameLogin;
        private TextBox passwordLogin;
        private PictureBox loginButtonLogin;

        public void loginScreen()
        {
            this.main.BackgroundImage = global::deltwareLogin.Properties.Resources.Login;
            this.main = new System.Windows.Forms.PictureBox();
            this.usernameLogin = new System.Windows.Forms.TextBox();
            this.passwordLogin = new System.Windows.Forms.TextBox();
            this.loginButtonLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginButtonLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLogin
            // 
            this.usernameLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(107)))));
            this.usernameLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameLogin.Font = new System.Drawing.Font("Roboto Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usernameLogin.ForeColor = System.Drawing.Color.White;
            this.usernameLogin.Location = new System.Drawing.Point(104, 298);
            this.usernameLogin.Name = "usernameLogin";
            this.usernameLogin.Size = new System.Drawing.Size(175, 35);
            this.usernameLogin.TabIndex = 1;
            this.usernameLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordLogin
            // 
            this.passwordLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(111)))));
            this.passwordLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordLogin.Font = new System.Drawing.Font("Roboto Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordLogin.ForeColor = System.Drawing.Color.White;
            this.passwordLogin.Location = new System.Drawing.Point(104, 352);
            this.passwordLogin.Name = "passwordLogin";
            this.passwordLogin.PasswordChar = '·';
            this.passwordLogin.Size = new System.Drawing.Size(175, 35);
            this.passwordLogin.TabIndex = 2;
            this.passwordLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // loginButtonLogin
            // 
            this.loginButtonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(113)))));
            this.loginButtonLogin.Image = global::deltwareLogin.Properties.Resources.loginComp;
            this.loginButtonLogin.Location = new System.Drawing.Point(135, 410);
            this.loginButtonLogin.Name = "loginButtonLogin";
            this.loginButtonLogin.Size = new System.Drawing.Size(118, 55);
            this.loginButtonLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loginButtonLogin.TabIndex = 3;
            this.loginButtonLogin.TabStop = false;
        }
    }
}
