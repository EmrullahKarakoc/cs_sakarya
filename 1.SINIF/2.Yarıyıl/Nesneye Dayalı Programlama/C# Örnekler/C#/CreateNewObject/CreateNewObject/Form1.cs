using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateNewObject
{
    public partial class Form1 : Form
    {
        public int i, n;
        public int l = 10;
        public int t = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt32(txt_n.Text);
            Form newForm = new Form();
            newForm.Text = "Yeni Form";
            newForm.Show();

            for (i = 0; i < n; i++)
            {
                PictureBox pbx = new PictureBox();
                pbx.BackColor = Color.Yellow;
                this.Controls.Add(pbx);
                //newForm.Controls.Add(pbx);
                pbx.Show();
                Button btn = new Button();
                btn.Name = "btn_" + i;
                btn.Text = "Buton " + (i + 1);
                btn.Left += (i * btn.Width) + 10;
                if (i % 2 == 0)
                {
                    btn.Top += (i * btn.Height) + 10;
                }
                newForm.Controls.Add(btn);
                btn.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
