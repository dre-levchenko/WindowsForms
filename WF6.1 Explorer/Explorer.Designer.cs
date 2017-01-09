namespace WF6._1_Explorer
{
    partial class Explorer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Explorer));
            this.directoriesTreeView = new System.Windows.Forms.TreeView();
            this.directoriesListView = new System.Windows.Forms.ListView();
            this.navigator = new System.Windows.Forms.ToolStrip();
            this.navigationBack = new System.Windows.Forms.ToolStripButton();
            this.navigationForward = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.navigationUp = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.navigationUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.navigationShowStyle = new System.Windows.Forms.ToolStripDropDownButton();
            this.showStyleList = new System.Windows.Forms.ToolStripTextBox();
            this.showStyleTiles = new System.Windows.Forms.ToolStripTextBox();
            this.showStyleTable = new System.Windows.Forms.ToolStripTextBox();
            this.showStyleBigIcons = new System.Windows.Forms.ToolStripTextBox();
            this.navigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // directoriesTreeView
            // 
            this.directoriesTreeView.Location = new System.Drawing.Point(0, 25);
            this.directoriesTreeView.Name = "directoriesTreeView";
            this.directoriesTreeView.Size = new System.Drawing.Size(200, 447);
            this.directoriesTreeView.TabIndex = 0;
            this.directoriesTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.OnNodeMouseClick);
            // 
            // directoriesListView
            // 
            this.directoriesListView.Location = new System.Drawing.Point(200, 25);
            this.directoriesListView.Name = "directoriesListView";
            this.directoriesListView.Size = new System.Drawing.Size(548, 447);
            this.directoriesListView.TabIndex = 1;
            this.directoriesListView.UseCompatibleStateImageBehavior = false;
            // 
            // navigator
            // 
            this.navigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navigationBack,
            this.navigationForward,
            this.toolStripSeparator1,
            this.navigationUp,
            this.toolStripSeparator2,
            this.navigationUpdate,
            this.toolStripSeparator3,
            this.navigationShowStyle});
            this.navigator.Location = new System.Drawing.Point(0, 0);
            this.navigator.Name = "navigator";
            this.navigator.Size = new System.Drawing.Size(748, 25);
            this.navigator.TabIndex = 2;
            this.navigator.Text = "toolStrip1";
            // 
            // navigationBack
            // 
            this.navigationBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.navigationBack.Image = ((System.Drawing.Image)(resources.GetObject("navigationBack.Image")));
            this.navigationBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.navigationBack.Name = "navigationBack";
            this.navigationBack.Size = new System.Drawing.Size(23, 22);
            this.navigationBack.Text = "toolStripButton1";
            // 
            // navigationForward
            // 
            this.navigationForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.navigationForward.Image = ((System.Drawing.Image)(resources.GetObject("navigationForward.Image")));
            this.navigationForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.navigationForward.Name = "navigationForward";
            this.navigationForward.Size = new System.Drawing.Size(23, 22);
            this.navigationForward.Text = "toolStripButton2";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // navigationUp
            // 
            this.navigationUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.navigationUp.Image = ((System.Drawing.Image)(resources.GetObject("navigationUp.Image")));
            this.navigationUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.navigationUp.Name = "navigationUp";
            this.navigationUp.Size = new System.Drawing.Size(23, 22);
            this.navigationUp.Text = "toolStripButton3";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // navigationUpdate
            // 
            this.navigationUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.navigationUpdate.Image = ((System.Drawing.Image)(resources.GetObject("navigationUpdate.Image")));
            this.navigationUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.navigationUpdate.Name = "navigationUpdate";
            this.navigationUpdate.Size = new System.Drawing.Size(23, 22);
            this.navigationUpdate.Text = "toolStripButton4";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // navigationShowStyle
            // 
            this.navigationShowStyle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.navigationShowStyle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showStyleList,
            this.showStyleTiles,
            this.showStyleTable,
            this.showStyleBigIcons});
            this.navigationShowStyle.Image = ((System.Drawing.Image)(resources.GetObject("navigationShowStyle.Image")));
            this.navigationShowStyle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.navigationShowStyle.Name = "navigationShowStyle";
            this.navigationShowStyle.Size = new System.Drawing.Size(29, 22);
            this.navigationShowStyle.Text = "toolStripDropDownButton1";
            // 
            // showStyleList
            // 
            this.showStyleList.Name = "showStyleList";
            this.showStyleList.Size = new System.Drawing.Size(100, 23);
            this.showStyleList.Text = "Список";
            // 
            // showStyleTiles
            // 
            this.showStyleTiles.Name = "showStyleTiles";
            this.showStyleTiles.Size = new System.Drawing.Size(100, 23);
            this.showStyleTiles.Text = "Плитка";
            // 
            // showStyleTable
            // 
            this.showStyleTable.Name = "showStyleTable";
            this.showStyleTable.Size = new System.Drawing.Size(100, 23);
            this.showStyleTable.Text = "Таблица";
            // 
            // showStyleBigIcons
            // 
            this.showStyleBigIcons.Name = "showStyleBigIcons";
            this.showStyleBigIcons.Size = new System.Drawing.Size(100, 23);
            this.showStyleBigIcons.Text = "Большие значки";
            // 
            // Explorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 472);
            this.Controls.Add(this.navigator);
            this.Controls.Add(this.directoriesListView);
            this.Controls.Add(this.directoriesTreeView);
            this.Name = "Explorer";
            this.Text = "Проводник";
            this.Load += new System.EventHandler(this.OnLoad);
            this.navigator.ResumeLayout(false);
            this.navigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView directoriesTreeView;
        private System.Windows.Forms.ListView directoriesListView;
        private System.Windows.Forms.ToolStrip navigator;
        private System.Windows.Forms.ToolStripButton navigationBack;
        private System.Windows.Forms.ToolStripButton navigationForward;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton navigationUp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton navigationUpdate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton navigationShowStyle;
        private System.Windows.Forms.ToolStripTextBox showStyleList;
        private System.Windows.Forms.ToolStripTextBox showStyleTiles;
        private System.Windows.Forms.ToolStripTextBox showStyleTable;
        private System.Windows.Forms.ToolStripTextBox showStyleBigIcons;
    }
}

