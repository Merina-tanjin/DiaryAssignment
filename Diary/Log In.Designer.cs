
namespace Diary
{
    partial class Log_In
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log_In));
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtPassord = new System.Windows.Forms.TextBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.RosyBrown;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.btnLogin.Location = new System.Drawing.Point(123, 150);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 32);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.label1.Location = new System.Drawing.Point(25, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "UserName";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.txtUserName.Location = new System.Drawing.Point(123, 42);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(168, 22);
            this.txtUserName.TabIndex = 2;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.Password.Location = new System.Drawing.Point(25, 88);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(69, 17);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password";
            this.Password.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.RosyBrown;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.btnExit.Location = new System.Drawing.Point(216, 150);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 32);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtPassord
            // 
            this.txtPassord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.txtPassord.Location = new System.Drawing.Point(123, 88);
            this.txtPassord.Name = "txtPassord";
            this.txtPassord.PasswordChar = '*';
            this.txtPassord.Size = new System.Drawing.Size(168, 22);
            this.txtPassord.TabIndex = 2;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.BackColor = System.Drawing.Color.MediumOrchid;
            this.checkBox.Location = new System.Drawing.Point(340, 92);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(53, 17);
            this.checkBox.TabIndex = 3;
            this.checkBox.Text = "Show";
            this.checkBox.UseVisualStyleBackColor = false;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // Log_In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(511, 276);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.txtPassord);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.MaximizeBox = false;
            this.Name = "Log_In";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.Log_In_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtPassord;
        private System.Windows.Forms.CheckBox checkBox;
    }
}