using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArcgisEngineForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            ESRI.ArcGIS.RuntimeManager.Bind(ESRI.ArcGIS.ProductCode.Desktop);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath+"\\Map\\";
            string filename = @"world.mxd";
            axMapControl1.LoadMxFile(path+filename);
            axMapControl1.Extent = axMapControl1.FullExtent;
            //axToolbarControl1.Buddy = axMapControl1;

            axToolbarControl1.SetBuddyControl(axMapControl1);
        }
    }
}
