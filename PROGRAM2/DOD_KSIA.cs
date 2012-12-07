using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConnectCsharpToMysql
{
    public partial class Form3 : Form
    {
        private DBConnect dbConnect;

        public Form3()
        {
            InitializeComponent();
            dbConnect = new DBConnect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // dopisujemy do zmiennych wartosci z pol i dodadjemy swoje, stale zmienne
            // bo dla ksiazek = 
            int id_kind = 2;
            string title = textBox1.Text;
            string name = textBox2.Text;
            string av = "Y";
            string res = "N";
             if (title == "" && name == "")
                MessageBox.Show("Prosze podac dane");
            else if (title == "")
                MessageBox.Show("Prosze podac tutul");
             else if (name == "")
                 MessageBox.Show("Prosze podac autora");
             else
             {

                 dbConnect.Insert(id_kind, title, name, av, res);

                 this.Close();

                 MessageBox.Show("Dodano poprawnie");
             }
        }
    }
}
