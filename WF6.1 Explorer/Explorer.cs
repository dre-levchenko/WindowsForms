using System;
using System.IO;
using System.Security.AccessControl;
using System.Threading;
using System.Windows.Forms;

namespace WF6._1_Explorer
{
    public partial class Explorer : Form
    {
        public delegate void AsyncMethodCaller(DirectoryInfo[] subDirs, TreeNode nodeToAddTo);

        public Explorer()
        {
            InitializeComponent();
        }

        private void PopulateTreeView()
        {
            TreeNode rootNode;

            foreach (var drive in DriveInfo.GetDrives())
            {
                DirectoryInfo info = new DirectoryInfo(drive.Name);
                if (info.Exists)
                {
                    rootNode = new TreeNode(info.Name);
                    rootNode.Tag = info;

                    GetDirectories(info.GetDirectories(), rootNode);
                    directoriesTreeView.Nodes.Add(rootNode);
                }
            }
        }

        private void GetDirectories(DirectoryInfo[] subDirs, TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "folder";
                try
                {
                    subSubDirs = subDir.GetDirectories();
                    if (subSubDirs.Length != 0)
                    {
                        GetDirectories(subSubDirs, aNode);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                nodeToAddTo.Nodes.Add(aNode);
            }
        }

        private void OnNodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode newSelected = e.Node;
            directoriesListView.Items.Clear();
            DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;

            try
            {
                foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
                {
                    item = new ListViewItem(dir.Name, 0);
                    subItems = new ListViewItem.ListViewSubItem[]
                              {
                                new ListViewItem.ListViewSubItem(item, "Directory"),
                                new ListViewItem.ListViewSubItem(item, dir.LastAccessTime.ToShortDateString())
                              };
                    item.SubItems.AddRange(subItems);
                    directoriesListView.Items.Add(item);
                }
                foreach (FileInfo file in nodeDirInfo.GetFiles())
                {
                    item = new ListViewItem(file.Name, 1);
                    subItems = new ListViewItem.ListViewSubItem[]
                              {
                                new ListViewItem.ListViewSubItem(item, "File"),
                                new ListViewItem.ListViewSubItem(item, file.LastAccessTime.ToShortDateString())
                              };
                    item.SubItems.AddRange(subItems);
                    directoriesListView.Items.Add(item);
                }
                directoriesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void OnLoad(object sender, EventArgs e)
        {
            PopulateTreeView();
        }
    }
}
