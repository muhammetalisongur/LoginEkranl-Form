using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uyg3WinForm2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //girilen degerleri al
            string kAdi=textBox1.Text;
            string kSifre = textBox2.Text;

            
            //kontrol et
            if (kAdi=="admin"&&kSifre=="123")
            {
                //form2 yi ac
                //form2 classindan bir nesne turet ve goster
                //sinif nesne=new sinif();
                Form2 frm2=new Form2();
                frm2.Show();
                label3.Text = "Basarili Giris yaptiniz";
                //buton if gerceklesirse butonu islevini iptal edebiliriz
                //button1.Enabled = false;
                //yada form1 gizleyebiliriz
                this.Hide();
            }
            else
                label3.Text = "Kullanici adi veya sifreniz yanlis";

        }
    }
}
