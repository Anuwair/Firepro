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
    public partial class Reminder : UserControl
    {
        private static Reminder _instance;
        public static Reminder Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Reminder();
                return _instance;
            }
        }
        public Reminder()
        {
            InitializeComponent();
        }

        private void Reminder_Load(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
