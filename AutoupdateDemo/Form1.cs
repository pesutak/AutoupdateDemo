using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoupdateDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var apath = Assembly.GetEntryAssembly().Location;
            var ver = FileVersionInfo.GetVersionInfo(apath);
            Text = $"{ver.ProductName} {Assembly.GetEntryAssembly().GetName().Version.ToString()}";
        }
    }
}
