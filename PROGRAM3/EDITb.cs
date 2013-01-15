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
    public partial class EDITb : Form
    {

        private DBConnect dbConnect;
     //   UZYTKOWNIK frm1 = new UZYTKOWNIK(user, passkonto);
        string user =UZYTKOWNIK.user;
        string pass = UZYTKOWNIK.pass;

        public string title_ed;
        public string name_ed;
        public string av_ed;
        public string res_ed;

        public EDITb(string autor, string tutul, string available, string reserved)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2uz_Click(object sender, EventArgs e)
        {
            // sprawdzam Id_uzyt
            List<string>[] list;
            list = dbConnect.ZalUzyt(user, pass);
            //sprawdzam id_res
            List<string>[] list1;
            list1 = dbConnect.id_res(title_ed, name_ed);

            int id_user = Convert.ToInt32(list[0][0]);
            int id_res = Convert.ToInt32(list1[0][0]);

            if (res_ed == "Y")
            {
                MessageBox.Show("Książka zarezerwowana");
            }
            else if (av_ed == "N")
            {
                MessageBox.Show("Ksiązka wypożyczona");
            }
            else
            {
                // sprawdzanie limitu ksiązek uzytkownika
                List<string>[] list2;
                list2 = dbConnect.AoF(id_user);
                string limit1 = list2[1][0].ToString();
                int limit = System.Convert.ToInt32(limit1);
                if (list2[0][0].ToString() == limit1)
                {
                    MessageBox.Show("Wykorzystałeś limit wypożyczonych artykułów");
                }
                else
                {
                    //DateTime time = DateTime.Now;
                    //DateTime czas = time.AddDays(1);

                    //string czasmysql = time.ToString("yyy-MM-dd HH:mm:ss");
                    //string czasmysql2 = czas.ToString("yyy-MM-dd HH:mm:ss");

                    //string rezstring = list2[0][0].ToString();
                    //int rez = System.Convert.ToInt32(rezstring) + 1;
                    string res = "Y";
                    //dbConnect.Dodajlimit(rez, id_user);
                    //dbConnect.RezerwujDoRU(id_res, id_user, czasmysql, czasmysql2);
                    dbConnect.Rezerwuj(res, title_ed, name_ed);
                    MessageBox.Show(title_ed + " " + name_ed + " zarezerowowano poprawnie ");
                    this.Close();
                }
            }
        }
    }
}
