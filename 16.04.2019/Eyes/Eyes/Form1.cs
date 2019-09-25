using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Eyes
{
    public partial class Form1 : Form
    {
        static int img;

        List<Bitmap> list = new List<Bitmap> {
            Eyes.Properties.Resources.Eye1,
            Eyes.Properties.Resources.Eye2,
            Eyes.Properties.Resources.Eye3,
            Eyes.Properties.Resources.Eye4,
            Eyes.Properties.Resources.Eye5,
            Eyes.Properties.Resources.Eye6
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            //for (int i = 1; i <= 6; i++)"" + i
                //list.Add(Eyes.Properties.Resources.Eye1);
                //list.Add(new Bitmap(GetType(), "Eyes._" + 1));
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (img>5)
            {
                img = 0;
            }

            e.Graphics.DrawImage(list[img++], new Point(10, 10));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
