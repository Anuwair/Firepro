using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class reserve : UserControl
    {
        private static reserve _instance;
        public static reserve Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new reserve();
                return _instance;
            }
        }

        public reserve()
        {
            InitializeComponent();
        }
    }
}
