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
            //Salut test
            InitializeComponent();

            String appdir = Path.GetDirectoryName(Application.ExecutablePath);
            String myfile = Path.Combine(appdir, "map.html");
            browser.Url = new Uri("file:///" + myfile);
            //browser.ScriptErrorsSuppressed = true; //script errors
            //browser.DocumentText = "<html><body style='background-color:black'></body></html>";


        }

        private void btnMap_Click(object sender, EventArgs e)
        {

        }

        
    }
}
