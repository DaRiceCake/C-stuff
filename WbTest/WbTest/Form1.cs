using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CefSharp.WinForms;

namespace WbTest
{
    public partial class BrowserWindow : Form
    {
        public BrowserWindow()
        {
            InitializeComponent();
            InitCrom();
        }
        public ChromiumWebBrowser ChromeWebComp;

        private void back_Click(object sender, EventArgs e)
        {
            
        }

        private void forward_Click(object sender, EventArgs e)
        {
        }

        private void go_Click(object sender, EventArgs e)
        {
            ChromeWebComp.Load(UrlEnter.Text);
        }

        private void UrlEnter_TextChanged(object sender, EventArgs e)
        {

        }
        public void InitCrom()
        {
            CefSharp.CefSettings settings = new CefSharp.CefSettings();

            //Init Cef with the given settings
            CefSharp.Cef.Initialize(settings);

            // Create browser component

            ChromeWebComp = new ChromiumWebBrowser("https://www.google.co.uk");

            // Add the browser to the Form

            ChrWindow.Controls.Add(ChromeWebComp);
            // Make the browser fill the panel
            ChromeWebComp.Dock = DockStyle.Fill;

        }
    }
}
