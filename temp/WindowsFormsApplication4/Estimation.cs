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
    public partial class Estimation : UserControl
    {
        private static Estimation _instance;
        public static Estimation Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Estimation();
                return _instance;
            }
        }
    public Estimation()
        {
            InitializeComponent();
        }

        private void materialRadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Estimation_Load(object sender, EventArgs e)
        {

        }
    }
}
