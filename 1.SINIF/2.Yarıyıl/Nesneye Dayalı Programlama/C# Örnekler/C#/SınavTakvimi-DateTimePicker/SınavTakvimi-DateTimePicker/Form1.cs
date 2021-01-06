using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SınavTakvimi_DateTimePicker
{
    public partial class Form1 : Form
    {
        string ders;
        string tarih;
        public Form1()
        {
            InitializeComponent();
        }

        private void dtp_takvim_ValueChanged(object sender, EventArgs e)
        {
            ders = Convert.ToString(cmb_dersler.SelectedItem);
            tarih = Convert.ToString(dtp_takvim.Value.ToShortDateString());
            list_liste.Items.Add(ders + " " + tarih);

        }
    }
}
