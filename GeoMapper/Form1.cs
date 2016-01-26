using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoMapper
{
    public partial class Form1 : Form
    {
        string curDir = Directory.GetCurrentDirectory();
        public Form1()
        {
            InitializeComponent();
            var tab = new TabPadding(tabControlDisplay);
            
             String appdir = Path.GetDirectoryName(Application.ExecutablePath);
            String myfile = Path.Combine(appdir, "map.html");
            browser.Url = new Uri("file:///" + myfile);
            //browser.ScriptErrorsSuppressed = true; //script errors
            //browser.DocumentText = "<html><body style='background-color:black'></body></html>";
            
            //splitContainer1.Panel1Collapsed = true;
            //splitContainer1.Panel1.Show();
            
            //Remove TabControl Header
            tabControlTools.Appearance = TabAppearance.FlatButtons;
            tabControlTools.ItemSize = new Size(0, 1);
            tabControlTools.SizeMode = TabSizeMode.Fixed;
            //Remove TabControl Header
            tabControlDisplay.Appearance = TabAppearance.FlatButtons;
            tabControlDisplay.ItemSize = new Size(0, 1);
            tabControlDisplay.SizeMode = TabSizeMode.Fixed;

            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = true;
            splitContainer1.Panel1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1.Show();
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            tabControlTools.SelectedTab = tabPage1;
            tabControlDisplay.SelectedTab = tabPageMap;
        }

        private void btnListStation_Click(object sender, EventArgs e)
        {
            tabControlTools.SelectedTab = tabPage2;
            tabControlDisplay.SelectedTab = tabPageList;
        }

        private void btnStat_Click(object sender, EventArgs e)
        {
            tabControlTools.SelectedTab = tabPage3;
            tabControlDisplay.SelectedTab = tabPageStats;
        }
    }
}
