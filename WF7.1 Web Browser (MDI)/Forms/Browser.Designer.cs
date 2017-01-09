namespace WF7._1_Web_Browser__MDI_
{
    partial class Browser
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
            this.toolStripBrowser = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbBack = new System.Windows.Forms.ToolStripButton();
            this.tsbForward = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbHome = new System.Windows.Forms.ToolStripButton();
            this.tsbReload = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tstURL = new System.Windows.Forms.ToolStripTextBox();
            this.tabsBar = new System.Windows.Forms.MenuStrip();
            this.toolStripBrowser.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripBrowser
            // 
            this.toolStripBrowser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.toolStripSeparator3,
            this.tsbBack,
            this.tsbForward,
            this.toolStripSeparator1,
            this.tsbHome,
            this.tsbReload,
            this.toolStripSeparator2,
            this.tstURL});
            this.toolStripBrowser.Location = new System.Drawing.Point(0, 24);
            this.toolStripBrowser.Name = "toolStripBrowser";
            this.toolStripBrowser.Size = new System.Drawing.Size(694, 25);
            this.toolStripBrowser.TabIndex = 1;
            this.toolStripBrowser.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdd.Image = global::WF7._1_Web_Browser__MDI_.icons.add;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(23, 22);
            this.tsbAdd.Tag = "Add";
            this.tsbAdd.Text = "New Tab";
            this.tsbAdd.Click += new System.EventHandler(this.OnAddClick);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbBack
            // 
            this.tsbBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBack.Enabled = false;
            this.tsbBack.Image = global::WF7._1_Web_Browser__MDI_.icons.back;
            this.tsbBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBack.Name = "tsbBack";
            this.tsbBack.Size = new System.Drawing.Size(23, 22);
            this.tsbBack.Tag = "Back";
            this.tsbBack.Text = "Back";
            this.tsbBack.Click += new System.EventHandler(this.OnNavigationClick);
            // 
            // tsbForward
            // 
            this.tsbForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbForward.Enabled = false;
            this.tsbForward.Image = global::WF7._1_Web_Browser__MDI_.icons.forward;
            this.tsbForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbForward.Name = "tsbForward";
            this.tsbForward.Size = new System.Drawing.Size(23, 22);
            this.tsbForward.Tag = "Forward";
            this.tsbForward.Text = "Forward";
            this.tsbForward.Click += new System.EventHandler(this.OnNavigationClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbHome
            // 
            this.tsbHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbHome.Image = global::WF7._1_Web_Browser__MDI_.icons.home;
            this.tsbHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHome.Name = "tsbHome";
            this.tsbHome.Size = new System.Drawing.Size(23, 22);
            this.tsbHome.Tag = "Home";
            this.tsbHome.Text = "Home";
            this.tsbHome.Click += new System.EventHandler(this.OnNavigationClick);
            // 
            // tsbReload
            // 
            this.tsbReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbReload.Enabled = false;
            this.tsbReload.Image = global::WF7._1_Web_Browser__MDI_.icons.reload;
            this.tsbReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReload.Name = "tsbReload";
            this.tsbReload.Size = new System.Drawing.Size(23, 22);
            this.tsbReload.Tag = "Reload";
            this.tsbReload.Text = "Reload";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tstURL
            // 
            this.tstURL.Name = "tstURL";
            this.tstURL.Size = new System.Drawing.Size(500, 25);
            this.tstURL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnAdressKeyDown);
            // 
            // tabsBar
            // 
            this.tabsBar.Location = new System.Drawing.Point(0, 0);
            this.tabsBar.Name = "tabsBar";
            this.tabsBar.Size = new System.Drawing.Size(694, 24);
            this.tabsBar.TabIndex = 3;
            this.tabsBar.Text = "menuStrip1";
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 423);
            this.Controls.Add(this.toolStripBrowser);
            this.Controls.Add(this.tabsBar);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.tabsBar;
            this.Name = "Browser";
            this.Text = "Web Browser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MdiChildActivate += new System.EventHandler(this.OnMDIChildActivate);
            this.Resize += new System.EventHandler(this.OnBrowserResize);
            this.toolStripBrowser.ResumeLayout(false);
            this.toolStripBrowser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripBrowser;
        private System.Windows.Forms.ToolStripButton tsbBack;
        private System.Windows.Forms.ToolStripButton tsbForward;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbHome;
        private System.Windows.Forms.ToolStripButton tsbReload;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox tstURL;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.MenuStrip tabsBar;
    }
}

