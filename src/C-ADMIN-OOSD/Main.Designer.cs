namespace C_ADMIN_OOSD
{
    partial class Main
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
            this.BDBTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BDBTest
            // 
            this.BDBTest.Location = new System.Drawing.Point(238, 415);
            this.BDBTest.Name = "BDBTest";
            this.BDBTest.Size = new System.Drawing.Size(114, 23);
            this.BDBTest.TabIndex = 0;
            this.BDBTest.Text = "Nac\'s test button";
            this.BDBTest.UseVisualStyleBackColor = true;
            this.BDBTest.Click += new System.EventHandler(this.BDBTest_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 450);
            this.Controls.Add(this.BDBTest);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BDBTest;
    }
}

