namespace C_ADMIN_OOSD
{
    partial class MySQL_TestForm
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
            this.Login = new System.Windows.Forms.Button();
            this.TBUser = new System.Windows.Forms.TextBox();
            this.TBPass = new System.Windows.Forms.TextBox();
            this.TBPort = new System.Windows.Forms.TextBox();
            this.TBIP = new System.Windows.Forms.TextBox();
            this.BClose = new System.Windows.Forms.Button();
            this.LUsr = new System.Windows.Forms.Label();
            this.LPass = new System.Windows.Forms.Label();
            this.LIP = new System.Windows.Forms.Label();
            this.LPort = new System.Windows.Forms.Label();
            this.LTest = new System.Windows.Forms.Label();
            this.LDB = new System.Windows.Forms.Label();
            this.TBDB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(12, 12);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 23);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // TBUser
            // 
            this.TBUser.Location = new System.Drawing.Point(163, 12);
            this.TBUser.Name = "TBUser";
            this.TBUser.Size = new System.Drawing.Size(100, 20);
            this.TBUser.TabIndex = 1;
            // 
            // TBPass
            // 
            this.TBPass.Location = new System.Drawing.Point(163, 38);
            this.TBPass.Name = "TBPass";
            this.TBPass.Size = new System.Drawing.Size(100, 20);
            this.TBPass.TabIndex = 2;
            this.TBPass.UseSystemPasswordChar = true;
            // 
            // TBPort
            // 
            this.TBPort.Location = new System.Drawing.Point(163, 90);
            this.TBPort.Name = "TBPort";
            this.TBPort.Size = new System.Drawing.Size(100, 20);
            this.TBPort.TabIndex = 3;
            // 
            // TBIP
            // 
            this.TBIP.Location = new System.Drawing.Point(163, 64);
            this.TBIP.Name = "TBIP";
            this.TBIP.Size = new System.Drawing.Size(100, 20);
            this.TBIP.TabIndex = 4;
            // 
            // BClose
            // 
            this.BClose.Location = new System.Drawing.Point(12, 41);
            this.BClose.Name = "BClose";
            this.BClose.Size = new System.Drawing.Size(75, 23);
            this.BClose.TabIndex = 5;
            this.BClose.Text = "Close";
            this.BClose.UseVisualStyleBackColor = true;
            this.BClose.Click += new System.EventHandler(this.BClose_Click);
            // 
            // LUsr
            // 
            this.LUsr.AutoSize = true;
            this.LUsr.Location = new System.Drawing.Point(102, 19);
            this.LUsr.Name = "LUsr";
            this.LUsr.Size = new System.Drawing.Size(55, 13);
            this.LUsr.TabIndex = 6;
            this.LUsr.Text = "Username";
            // 
            // LPass
            // 
            this.LPass.AutoSize = true;
            this.LPass.Location = new System.Drawing.Point(102, 45);
            this.LPass.Name = "LPass";
            this.LPass.Size = new System.Drawing.Size(53, 13);
            this.LPass.TabIndex = 7;
            this.LPass.Text = "Password";
            // 
            // LIP
            // 
            this.LIP.AutoSize = true;
            this.LIP.Location = new System.Drawing.Point(102, 71);
            this.LIP.Name = "LIP";
            this.LIP.Size = new System.Drawing.Size(17, 13);
            this.LIP.TabIndex = 8;
            this.LIP.Text = "IP";
            // 
            // LPort
            // 
            this.LPort.AutoSize = true;
            this.LPort.Location = new System.Drawing.Point(102, 97);
            this.LPort.Name = "LPort";
            this.LPort.Size = new System.Drawing.Size(26, 13);
            this.LPort.TabIndex = 9;
            this.LPort.Text = "Port";
            // 
            // LTest
            // 
            this.LTest.AutoSize = true;
            this.LTest.Location = new System.Drawing.Point(12, 150);
            this.LTest.Name = "LTest";
            this.LTest.Size = new System.Drawing.Size(38, 13);
            this.LTest.TabIndex = 10;
            this.LTest.Text = "TEST:";
            // 
            // LDB
            // 
            this.LDB.AutoSize = true;
            this.LDB.Location = new System.Drawing.Point(102, 123);
            this.LDB.Name = "LDB";
            this.LDB.Size = new System.Drawing.Size(22, 13);
            this.LDB.TabIndex = 12;
            this.LDB.Text = "DB";
            // 
            // TBDB
            // 
            this.TBDB.Location = new System.Drawing.Point(163, 116);
            this.TBDB.Name = "TBDB";
            this.TBDB.Size = new System.Drawing.Size(100, 20);
            this.TBDB.TabIndex = 11;
            // 
            // MySQL_TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 261);
            this.Controls.Add(this.LDB);
            this.Controls.Add(this.TBDB);
            this.Controls.Add(this.LTest);
            this.Controls.Add(this.LPort);
            this.Controls.Add(this.LIP);
            this.Controls.Add(this.LPass);
            this.Controls.Add(this.LUsr);
            this.Controls.Add(this.BClose);
            this.Controls.Add(this.TBIP);
            this.Controls.Add(this.TBPort);
            this.Controls.Add(this.TBPass);
            this.Controls.Add(this.TBUser);
            this.Controls.Add(this.Login);
            this.Name = "MySQL_TestForm";
            this.Text = "DB Testing";
            this.Load += new System.EventHandler(this.MySQL_TestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.TextBox TBUser;
        private System.Windows.Forms.TextBox TBPass;
        private System.Windows.Forms.TextBox TBPort;
        private System.Windows.Forms.TextBox TBIP;
        private System.Windows.Forms.Button BClose;
        private System.Windows.Forms.Label LUsr;
        private System.Windows.Forms.Label LPass;
        private System.Windows.Forms.Label LIP;
        private System.Windows.Forms.Label LPort;
        private System.Windows.Forms.Label LTest;
        private System.Windows.Forms.Label LDB;
        private System.Windows.Forms.TextBox TBDB;
    }
}