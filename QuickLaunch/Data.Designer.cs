namespace QuickLaunch
{
    partial class Data
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSelectfile = new System.Windows.Forms.Button();
            this.btnInstall = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(44, 134);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.Location = new System.Drawing.Point(89, 57);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(179, 18);
            this.txt.TabIndex = 2;
            this.txt.Text = "Scan to build database";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "you can add another folder to add more application";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(44, 185);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Location = new System.Drawing.Point(151, 185);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAll.TabIndex = 5;
            this.btnDeleteAll.Text = "Delete all";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnBack
            // 
            this.btnBack.Image = global::QuickLaunch.Properties.Resources.images__1_;
            this.btnBack.Location = new System.Drawing.Point(16, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(37, 34);
            this.btnBack.TabIndex = 6;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSelectfile
            // 
            this.btnSelectfile.Location = new System.Drawing.Point(151, 134);
            this.btnSelectfile.Name = "btnSelectfile";
            this.btnSelectfile.Size = new System.Drawing.Size(75, 23);
            this.btnSelectfile.TabIndex = 7;
            this.btnSelectfile.Text = "Select File";
            this.btnSelectfile.UseVisualStyleBackColor = true;
            this.btnSelectfile.Click += new System.EventHandler(this.btnSelectfile_Click);
            // 
            // btnInstall
            // 
            this.btnInstall.Location = new System.Drawing.Point(274, 150);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(80, 44);
            this.btnInstall.TabIndex = 8;
            this.btnInstall.Text = "Load Installed App";
            this.btnInstall.UseVisualStyleBackColor = true;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 246);
            this.Controls.Add(this.btnInstall);
            this.Controls.Add(this.btnSelectfile);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.btnLoad);
            this.Name = "Data";
            this.Text = "Data";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Data_FormClosed);
            this.Load += new System.EventHandler(this.Data_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSelectfile;
        private System.Windows.Forms.Button btnInstall;
    }
}