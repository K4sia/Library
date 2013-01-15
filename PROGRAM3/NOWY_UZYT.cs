using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Web.Security;


namespace ConnectCsharpToMysql
{
    

    public partial class NOWY_UZYT : Form
    {
        public static string hashedPwdglobal;

        private DBConnect dbConnect;
        public NOWY_UZYT()
        {
            
            InitializeComponent();
            dbConnect = new DBConnect();

        }

        private static string CreateSalt(int size)
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buff = new byte[size];
            rng.GetBytes(buff);
            return Convert.ToBase64String(buff);
        }

        private static string CreatePasswordHash (string pwd, string salt)
        {
            string saltandPwd = String.Concat(pwd, salt);
            string hashedPwd = FormsAuthentication.HashPasswordForStoringInConfigFile(saltandPwd, "sha1");
            hashedPwdglobal = hashedPwd;
            return hashedPwd;
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idauthority = 2;
            string imie = textBox1.Text;
            string nazwisko = textBox2.Text;
            string pesel = textBox3.Text;
            string login = textBox4.Text;
            CreatePasswordHash(pesel,CreateSalt(0));
            
            //var hasloarr = System.Text.Encoding.UTF8.GetBytes(haslo);

            int limit = 5;
            int wypoz = 0;
            List<string>[] list;
            int zm =0;

            if (imie == "")
            {
                MessageBox.Show("wpisz imie");
            }
            else if (nazwisko == "")
            {
                MessageBox.Show("wpisz nazwisko");
            }
            else if (pesel == "")
            {
                MessageBox.Show("wpisz pesel");
            }
            else if (login == "")
            {
                MessageBox.Show("wpisz login");
            }
            else 
            {
                list = dbConnect.CheckPesel(pesel);
                for (int zmienna = 0; zmienna < list[0].Count(); zmienna++)
                {
                    if (list[0][zmienna].ToString() == pesel)
                    {
                        MessageBox.Show("W bazie wystepuje juz uzytkownik z takim peselem");
                    }
                    else
                    {
                        if (zm == list[0].Count()-1)
                            {
                                dbConnect.InsertUsers(idauthority, imie, nazwisko, pesel, limit, wypoz, login, hashedPwdglobal);
                                MessageBox.Show("Dodano użytkownika");
                                this.Close();
                            }
                        zm++;
                    }
                }
            }
        }


        private void Nowy_uzytkownik_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
