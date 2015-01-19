using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ESRI.ArcGIS.Controls;

namespace chap2
{
    public partial class mapcontrol : Form
    {
        public mapcontrol()
        {
            InitializeComponent();
        }

        private void mapcontrol_Load(object sender, EventArgs e)
        {
            IMapControlDefault mapcontroldefault;
            MapControl mapcontrol;
            mapcontroldefault = axMapControl1.Object as IMapControlDefault;

            IMapControl2 map2;
            map2 = axMapControl1.Object as IMapControl2;
            
        }
    }
}
