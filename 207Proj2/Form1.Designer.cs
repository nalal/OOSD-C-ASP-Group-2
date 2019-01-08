namespace _207Proj2
{
    partial class Form1
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
            this.lblPackages = new System.Windows.Forms.Label();
            this.lstPackages = new System.Windows.Forms.ListBox();
            this.btnEditPackages = new System.Windows.Forms.Button();
            this.btnAddPackages = new System.Windows.Forms.Button();
            this.lstCurPkg = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPackages
            // 
            this.lblPackages.AutoSize = true;
            this.lblPackages.Location = new System.Drawing.Point(358, 51);
            this.lblPackages.Name = "lblPackages";
            this.lblPackages.Size = new System.Drawing.Size(125, 20);
            this.lblPackages.TabIndex = 0;
            this.lblPackages.Text = "Travel Packages";
            // 
            // lstPackages
            // 
            this.lstPackages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPackages.FormattingEnabled = true;
            this.lstPackages.HorizontalScrollbar = true;
            this.lstPackages.ItemHeight = 16;
            this.lstPackages.Location = new System.Drawing.Point(262, 88);
            this.lstPackages.Name = "lstPackages";
            this.lstPackages.Size = new System.Drawing.Size(307, 276);
            this.lstPackages.TabIndex = 1;
            // 
            // btnEditPackages
            // 
            this.btnEditPackages.Location = new System.Drawing.Point(277, 480);
            this.btnEditPackages.Name = "btnEditPackages";
            this.btnEditPackages.Size = new System.Drawing.Size(86, 33);
            this.btnEditPackages.TabIndex = 2;
            this.btnEditPackages.Text = "Edit ";
            this.btnEditPackages.UseVisualStyleBackColor = true;
            // 
            // btnAddPackages
            // 
            this.btnAddPackages.Location = new System.Drawing.Point(480, 480);
            this.btnAddPackages.Name = "btnAddPackages";
            this.btnAddPackages.Size = new System.Drawing.Size(89, 32);
            this.btnAddPackages.TabIndex = 3;
            this.btnAddPackages.Text = "Add";
            this.btnAddPackages.UseVisualStyleBackColor = true;
            // 
            // lstCurPkg
            // 
            this.lstCurPkg.FormattingEnabled = true;
            this.lstCurPkg.ItemHeight = 20;
            this.lstCurPkg.Location = new System.Drawing.Point(12, 370);
            this.lstCurPkg.Name = "lstCurPkg";
            this.lstCurPkg.Size = new System.Drawing.Size(836, 84);
            this.lstCurPkg.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(668, 150);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 38);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(640, 118);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(142, 26);
            this.txtSearch.TabIndex = 6;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(681, 201);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(63, 20);
            this.lblResults.TabIndex = 7;
            this.lblResults.Text = "Results";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 563);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lstCurPkg);
            this.Controls.Add(this.btnAddPackages);
            this.Controls.Add(this.btnEditPackages);
            this.Controls.Add(this.lstPackages);
            this.Controls.Add(this.lblPackages);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPackages;
        private System.Windows.Forms.ListBox lstPackages;
        private System.Windows.Forms.Button btnEditPackages;
        private System.Windows.Forms.Button btnAddPackages;
        private System.Windows.Forms.ListBox lstCurPkg;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblResults;
    }
}

