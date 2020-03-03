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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int sure = 201;
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            hesap hesap = new hesap();
            hesap.MdiParent = this;
            hesap.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ehliyet ehliyet = new ehliyet();
            ehliyet.MdiParent = this;
            ehliyet.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timersure.Start();
        }

        private void timersure_Tick(object sender, EventArgs e)
        {
            sure--;
            tblsure.Text = sure / 60 + ":" + sure % 60;
            progbar.Value = sure;
            if (sure == 0)
            {
                timersure.Stop();
                this.Close();
            }
        }

        private void gösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();

        }

        private void gizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void contextMenuStrip1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.Visible == false)
            {
                this.Show();

            }
            else
            {
                this.Hide();
            }
        }
    }
}
