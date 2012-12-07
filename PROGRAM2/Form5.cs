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

        public string title_ed;
        public string name_ed;
        public string av_ed;
        public string res_ed;

        public Form5(string autor, string tutul, string available, string reserved)
        {
            InitializeComponent();
            dbConnect = new DBConnect();
            //koncowka _ed oznacza = ta do edytowania (oryginalna zmienna)
            //do pola i zmiennej publicznej dopisujemy oryginalny tytul i autora
            label2.Text = title_ed = autor;
            label3.Text = name_ed = tutul;
            //zaznaczamy checkboxy, jezeli ksiazka jest wypozyczona i dostepna
            if (available == "Y")
                checkBox1.Checked = true;
            else checkBox1.Checked = false;
            if (reserved == "Y")
                checkBox2.Checked = true;
            else checkBox2.Checked = false;

            //przypisujemy wypozyczenie do zmiennych publicznych, aby je pozniej wykorzystac przy wypozyczaniu
            av_ed = available;
            res_ed = reserved;

            //MessageBox.Show(title_ed + " " + name_ed + " " + av_ed + " " + res_ed);
        }

        //po kliknieciu edytuj
        public void button1_Click(object sender, EventArgs e)
        {
            string title = textBox8.Text;
            string name = textBox7.Text;
            
            //zmienne przesylane do update - pierwsze 4 to nowe zmienna, zebrane z pol tekstowych, ostatnie 4 to zmienne ktore
            //musimy przeniesc z zaznaczonego rzedu z Form1, abo pokazac co trzeba zmienic
            dbConnect.Update(title, name, title_ed, name_ed);

            this.Close();

            MessageBox.Show("Edycja wykonana poprawnie");
            this.Close();
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (res_ed == "Y")
                MessageBox.Show(title_ed +" "+ name_ed + " jest w rezerwacji");
            else
            {
                string res = "Y";
                dbConnect.Rezerwuj(res, title_ed, name_ed);
                MessageBox.Show(title_ed + " " + name_ed + " zarezerowowano poprawnie");
                this.Close();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (res_ed == "N")
                MessageBox.Show(title_ed + " " + name_ed + " jest dostepna");
            else
            {
                string res = "N";
                dbConnect.Rezerwuj(res,  title_ed, name_ed);
                MessageBox.Show(title_ed +" "+ name_ed + " oddano poprawnie");
                this.Close();
            }
        }


     }
}
