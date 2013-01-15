using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web.Security;
using System.Security.Cryptography;

namespace ConnectCsharpToMysql
{
    public partial class LOGIN : Form
    {

        public static string hashedPwdglobal;

        private static string CreateSalt(int size)
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buff = new byte[size];
            rng.GetBytes(buff);

            return Convert.ToBase64String(buff);
        }

        private static string CreatePasswordHash(string pwd, string salt)
        {
            string saltandPwd = String.Concat(pwd, salt);
            string hashedPwd = FormsAuthentication.HashPasswordForStoringInConfigFile(saltandPwd, "sha1");
            hashedPwdglobal = hashedPwd;
            return hashedPwd;
        }

        private DBConnect dbConnect;
        public LOGIN()
        {
            InitializeComponent();
            dbConnect = new DBConnect();
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // zwracanie hasla do EDIT do celow RESOURCES_USER
        
        //double haslo;
        //public void haselko(string pasword)
        //{
        //    haslo = System.Convert.ToDouble(pasword);
        //}
        //public double gethaslo
        //{
        //    get
        //    {
        //        return haslo;
        //    }
        //}
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        List<string>[] list2;        
        private void button1_Click(object sender, EventArgs e)
        {
          
            string user = textBox1.Text;
            string pass = textBox2.Text;

            CreatePasswordHash(pass, CreateSalt(0));

            List<string>[] list;
            
            //haselko(pass);
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
                
                list = dbConnect.Login(user, hashedPwdglobal);
                list2 = dbConnect.ZalUzyt(user, hashedPwdglobal);
                //MessageBox.Show(list[1][0]);
                //MessageBox.Show(list[0].Count().ToString());

                if (list[0].Count() == 0)
                {
                    //Aby podejrzeć kodowanie hasła odkomentuj poniższe
                    //MessageBox.Show(hashedPwdglobal.ToString());
                    MessageBox.Show("nie znaleziono uzytkownika\nbadz haslo jest niepoprawne");
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
                        UZYTKOWNIK uz = new UZYTKOWNIK(user, hashedPwdglobal);
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

                CreatePasswordHash(pass, CreateSalt(0));

                List<string>[] list;

                //haselko(pass);
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

                    list = dbConnect.Login(user, hashedPwdglobal);
                    list2 = dbConnect.ZalUzyt(user, hashedPwdglobal);
                    //MessageBox.Show(list[1][0]);
                    //MessageBox.Show(list[0].Count().ToString());

                    if (list[0].Count() == 0)
                    {
                        //MessageBox.Show(hashedPwdglobal.ToString());
                        MessageBox.Show("nie znaleziono uzytkownika\nbadz haslo jest niepoprawne");
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
                            UZYTKOWNIK uz = new UZYTKOWNIK(user, hashedPwdglobal);
                            uz.Show();
                        }


                    }

                }



            }
        }
    }
}
