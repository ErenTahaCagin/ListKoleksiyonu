using System;
using System.Collections;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListKoleksiyonu
{
    public partial class Form1 : Form
    {
        ArrayList kolA = new ArrayList();
        List<int> kolL = new List<int>();
        Stopwatch km = new Stopwatch();
        int elemansayisi = 100000;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAEkle_Click(object sender, EventArgs e)
        {
            km.Start();
            for (int i = 0; i<elemansayisi; i++)
            {
                kolA.Add(i);
            }
            km.Stop();
            lblAEkle.Text = "= " +
            km.Elapsed.TotalMilliseconds;
            km.Reset();
        }

        private void btnLEkle_Click(object sender, EventArgs e)
        {
            km.Start();
            for (int i = 0; i < elemansayisi; i++)
            {
                kolL.Add(i);
            }
            km.Stop();
            lblLEkle.Text = "= " +
            km.Elapsed.TotalMilliseconds;
            km.Reset();
        }

        private void btnATopla_Click(object sender, EventArgs e)
        {
            km.Start();
            int toplam = 0;
            for (int i = 0; i < kolA.Count; i++)
            {
                toplam += (int)kolA[i];
            }
            km.Stop();
            lblATopla.Text = "= " +
            km.Elapsed.TotalMilliseconds;
            km.Reset();
        }

        private void btnLTopla_Click(object sender, EventArgs e)
        {
            km.Start();
            int toplam = 0;
            for (int i = 0; i < kolL.Count; i++)
            {
                toplam += (int)kolL[i];
            }
            km.Stop();
            lblLTopla.Text = "= " +
            km.Elapsed.TotalMilliseconds;
            km.Reset();
        }

        private void btnAYaz_Click(object sender, EventArgs e)
        {
            km.Start();
            for(int i = 0;i < elemansayisi; i++)
            {
                listeA.Items.Add(kolA[i]);
            }
            km.Stop();
            lblAYaz.Text = "= " +
                km.Elapsed.TotalMilliseconds;
            km.Reset();
        }

        private void btnLYaz_Click(object sender, EventArgs e)
        {
            km.Start();
            for (int i = 0; i < elemansayisi; i++)
            {
                listeL.Items.Add(kolL[i]);
            }
            km.Stop();
            lblLYaz.Text = "= " +
                km.Elapsed.TotalMilliseconds;
            km.Reset();
        }

        private void btnABul_Click(object sender, EventArgs e)
        {
            km.Start();
            if(kolA.Contains(9999))
            {
                km.Stop();
            }
            lblABul.Text = "= " +
                km.Elapsed.TotalMilliseconds;
            km.Reset();
        }

        private void btnLBul_Click(object sender, EventArgs e)
        {
            km.Start();
            if(kolL.Contains(9999))
            {
                km.Stop();
            }
            lblLBul.Text = "= " +
                km.Elapsed.TotalMilliseconds;
            km.Reset();
        }
    }
}
