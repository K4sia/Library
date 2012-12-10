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
    public partial class LOGIN : Form
    {
        private DBConnect dbConnect;
        public LOGIN()
        {
            InitializeComponent();
            dbConnect = new DBConnect();
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;
            List<string>[] list;

            if (user == "")
            {
                MessageBox.Show("wpisz login");
            }
            else if (pass == "")
            {
                MessageBox.Show("wpisz haslo");
            }
            else if (user == "" && pass == "")
            {
                MessageBox.Show("wpisz login i haslo");
            }
            else
            {
                list = dbConnect.Login(user, pass);

                //MessageBox.Show(list[1][0]);
                //MessageBox.Show(list[0].Count().ToString());

                if (list[0].Count() == 0)
                {
                    MessageBox.Show("nie znaleziono uytkownika\nbadz haslo jest niepoprawne");
                }

                else if (list[0].Count() == 1)
                {
                    if (list[1][0] == "1")
                    {
                        //MessageBox.Show("admin");
                        this.Hide();
                        Form1 admin = new Form1();
                        admin.ShowDialog();
                        
                    }
                    else if (list[1][0] == "2")
                    {
                        //MessageBox.Show("user");
                        this.Hide();
                        UZYTKOWNIK uz = new UZYTKOWNIK();
                        uz.Show();
                    }


                }

            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                string user = textBox1.Text;
                string pass = textBox2.Text;
                List<string>[] list;

                if (user == "")
                {
                    MessageBox.Show("wpisz login");
                }
                else if (pass == "")
                {
                    MessageBox.Show("wpisz haslo");
                }
                else if (user == "" && pass == "")
                {
                    MessageBox.Show("wpisz login i haslo");
                }
                else
                {
                    list = dbConnect.Login(user, pass);

                    //MessageBox.Show(list[1][0]);
                    //MessageBox.Show(list[0].Count().ToString());

                    if (list[0].Count() == 0)
                    {
                        MessageBox.Show("nie znaleziono uytkownika\nbadz haslo jest niepoprawne");
                    }

                    else if (list[0].Count() == 1)
                    {
                        if (list[1][0] == "1")
                        {
                            //MessageBox.Show("admin");
                            this.Hide();
                            Form1 admin = new Form1();
                            admin.ShowDialog();

                        }
                        else if (list[1][0] == "2")
                        {
                            //MessageBox.Show("user");
                            this.Hide();
                            UZYTKOWNIK uz = new UZYTKOWNIK();
                            uz.Show();
                        }


                    }

                }



            }
        }
    }
}
