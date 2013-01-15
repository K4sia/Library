using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConnectCsharpToMysql
{
    public partial class START : Form
    {
        public START()
        {
            InitializeComponent();
            //DateTime time = DateTime.Now;
            //string czasmysql = time.ToString("yyy-MM-dd HH:mm:ss");
            //DateTime czas = time.AddDays(1);
            //MessageBox.Show(time + " " + czasmysql + " ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LOGIN frm5 = new LOGIN();
            frm5.Show();
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
