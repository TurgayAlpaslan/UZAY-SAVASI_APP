using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Uzay_Savaşı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Cisim> cisimler = new List<Cisim>();
            Cisim c1 =new Cisim();
            c1.X=100;
            c1.Y=300;
            c1.Genislik=50;
            c1.Yukseklik=20;
            cisimler.Add(c1);
            c1.CisimTuru = CisimTurleri.SavasSahin;

            Cisim c2 = new Cisim();
            c1.X = 500;
            c1.Y = 600;
            c1.Genislik = 50;
            c1.Yukseklik = 10;
            cisimler.Add(c2);
            c2.CisimTuru = CisimTurleri.Bocek;
            //int a = (int)c1.CisimTuru; Seklinde olabilir.

            
        }
    }
}
