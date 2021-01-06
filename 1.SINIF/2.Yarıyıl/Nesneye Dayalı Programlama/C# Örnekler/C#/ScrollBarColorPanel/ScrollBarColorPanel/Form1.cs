using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ScrollBarColorPanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int vR, vG, vB, hR, hG, hB;
        private void Form1_Load(object sender, EventArgs e)
        {
            vR = vG = vB = hR = hG = hB = 0;
        }
    }
}
