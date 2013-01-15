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

        string user = UZYTKOWNIK.user;
        string pass = UZYTKOWNIK.pass;

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

                //string dos = "N";
                //dbConnect.Wypozycz(dos, title_ed, name_ed);
               // MessageBox.Show(title_ed + " " + name_ed + " wypozyczono poprawnie");
               // this.Close();

                // sprawdzam Id_uzyt
                List<string>[] list;
                list = dbConnect.ZalUzyt(user, pass);
                //sprawdzam id_res
                List<string>[] list1;
                list1 = dbConnect.id_res(title_ed, name_ed);

                int id_user = Convert.ToInt32(list[0][0]);
                int id_res = Convert.ToInt32(list1[0][0]);

                if (res_ed == "N")
                {
                    MessageBox.Show("Dany element nie został zarezerwowany");
                }

                else if (av_ed == "N")
                {
                    MessageBox.Show("Dany element jest niedostępny");
                }

                else if (res_ed == "Y" && av_ed == "Y")
                {
                    // sprawdzanie limitu ksiązek uzytkownika
                    List<string>[] list2;
                    list2 = dbConnect.AoF(id_user);
                    string limit1 = list2[1][0].ToString();
                    int limit = System.Convert.ToInt32(limit1);
                    if (list2[0][0].ToString() == limit1)
                    {
                        MessageBox.Show("Użytkownik przekroczył limit wypożyczeń");
                    }
                    else
                    {
                        DateTime time = DateTime.Now;
                        DateTime czas = time.AddDays(3);

                        //string czasmysql = time.ToString("yyy-MM-dd HH:mm:ss");
                        //string czasmysql2 = czas.ToString("yyy-MM-dd HH:mm:ss");

                        string rezstring = list2[0][0].ToString();
                        int rez = System.Convert.ToInt32(rezstring) + 1;
                        string av = "Y";
                        dbConnect.Dodajlimit(rez, id_user);
                        dbConnect.RezerwujDoRU(id_res, id_user, time, czas);
                        dbConnect.Rezerwuj(av, title_ed, name_ed);
                        MessageBox.Show(title_ed + " " + name_ed + " wypożyczono poprawnie ");
                        this.Close();
                    }
                }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (res_ed == "N")
                MessageBox.Show(title_ed + " " + name_ed + " jest dostępna");
            else
            {
                string res = "N";
                dbConnect.Rezerwuj(res, title_ed, name_ed);
                
                MessageBox.Show(title_ed + " " + name_ed + " oddano poprawnie");
                this.Close();
            }
        }


    }
}