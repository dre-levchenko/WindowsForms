using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF7._1_Web_Browser__MDI_
{
    public partial class Browser : Form
    {
        public string URL { get; set; }

        public Browser()
        {
            InitializeComponent();

            tsbAdd.Tag = NavigationButtons.Add;
            tsbBack.Tag = NavigationButtons.Back;
            tsbForward.Tag = NavigationButtons.Forward;
            tsbHome.Tag = NavigationButtons.Home;
            tsbReload.Tag = NavigationButtons.Reload;
        }

        private void OnAdressKeyDown(object sender, KeyEventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                switch (e.KeyData)
                {
                    case Keys.Enter:
                        var tab = (Tab)ActiveMdiChild;
                        tab.Navigate(tstURL.Text);
                        break;
                }
            }
        }

        private void OnAddClick(object sender, EventArgs e)
        {
            CreateNewTab();
        }

        private void OnMDIChildActivate(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                var tab = (Tab)ActiveMdiChild;
                UpdateURL(tab.URL);
            }
        }

        private void OnNavigationClick(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                var tab = (Tab)ActiveMdiChild;
                var button = (ToolStripButton)sender;
                switch((NavigationButtons) button.Tag)
                {
                    case NavigationButtons.Back:
                        tab.GoBack();
                        break;
                    case NavigationButtons.Forward:
                        tab.GoForward();
                        break;
                    case NavigationButtons.Home:
                        tab.GoHome();
                        break;
                }
            }
        }

        private void CheckHistory()
        {
            var tab = (Tab)ActiveMdiChild;
            tsbBack.Enabled = tab.CanGoBack;
            tsbForward.Enabled = tab.CanGoForward;
            tsbReload.Enabled = tab != null;
        }

        private void CreateNewTab()
        {
            var tab = new Tab();
            tab.MdiParent = this;
            tab.Navigated += OnURLChanged;
            tab.Show();
            tab.Tag = tabsBar.Items.Add(tab.Title);
        }

        private void UpdateURL(string url)
        {
            tstURL.Text = url;
            CheckHistory();
        }

        private void OnURLChanged(object sender, WebBrowserNavigatedEventArgs e)
        {
            UpdateURL(e.Url.AbsoluteUri);
        }

        private void OnBrowserResize(object sender, EventArgs e)
        {
            tstURL.Size = new Size (toolStripBrowser.Width - (tsbAdd.Width + tsbBack.Width + tsbForward.Width + tsbHome.Width + tsbReload.Width + 50), tstURL.Height);
        }
    }
}
