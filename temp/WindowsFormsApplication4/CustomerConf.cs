﻿using System;
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
    public partial class CustomerConf : UserControl
    {
        private static CustomerConf _instance;
        public static CustomerConf Instance
        {

            get
            {
                if (_instance == null)
                    _instance = new CustomerConf();
                return _instance;
            }
        }
        public CustomerConf()
        {
            InitializeComponent();
        }

        private void Addnewrq_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
