using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Burcum
{
    public partial class Burcum : Form
    {
        public Burcum()
        {
            InitializeComponent();
        }

        private void btnBurcOgren_Click(object sender, EventArgs e)
        {

      DateTime tarih = dateTimePicker1.Value;
            int gun = tarih.Day;
            int ay = tarih.Month;
            string burc = "";
            if ((ay == 1 && gun >= 22) || (ay == 2 && gun <= 19))
            {
                burc = "Kova";
            }
            if ((ay == 2 && gun >= 20) || (ay == 3 && gun <= 20))
            {
                burc = "Balık";
            }
            if ((ay == 3 && gun >= 21) || (ay == 4 && gun <= 20))
            {
                burc = "Koç";
            }
            if ((ay == 4 && gun >= 21) || (ay == 5 && gun <= 21))
            {
                burc = "Boğa";
            }
            if ((ay == 5 && gun >= 22) || (ay == 6 && gun <= 22))
            {
                burc = "İkizler";
            }
            if ((ay == 6 && gun >= 23) || (ay == 7 && gun <= 22))
            {
                burc = "Yengeç";
            }
            if ((ay == 7 && gun >= 23) || (ay == 8 && gun <= 22))
            {
                burc = "Aslan";
            }
            if ((ay == 8 && gun >= 23) || (ay == 9 && gun <= 22))
            {
                burc = "Başak";
            }
            if ((ay == 9 && gun >= 23) || (ay == 10 && gun <= 22))
            {
                burc = "Terazi";
            }
            if ((ay == 10 && gun >= 23) || (ay == 11 && gun <= 21))
            {
                burc = "Akrep";
            }
            if ((ay == 11 && gun >= 22) || (ay == 12 && gun <= 21))
            {
                burc = "Yay";
            }
            if ((ay == 12 && gun >= 22) || (ay == 1 && gun <= 21))
            {
                burc = "Oğlak";
            }
            lblburc.Text = burc.ToString();
        }
    }
}
