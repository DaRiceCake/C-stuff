using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp.WinForms;

namespace Webbrowser
{
    public partial class Form1 : Form
    {
        public ChromiumWebBrowser ChromeWebComp;
        public Form1()
        {
            InitializeComponent();
            InitCrom();

        }

        private void back_Click(object sender, EventArgs e)
        {
            
        }

        private void forward_Click(object sender, EventArgs e)
        {

        }

        private void Go_Click(object sender, EventArgs e)
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

            panel2.Controls.Add (ChromeWebComp);
            // Make the browser fill the panel
            ChromeWebComp.Dock = DockStyle.Fill;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            CefSharp.Cef.Shutdown();
        }
    }
}
