using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TatilGünleri_MonthCalendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmb_tatil_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            list_tatilListesi.Items.Add(monthCalendar1.SelectionStart.ToShortDateString() + " " + monthCalendar1.SelectionEnd.ToShortDateString() + " " + cmb_tatil.SelectedItem);
        }

        private void btn_Cikar_Click(object sender, EventArgs e)
        {
            list_tatilListesi.Items.RemoveAt(list_tatilListesi.SelectedIndex);
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
