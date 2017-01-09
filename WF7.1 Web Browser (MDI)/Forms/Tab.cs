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
    public partial class Tab : Form
    {
        public string URL { get; private set; }
        public string Title { get; private set; }

        public bool CanGoBack 
        {
            get
            {
                return webBrowser.CanGoBack;
            }
        }
        public bool CanGoForward 
        {
            get
            {
                return webBrowser.CanGoForward;
            }
        }

        public event WebBrowserNavigatedEventHandler Navigated;

        public Tab()
        {
            InitializeComponent();
            Title = "New Tab";
        }

        public void Navigate(string url)
        {
            webBrowser.Navigate(url);
        }
        public void GoBack()
        {
            if (CanGoBack)
            {
                webBrowser.GoBack();
            }
        }
        public void GoForward()
        {
            if (CanGoForward)
            {
                webBrowser.GoForward();
            }
        }
        public void GoHome()
        {
            webBrowser.GoHome();
        }
        public void Reload()
        {
            webBrowser.Refresh();
        }

        private void OnWebBrowserNavigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            URL = webBrowser.Url.AbsoluteUri;
            WebBrowserNavigatedEventHandler handler = Navigated;
            if (handler != null)
            {
                handler(sender, e);
            }
            var menuItem = (ToolStripItem)Tag;
            Text = Title = menuItem.Text = webBrowser.Document.Title;
        }

        private void OnTabClosing(object sender, FormClosingEventArgs e)
        {
            var menuItem = (ToolStripItem)Tag;
            menuItem.Dispose();
        }
    }
}
