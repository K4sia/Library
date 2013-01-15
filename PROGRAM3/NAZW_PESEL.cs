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
    public partial class pesel : Form
    {
        private DBConnect dbconnect;
        Form5 form5;
        List<string>[] list;
        public pesel(Form5 form5)
        {
            this.form5 = form5;
            InitializeComponent();
            dbconnect = new DBConnect();
        }
        public string haselko
        {
            get
            {
                return textBox2.Text;
            }
        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        int zm;
        private void button2_Click(object sender, EventArgs e)
        {
            string surname = textBox1.Text;
            string haslo = textBox2.Text;
            list = dbconnect.CHECKUSER(surname, haslo);
            if (haslo == "")
            {
                MessageBox.Show("wpisz pesel");
            }
            else if (surname == "")
            {
                MessageBox.Show("wpisz nazwisko");
            }
            else
            {
                zm = 0;
                for (int zmienna = 0; zmienna < list[0].Count(); zmienna++)
                {
                    if (list[0][zmienna] == surname && list[1][zmienna] == haslo)
                    {
                        MessageBox.Show("Istnieje taki użytkownik");
                    }
                    else
                    {
                        if (zm == list[0].Count() - 1)
                        {
                            MessageBox.Show("Nie ma takiego użytkownika");
                        }
                        zm++;
                    }
                }
            }
        }

        
    }
}
