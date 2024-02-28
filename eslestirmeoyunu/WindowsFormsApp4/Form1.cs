using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            kutu1.Image = imageList1.Images[5];
            kutu2.Image = imageList1.Images[5];
            kutu3.Image = imageList1.Images[5];
            kutu4.Image = imageList1.Images[5];
            kutu5.Image = imageList1.Images[5];
            kutu6.Image = imageList1.Images[5];
            kutu7.Image = imageList1.Images[5];
            kutu8.Image = imageList1.Images[5];
            kutu9.Image = imageList1.Images[5];
            kutu10.Image = imageList1.Images[5];

       


        }
        int a;
        int b;
        private void genel_box_click(object sender, EventArgs e)
        {
            if(sender==kutu1)
            {
                kutu1.Image = imageList1.Images[0];
                a = geridondur(1);
            }
            else if(sender==kutu6)
            {
                kutu6.Image = imageList1.Images[0];
                b = geridondur(6);
            }
            else if (sender == kutu2)
            {
                kutu2.Image = imageList1.Images[1];
                a = geridondur(2);
            }
            else if (sender == kutu7)
            {
                kutu7.Image = imageList1.Images[1];
                b = geridondur(7);
            }
            else if (sender == kutu3)
            {
                kutu3.Image = imageList1.Images[2];
                a = geridondur(3);
            }
            else if (sender == kutu8)
            {
                kutu8.Image = imageList1.Images[2];
                b = geridondur(8);
            }
            else if (sender == kutu4)
            {
                kutu4.Image = imageList1.Images[3];
                a = geridondur(4);
            }
            else if (sender == kutu9)
            {
                kutu9.Image = imageList1.Images[3];
                b = geridondur(9);
            }
            else if (sender == kutu5)
            {
                kutu5.Image = imageList1.Images[4];
                a = geridondur(5);
            }
            else if (sender == kutu10)
            {
                kutu10.Image = imageList1.Images[4];
                b = geridondur(10);
            }
            

        }
        public int geridondur(int i)
        {
            if (i == 1)
            {
                timer1.Enabled = true;
                return 1;
            }
            if (i == 2)
            {
                timer1.Enabled = true;
                return 2;
            }
            if (i == 3)
            {
                timer1.Enabled = true;
                return 3;
            }
            if (i == 4)
            {
                timer1.Enabled = true;
                return 4;
            }
            if (i == 5)
            {
                timer1.Enabled = true;
                return 5;
            }
            if (i == 6)
            {
                timer1.Enabled = true;
                return 6;
            }
            if (i == 7)
            {
                timer1.Enabled = true;
                return 7;
            }
            if (i == 8)
            {
                timer1.Enabled = true;
                return 8;
            }
            if (i == 9)
            {
                timer1.Enabled = true;
                return 9;
            }
            if (i == 10)
            {
                timer1.Enabled = true;
                return 10;
            }
            return 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (a == 1 && b == 6)
            {
                kutu1.Visible = false;
                kutu6.Visible = false;
            }
            else if (a == 2 && b == 7)
            {
                kutu2.Visible = false;
                kutu7.Visible = false;
            }
            else if (a == 3 && b == 8)
            {
                kutu3.Visible = false;
                kutu8.Visible = false;
            }
            else  if (a == 4 && b == 9)
            {
                kutu4.Visible = false;
                kutu9.Visible = false;
            }
            else if (a == 5 && b == 10)
            {
                kutu5.Visible = false;
                kutu10.Visible = false;
            }
            else
            {
                timer2.Enabled = true;
            }
        }

        private void timer2_click(object sender, EventArgs e)
        {
            kutu1.Image = imageList1.Images[5];
            kutu2.Image = imageList1.Images[5];
            kutu3.Image = imageList1.Images[5];
            kutu4.Image = imageList1.Images[5];
            kutu5.Image = imageList1.Images[5];
            kutu6.Image = imageList1.Images[5];
            kutu7.Image = imageList1.Images[5];
            kutu8.Image = imageList1.Images[5];
            kutu9.Image = imageList1.Images[5];
            kutu10.Image = imageList1.Images[5];
        }

        private void oyunaBaşlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kutu1.Image = imageList1.Images[5];
            kutu2.Image = imageList1.Images[5];
            kutu3.Image = imageList1.Images[5];
            kutu4.Image = imageList1.Images[5];
            kutu5.Image = imageList1.Images[5];
            kutu6.Image = imageList1.Images[5];
            kutu7.Image = imageList1.Images[5];
            kutu8.Image = imageList1.Images[5];
            kutu9.Image = imageList1.Images[5];
            kutu10.Image = imageList1.Images[5];

            kutu1.Visible = true;
            kutu2.Visible = true;
            kutu3.Visible = true;
            kutu4.Visible = true;
            kutu5.Visible = true;
            kutu6.Visible = true;
            kutu7.Visible = true;
            kutu8.Visible = true;
            kutu9.Visible = true;
            kutu10.Visible = true;

            timer1.Enabled = false;
            timer2.Enabled = false;
        }

        private void ayarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();// direk cıkıs yapıyor . eger form closing içinde de cıkıs fonksiyonu varsa onu da yapar.
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) // kapatma işlemi yapıyor
        {
            DialogResult dr = MessageBox.Show("Gerçekten oyunu kapatmak istiyor musunuz?", "Closing event", MessageBoxButtons.YesNo);

            if (dr == DialogResult.No)
                e.Cancel = true;
            else
                e.Cancel = false;
        }

        private void kolayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ImageList im = new ImageList();// yeni bir imagelist olustrdum          
            //im.ImageSize = new Size(128, 128);
            List<Image> m_list = new List<Image>();
            Random r = new Random();
            int[] a = new int [10];
            int b = 0;
            int c = 0;
            int d = 0;
            int h = 0;
            int f = 0;
       
            for (int i= 0; i < 10; i++)
            {
                AA:
                a[i] = r.Next(0, 5);
                if (b < 2)
                {
                    if (a[i] == 0)
                    {
                        b++;
                        m_list.Add(imageList1.Images[a[i]]) ;

                        //kutu1.Image = imageList1.Images[a[i]];                        
                    }
                }
                 if(c<2)
                {
                    if (a[i] == 1)
                    {
                        c++;
                        m_list.Add(imageList1.Images[a[i]]);
                        //kutu1.Image = imageList1.Images[a[i]];
                    }
                }
                if (d < 2)
                {
                    if (a[i] == 2)
                    {
                        d++;
                        m_list.Add(imageList1.Images[a[i]]);
                        //kutu1.Image = imageList1.Images[a[i]];
                    }
                }
                if (h < 2)
                {
                    if (a[i] ==3)
                    {
                        h++;
                        m_list.Add(imageList1.Images[a[i]]);
                        //kutu1.Image = imageList1.Images[a[i]];
                    }
                }
                if (f < 2)
                {
                    if (a[i] == 4)
                    {
                        f++;
                        m_list.Add(imageList1.Images[a[i]]);
                        //kutu1.Image = imageList1.Images[a[i]];
                    }
                }
                if (b == 2&&c==2&&d==2&& h==2&&f==2)
            {
                break;
            }
                goto AA;
            }

            kutu1.Image = m_list[0];
            kutu2.Image = m_list[1];
            kutu3.Image = m_list[2];
            kutu4.Image = m_list[3];
            kutu5.Image = m_list[4];
            kutu6.Image = m_list[5];
            kutu7.Image = m_list[6];
            kutu8.Image = m_list[7];
            kutu9.Image = m_list[8];
            kutu10.Image = m_list[9];

            //kutu1.Image = imageList1.Images[a[0]];
            //kutu2.Image = imageList1.Images[a[1]];
            //kutu3.Image = imageList1.Images[a[2]];
            //kutu4.Image = imageList1.Images[a[3]];
            //kutu5.Image = imageList1.Images[a[4]];
            //kutu6.Image = imageList1.Images[a[5]];
            //kutu7.Image = imageList1.Images[a[6]];
            //kutu8.Image = imageList1.Images[a[7]];
            //kutu9.Image = imageList1.Images[a[8]];
            //kutu10.Image = imageList1.Images[a[9]];
            timer1.Enabled = false;
            timer2.Enabled = false;

        }
    }
}
