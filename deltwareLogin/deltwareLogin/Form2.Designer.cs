
using System.Windows.Forms;

namespace deltwareLogin
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.main = new System.Windows.Forms.PictureBox();
            this.usernameLogin = new System.Windows.Forms.TextBox();
            this.passwordLogin = new System.Windows.Forms.TextBox();
            this.loginButtonLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginButtonLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // main
            // 
            this.main.BackgroundImage = global::deltwareLogin.Properties.Resources.Login;
            this.main.Location = new System.Drawing.Point(-2, -41);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(404, 844);
            this.main.TabIndex = 0;
            this.main.TabStop = false;
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
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 805);
            this.Controls.Add(this.loginButtonLogin);
            this.Controls.Add(this.passwordLogin);
            this.Controls.Add(this.usernameLogin);
            this.Controls.Add(this.main);
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginButtonLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.PictureBox main;
        private System.Windows.Forms.TextBox usernameLogin;
        private TextBox passwordLogin;
        private PictureBox loginButtonLogin;
    }
}