using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class frmHesapMakinesi : Form
    {
        string islem; double sonuc; bool operatoreTiklandi;
        public frmHesapMakinesi()
        {
            InitializeComponent();
        }

        

        private void IslemYap(string YapilacakIslem)
        {
           
            double ekran = double.Parse(txtEkran.Text);

            if (islem == "+")
                sonuc += ekran;
            else if (islem == "-")
                sonuc -= ekran;
            else if (islem == "*")
                sonuc *= ekran;
            else if (islem == "/")
                sonuc /= ekran;
            else
                sonuc = ekran;

            islem = YapilacakIslem;
            txtEkran.Text = sonuc.ToString();
            operatoreTiklandi = true;
        }
        
        private void btnEsit_Click(object sender, EventArgs e)
        {
               
            IslemYap("=");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            islem = string.Empty;
            txtEkran.Text = "";
            operatoreTiklandi = false;
            sonuc = 0;
        }
        // keypress event'i text'e bir tuş basıldığında çalışan eventtir.
        // e.KeyChar ile hangi karaktere basıldığını ascii karşılıgını bulur
        private void txtEkran_KeyPress(object sender, KeyPressEventArgs e)
        {
            string decimalSeperator = System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
            if (!Char.IsDigit(e.KeyChar))
            {

                if ((e.KeyChar.ToString() == decimalSeperator && txtEkran.Text.IndexOf(decimalSeperator) == -1) || e.KeyChar == '\b')
                    e.Handled = false;
                else
                {
                    if (e.KeyChar == '+' || e.KeyChar == '-' || e.KeyChar == '*' || e.KeyChar == '/' || e.KeyChar == '=' || e.KeyChar == '\r')
                        IslemYap(e.KeyChar.ToString());

                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
                SayiYaz(e.KeyChar.ToString());
            }
        }

        private void btnbolu_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            IslemYap(btn.Text);
        }

        private void btnSayi_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            SayiYaz(btn.Text);
        }
        private void SayiYaz(string Sayi)
        {
            if (operatoreTiklandi)
            {
                txtEkran.Text = Sayi;
                operatoreTiklandi = false;
            }
            else
                txtEkran.Text += Sayi;
        }

        private void btnİslem(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            IslemYap(btn.Text);
        }
    }
}
