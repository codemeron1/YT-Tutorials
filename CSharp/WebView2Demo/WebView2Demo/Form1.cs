using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using System.IO;

namespace WebView2Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitWebView();
        }

        async void InitWebView()
        {
            await webView.EnsureCoreWebView2Async(null);
            webView.CoreWebView2.Navigate(Path.Combine("file:", Application.StartupPath, "html", "index.html"));
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            webView.CoreWebView2.ExecuteScriptAsync("document.getElementById('headerText').style.color = 'blue'");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webView.CoreWebView2.ExecuteScriptAsync("document.getElementById('headerText').innerText = 'HELLO WEBVIEW2!!!'");
        }
    }
}
