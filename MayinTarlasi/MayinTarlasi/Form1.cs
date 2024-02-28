using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayinTarlasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[,] mayin; Button[,] buttonlar;
        private void btnBasla_Click(object sender, EventArgs e)
        {
            mayin = new int[10, 10];
            buttonlar = new Button[10, 10];
            int k, l;
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                do
                {
                    k = rnd.Next(10);
                    l = rnd.Next(10);
                } while (mayin[k, l] == -1);
                mayin[k, l] = -1;
            }

            for (int i = 0; i < mayin.GetLength(0); i++)
            {
                for (int j = 0; j < mayin.GetLength(1); j++)
                {
                    if (mayin[i, j] != -1)
                    {
                        for (int m = i - 1; m <= i + 1; m++)
                        {
                            for (int n = j - 1; n <= j + 1; n++)
                            {
                                if (m > -1 && n > -1 && m < 10 && n < 10 && mayin[m, n] == -1)
                                    mayin[i, j] += 1;
                            }
                        }
                    }
                }
            }

            panel2.Controls.Clear();
            panel2.Enabled = true;
            for (int i = 0; i < mayin.GetLength(0); i++)
            {
                for (int j = 0; j < mayin.GetLength(1); j++)
                {
                    Button btn = new Button();
                    btn.Location = new Point(i * 18, j * 18);
                    btn.Size = new System.Drawing.Size(18, 18);
                    btn.Click += new EventHandler(btn_Click);
                    btn.MouseDown += new MouseEventHandler(btn_MouseDown);
                    btn.FlatStyle = FlatStyle.Flat;
                    panel2.Controls.Add(btn);
                    btn.ImageList = imageList1;
                    btn.ImageIndex = 0;
                    buttonlar[i, j] = btn;

                    Label lbl = new Label();
                    lbl.Location = btn.Location;
                    lbl.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    lbl.Size = btn.Size;
                    lbl.BorderStyle = BorderStyle.Fixed3D;
                    lbl.Text = (mayin[i, j] != 0 ? mayin[i, j].ToString() : "");

                

                switch (mayin[i, j])
                {
                    case 1:
                        lbl.ForeColor = Color.Blue;
                        break;
                    case 2:
                        lbl.ForeColor = Color.Green;
                        break;
                    case 3:
                        lbl.ForeColor = Color.Red;
                        break;
                    default:
                        break;
                }
                panel2.Controls.Add(lbl);
            }
        }
        }
        void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Visible = false;
            int sayi = mayin[btn.Location.X / 18, btn.Location.Y / 18];
            if (sayi == -1)
            {
                MessageBox.Show("Oyun Bitti");
                //panel2.Enabled = false;
                for (int i = 0; i < panel2.Controls.Count; i++)
                {
                    if (panel2.Controls[i] is Button)
                        //panel2.Controls[i].Enabled = false;
                        panel2.Controls[i].Click -= btn_Click;
                }
            }
            else if (sayi == 0)
                EtrafiniTemizle(btn.Location.X / 18, btn.Location.Y / 18);

        }

        void btn_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                btn.PerformClick();
            }
            else if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (btn.ImageIndex == 0)
                {
                    btn.Click -= btn_Click;
                    btn.ImageIndex = 1;
                }
                else
                {
                    btn.Click += btn_Click;
                    btn.ImageIndex = 0;
                }
            }
        }
        void EtrafiniTemizle(int i, int j)
        {
            for (int m = i - 1; m <= i + 1; m++)
            {
                for (int n = j - 1; n <= j + 1; n++)
                {
                    if (m > -1 && n > -1 && m < 10 && n < 10 && buttonlar[m, n].Visible && buttonlar[m, n].ImageIndex == 0)
                    {
                        buttonlar[m, n].Visible = false;
                        if (mayin[m, n] == 0)
                            EtrafiniTemizle(m, n);
                    }
                }
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btnBasla_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}