using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConnectCsharpToMysql
{
    public partial class Form5 : Form
    {
        private DBConnect dbConnect;
        Form1 frm1 = new Form1();
        
        public Form5()
        {
            InitializeComponent();
            dbConnect = new DBConnect();
                        
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            // dopisujemy do zmiennych wartosci z pol i dodadjemy swoje, stale zmienne
            // bo dla plyt = 1
            string title_ed = frm1.tutul;
            string name_ed = frm1.autor;
            string av_ed = frm1.available;
            string res_ed = frm1.reserved;

            string title = textBox1.Text;
            string name = textBox2.Text;
            string av = textBox4.Text;
            string res = textBox3.Text;

            dbConnect.Update1(title, name, av, res, title_ed, name_ed, av_ed, res_ed);

            this.Close();

            MessageBox.Show("Dodano poprawnie");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(frm1.autor);
        }


     }
}
