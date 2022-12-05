using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_1___HESAP_MAKİNESİ
{
    public partial class Form1 : Form
    {
       
        private string _islem;
        private bool _ekranTemizlenecekmi;
        private int _ilkSayi;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRakam1_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                lblEkran.Text = "";
                _ekranTemizlenecekmi = false;
            }
            if (lblEkran.Text == "0") 
            {
                lblEkran.Text = "";
            }
            lblEkran.Text += "1";
        }

        private void btnRakam2_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                lblEkran.Text = "";
                _ekranTemizlenecekmi = false;
            }
            if (lblEkran.Text == "0") 
            {
                lblEkran.Text = "";
            }
            lblEkran.Text += "2";
        }

        private void btnRakam3_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                lblEkran.Text = "";
                _ekranTemizlenecekmi = false;

            }
            if (lblEkran.Text == "0") 
            {
                lblEkran.Text = "";
            }
            lblEkran.Text += "3";
        }

        private void btnRakam4_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                lblEkran.Text = "";
                _ekranTemizlenecekmi = false;

            }
            if (lblEkran.Text == "0") 
            {
                lblEkran.Text = "";
            }
            lblEkran.Text += "4";
        }

        private void btnRakam5_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                lblEkran.Text = "";
                _ekranTemizlenecekmi = false;

            }
            if (lblEkran.Text == "0") 
            {
                lblEkran.Text = "";
            }
            lblEkran.Text += "5";
        }

        private void btnRakam6_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                lblEkran.Text = "";
                _ekranTemizlenecekmi = false;

            }
            if (lblEkran.Text == "0") 
            {
                lblEkran.Text = "";
            }
            lblEkran.Text += "6";
        }

        private void btnRakam7_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                lblEkran.Text = "";
                _ekranTemizlenecekmi = false;

            }
            if (lblEkran.Text == "0") 
            {
                lblEkran.Text = "";
            }
            lblEkran.Text += "7";
        }

        private void btnRakam8_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                lblEkran.Text = "";
                _ekranTemizlenecekmi = false;

            }
            if (lblEkran.Text == "0") 
            {
                lblEkran.Text = "";
            }
            lblEkran.Text += "8";
        }

        private void btnRakam9_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                lblEkran.Text = "";
                _ekranTemizlenecekmi = false;

            }
            if (lblEkran.Text == "0") 
            {
                lblEkran.Text = "";
            }
            lblEkran.Text += "9";
        }

        private void btnRakam0_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                lblEkran.Text = "";
                _ekranTemizlenecekmi = false;

            }
            if (lblEkran.Text == "0") 
            {
                lblEkran.Text = "";
            }
            lblEkran.Text += "0";
        }

        private void btnToplama_Click(object sender, EventArgs e)
        {
            _islem = "+";
            _ekranTemizlenecekmi = true;
            _ilkSayi = Convert.ToInt32(lblEkran.Text);
        }

        private void btnEşittir_Click(object sender, EventArgs e)
        {
            int ikinciSayi = Convert.ToInt32(lblEkran.Text);
            int sonuç;
            switch (Convert.ToChar(_islem))
            {
                case '+':
                    sonuç = _ilkSayi + ikinciSayi;
                    break;
                case '-':
                    sonuç = _ilkSayi - ikinciSayi;
                    break;
                case '*':
                    sonuç = _ilkSayi * ikinciSayi;
                    break;
                case '/':
                    sonuç = _ilkSayi / ikinciSayi;
                    break;
                default:
                    sonuç = 0;
                        break;
            }
            lblEkran.Text = Convert.ToString(sonuç);
        }

        private void btnÇıkarma_Click(object sender, EventArgs e)
        {
            _islem = "-";
            _ekranTemizlenecekmi = true;
            _ilkSayi = Convert.ToInt32(lblEkran.Text);
        }

        private void btnÇarpma_Click(object sender, EventArgs e)
        {
            _islem = "*";
            _ekranTemizlenecekmi = true;
            _ilkSayi = Convert.ToInt32(lblEkran.Text);
        }

        private void btnBölme_Click(object sender, EventArgs e)
        {
            _islem = "/";
            _ekranTemizlenecekmi = true;
            _ilkSayi = Convert.ToInt32(lblEkran.Text);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lblEkran.Text = "0";
        }
    }
}
