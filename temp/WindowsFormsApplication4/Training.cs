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
    public partial class Training : UserControl
    {

        private static Training _instance;
        public static Training Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Training();
                return _instance;
            }
        }
        public Training()
        {
            InitializeComponent();
        }

        private void Training_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
