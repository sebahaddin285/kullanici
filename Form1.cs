using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kullanici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(giris.Text =="" && sifre.Text == "")
            {
                MessageBox.Show("kullanıcı adı veya sifre boş bırakılamaz");
                return;
            }
            if(giris.Text == ayarlar.Default.kadi && sifre.Text == ayarlar.Default.sifre)
            {
                if (hatirla.Checked)
                {
                    ayarlar.Default.hatirla = 1;
                    ayarlar.Default.Save();
                }
                else
                {
                    ayarlar.Default.hatirla = 0;
                    ayarlar.Default.Save();
                }
                Form2 form = new Form2();
                form.Show();
                this.Hide();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (sifree.Checked)
            {
                sifre.PasswordChar = '\0';
            }
            else
            {
                sifre.PasswordChar = '*';
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (ayarlar.Default.hatirla == 1)
            {
                giris.Text = ayarlar.Default.kadi;
                sifre.Text = ayarlar.Default.sifre;
                hatirla.Checked = true;
            }
        }
    }
}
