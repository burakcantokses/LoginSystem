
using System.Windows.Forms;

namespace deltwareLogin
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.registerButton = new System.Windows.Forms.PictureBox();
            this.loginButton = new System.Windows.Forms.PictureBox();
            this.main = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.registerButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.main)).BeginInit();
            this.SuspendLayout();
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.registerButton.Image = global::deltwareLogin.Properties.Resources.registerComp;
            this.registerButton.Location = new System.Drawing.Point(134, 385);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(118, 55);
            this.registerButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.registerButton.TabIndex = 2;
            this.registerButton.TabStop = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.loginButton.Image = global::deltwareLogin.Properties.Resources.loginComp;
            this.loginButton.Location = new System.Drawing.Point(134, 306);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(118, 55);
            this.loginButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loginButton.TabIndex = 1;
            this.loginButton.TabStop = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // main
            // 
            this.main.BackgroundImage = global::deltwareLogin.Properties.Resources.Main;
            this.main.Location = new System.Drawing.Point(-2, -41);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(404, 844);
            this.main.TabIndex = 0;
            this.main.TabStop = false;


            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 805);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.main);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.registerButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox main;

        //main
        private System.Windows.Forms.PictureBox loginButton;
        private System.Windows.Forms.PictureBox registerButton;


    }
}

