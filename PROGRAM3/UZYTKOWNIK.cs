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
    public partial class UZYTKOWNIK : Form
    {
        private DBConnect dbConnect;
        public static string user;
        public static string pass;
        public UZYTKOWNIK(string userkonto , string passkonto)
        {
            
            InitializeComponent();
            dbConnect = new DBConnect();
            user = userkonto;
            pass = passkonto;
        }
        
        public static string tekst;
        private void UZYTKOWNIK_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (wybor == 0 && textBox1.Text == "")
                MessageBox.Show("Wybierz jak chcesz szukac i co chcesz szukac");
            else if (wybor == 0)
                MessageBox.Show("Wpisz jak chcesz szukac");
            else if (textBox1.Text == "")
                MessageBox.Show("Wpisz co cchesz szukac");
            else
            {
                //textBox1.Text = tekst;
                tekst = textBox1.Text;
                //wynosimy co chcemy szukac i jakie nasze kryterium
                // User.search_resources(wybor, tekst);
                // wyswietlamy nasze wyniki wyszukiwan
                List<string>[] list;
                string[] tablica = new string[2];

                tablica = User.search_resources(wybor, tekst);

                list = dbConnect.Select(tablica[0], tablica[1]);
                // list = dbConnect.Select("wybor", tekst);
                //dbConnect.Select("a","b");
                // Select("autor", "aa");
                Console.WriteLine(list[0].Count);
                Console.ReadLine();
                dgDisplay.Rows.Clear();
                for (int i = 0; i < list[0].Count; i++)
                {
                    int number = dgDisplay.Rows.Add();
                    dgDisplay.Rows[number].Cells[0].Value = list[0][i];
                    dgDisplay.Rows[number].Cells[1].Value = list[1][i];
                    dgDisplay.Rows[number].Cells[2].Value = list[2][i];
                    dgDisplay.Rows[number].Cells[3].Value = list[3][i];
                    dgDisplay.Rows[number].Cells[4].Value = list[4][i];
                    dgDisplay.Rows[number].Cells[5].Value = list[5][i];
                    
                }
                MessageBox.Show("Znaleziono " + list[0].Count + " wyników");

            }
        }
        public static int wybor=1;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            wybor = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            wybor = 2;
        }

        private void autorzyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autorzy aut = new autorzy();
            aut.Show();   
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void wylogujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LOGIN log = new LOGIN();
            log.Show();
        }

        private void mojeKontoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KONTO_USERS KU = new KONTO_USERS(user, pass);
            KU.Show(this);
        }
        
        private void dgDisplay_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow myRow = dgDisplay.CurrentRow;
            string autor = myRow.Cells[2].Value.ToString();
            string tutul = myRow.Cells[3].Value.ToString();
            string available = myRow.Cells[4].Value.ToString();
            string reserved = myRow.Cells[5].Value.ToString();

            EDITb edit = new EDITb(autor, tutul, available, reserved);
            edit.ShowDialog(this);
        }

        private void dodajUżytkownikaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dgDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
