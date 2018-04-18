namespace QuickLaunch
{
    partial class QuickLaunch
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuickLaunch));
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showCtrlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scanToBuildDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStatitisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.run = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtQuickLaunch = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAvailable = new System.Windows.Forms.Button();
            this.cbbApp = new System.Windows.Forms.ComboBox();
            this.listApps = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showCtrlToolStripMenuItem,
            this.scanToBuildDatabaseToolStripMenuItem,
            this.viewStatitisticsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // showCtrlToolStripMenuItem
            // 
            this.showCtrlToolStripMenuItem.Name = "showCtrlToolStripMenuItem";
            resources.ApplyResources(this.showCtrlToolStripMenuItem, "showCtrlToolStripMenuItem");
            this.showCtrlToolStripMenuItem.Click += new System.EventHandler(this.showCtrlToolStripMenuItem_Click);
            // 
            // scanToBuildDatabaseToolStripMenuItem
            // 
            this.scanToBuildDatabaseToolStripMenuItem.Name = "scanToBuildDatabaseToolStripMenuItem";
            resources.ApplyResources(this.scanToBuildDatabaseToolStripMenuItem, "scanToBuildDatabaseToolStripMenuItem");
            this.scanToBuildDatabaseToolStripMenuItem.Click += new System.EventHandler(this.scanToBuildDatabaseToolStripMenuItem_Click);
            // 
            // viewStatitisticsToolStripMenuItem
            // 
            this.viewStatitisticsToolStripMenuItem.Name = "viewStatitisticsToolStripMenuItem";
            resources.ApplyResources(this.viewStatitisticsToolStripMenuItem, "viewStatitisticsToolStripMenuItem");
            this.viewStatitisticsToolStripMenuItem.Click += new System.EventHandler(this.viewStatitisticsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // run
            // 
            this.run.ContextMenuStrip = this.contextMenuStrip1;
            resources.ApplyResources(this.run, "run");
            this.run.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // btnOK
            // 
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBrowse
            // 
            resources.ApplyResources(this.btnBrowse, "btnBrowse");
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtQuickLaunch
            // 
            resources.ApplyResources(this.txtQuickLaunch, "txtQuickLaunch");
            this.txtQuickLaunch.Name = "txtQuickLaunch";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuickLaunch.Properties.Resources.images;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btnAvailable
            // 
            resources.ApplyResources(this.btnAvailable, "btnAvailable");
            this.btnAvailable.Name = "btnAvailable";
            this.btnAvailable.UseVisualStyleBackColor = true;
            this.btnAvailable.Click += new System.EventHandler(this.btnAvailable_Click);
            // 
            // cbbApp
            // 
            this.cbbApp.FormattingEnabled = true;
            resources.ApplyResources(this.cbbApp, "cbbApp");
            this.cbbApp.Name = "cbbApp";
            this.cbbApp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbbApp_KeyDown);
            this.cbbApp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbApp_KeyPress);
            this.cbbApp.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbbApp_KeyUp);
            // 
            // listApps
            // 
            this.listApps.FormattingEnabled = true;
            resources.ApplyResources(this.listApps, "listApps");
            this.listApps.Name = "listApps";
            this.listApps.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listApps_KeyDown);
            this.listApps.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listApps_KeyPress);
            // 
            // QuickLaunch
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listApps);
            this.Controls.Add(this.cbbApp);
            this.Controls.Add(this.btnAvailable);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtQuickLaunch);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Name = "QuickLaunch";
            this.Load += new System.EventHandler(this.QuickLaunch_Load);
            this.Move += new System.EventHandler(this.QuickLaunch_Move);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem scanToBuildDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStatitisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon run;
        private System.Windows.Forms.ToolStripMenuItem showCtrlToolStripMenuItem;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label txtQuickLaunch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAvailable;
        private System.Windows.Forms.ComboBox cbbApp;
        private System.Windows.Forms.ListBox listApps;
    }
}

