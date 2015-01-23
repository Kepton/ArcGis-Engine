using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ESRI.ArcGIS.Controls;
using System.IO;

namespace Sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 添加SHPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "map document(*.shp)|*.shp";
            openfile.Title = "打开图层文件";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                FileInfo fileinfo = new FileInfo(openfile.FileName);
                string path = fileinfo.Directory.ToString();
                string filename = fileinfo.Name.Substring(0, fileinfo.Name.LastIndexOf('.'));
                try
                {
                    axMapControl1.AddShapeFile(path,filename);

                }
                catch (Exception ee)
                {
                    MessageBox.Show("添加图层失败"+ee.ToString());
                }
            }
        }

        private void 加载地图文档ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "*.mxd";
            openfile.Title = "加载地图文档Mxd";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                string path = openfile.FileName;
                if(axMapControl1.CheckMxFile(path))
                {
                    axMapControl1.MousePointer = esriControlsMousePointer.esriPointerHourglass;
                }
            }
        }
    }
}
