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
    public partial class KONTO_USERS : Form
    {
        private DBConnect dbConnect;
        //UZYTKOWNIK uzyt;
        string haslo;
        string login;
        public KONTO_USERS(string log , string pass)
        {
            InitializeComponent();
            dbConnect = new DBConnect();
            login= log;
            haslo = pass;
        }

        

        private void KONTO_USERS_Load(object sender, EventArgs e)
        {

        }

        private void dgDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ążkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string>[] list;
            list = dbConnect.ZalUzyt(login,haslo);
            string id_uzyt = list[0][0].ToString();
            int idUzyt = System.Convert.ToInt32(id_uzyt);
            List<string>[] list1;
            list1 = dbConnect.IleKsiazek(idUzyt);
            
            dgDisplay.Rows.Clear();
            for (int i = 0; i < list1[0].Count; i++)
            {
                int number = dgDisplay.Rows.Add();
                dgDisplay.Rows[number].Cells[0].Value = list1[0][i];
                dgDisplay.Rows[number].Cells[1].Value = list1[1][i];

            }
            //MessageBox.Show("Znaleziono " + list1[0].Count + " wyników");
        }

        private void filmyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string>[] list;
            list = dbConnect.ZalUzyt(login, haslo);
            string id_uzyt = list[0][0].ToString();
            int idUzyt = System.Convert.ToInt32(id_uzyt);
            List<string>[] list1;
            list1 = dbConnect.IleFilmow(idUzyt);

            dgDisplay.Rows.Clear();
            for (int i = 0; i < list1[0].Count; i++)
            {
                int number = dgDisplay.Rows.Add();
                dgDisplay.Rows[number].Cells[0].Value = list1[0][i];
                dgDisplay.Rows[number].Cells[1].Value = list1[1][i];

            }
            //MessageBox.Show("Znaleziono " + list1[0].Count + " wyników");
        }

        private void płytyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string>[] list;
            list = dbConnect.ZalUzyt(login, haslo);
            string id_uzyt = list[0][0].ToString();
            int idUzyt = System.Convert.ToInt32(id_uzyt);
            List<string>[] list1;
            list1 = dbConnect.IlePlyt(idUzyt);

            dgDisplay.Rows.Clear();
            for (int i = 0; i < list1[0].Count; i++)
            {
                int number = dgDisplay.Rows.Add();
                dgDisplay.Rows[number].Cells[0].Value = list1[0][i];
                dgDisplay.Rows[number].Cells[1].Value = list1[1][i];

            }
            //MessageBox.Show("Znaleziono " + list1[0].Count + " wyników");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
