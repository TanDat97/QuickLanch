namespace QuickLaunch
{
    partial class Delete
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
            this.deleteApp = new System.Windows.Forms.ListBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // deleteApp
            // 
            this.deleteApp.FormattingEnabled = true;
            this.deleteApp.Location = new System.Drawing.Point(3, 5);
            this.deleteApp.Name = "deleteApp";
            this.deleteApp.ScrollAlwaysVisible = true;
            this.deleteApp.Size = new System.Drawing.Size(376, 329);
            this.deleteApp.TabIndex = 0;
            this.deleteApp.SelectedIndexChanged += new System.EventHandler(this.deleteApp_SelectedIndexChanged);
            this.deleteApp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.deleteApp_KeyPress);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(271, 349);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 349);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(173, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Press Enter to delete selected App";
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 384);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.deleteApp);
            this.Name = "Delete";
            this.Text = "Delete";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Delete_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox deleteApp;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox textBox1;
    }
}