using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConnectCsharpToMysql
{
    public partial class Form1 : Form
    {
        private DBConnect dbConnect;


        public Form1()
        {
            InitializeComponent();
            dbConnect = new DBConnect();
        }


        ////Insert button clicked
        //private void bInsert_Click(object sender, EventArgs e)
        //{
        //    dbConnect.Insert();
        //}

        ////Update button is clicked
        //private void bUpdate_Click(object sender, EventArgs e)
        //{
        //    dbConnect.Update();
        //}

        //Delete button is clicked
        //private void bDelete_Click(object sender, EventArgs e)
        //{
        //    dbConnect.Delete();
        //}

        //Select button is clicked

        //private void bSelect_Click(object sender, EventArgs e)
        //{
        //    List<string>[] list;
        //    string[]tablica= new string [2];

        //    tablica = User.search_resources(wybor, tekst);
      
        //    list = dbConnect.Select(tablica[0],tablica[1]);
        //  // list = dbConnect.Select("wybor", tekst);
        //    //dbConnect.Select("a","b");
        //   // Select("autor", "aa");
        //    Console.WriteLine(list[0].Count);
        //    Console.ReadLine();
        //    dgDisplay.Rows.Clear();
        //    for(int i = 0; i < list[0].Count; i++)
        //    {
        //        int number = dgDisplay.Rows.Add();
        //        dgDisplay.Rows[number].Cells[0].Value = list[0][i];
        //        dgDisplay.Rows[number].Cells[1].Value = list[1][i];
        //        dgDisplay.Rows[number].Cells[2].Value = list[2][i];
        //        dgDisplay.Rows[number].Cells[3].Value = list[3][i];
        //        dgDisplay.Rows[number].Cells[4].Value = list[4][i];
        //        dgDisplay.Rows[number].Cells[5].Value = list[5][i];
        //        dgDisplay.Rows[number].Cells[6].Value = list[6][i];
 
               
        //    }
        //}

        //Count button clicked
        //private void bCount_Click(object sender, EventArgs e)
        //{
        //    int Count = dbConnect.Count();

        //    dgDisplay.Rows.Clear();
        //    int number = dgDisplay.Rows.Add();
        //    dgDisplay.Rows[number].Cells[0].Value = Count + "";
        //}

        //Backup button clicked
        private void bBackup_Click(object sender, EventArgs e)
        {
            dbConnect.Backup();
        }

        //Restore button clicked
        private void bRestore_Click(object sender, EventArgs e)
        {
            dbConnect.Restore();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }
        public static int wybor;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            wybor = 1;
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           wybor = 2;
         
        }
        public static string tekst;
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
                MessageBox.Show("Znaleziono " +  list[0].Count + " wyników");
                
            }
        }

        public void dgDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 ksiazka = new Form3();
            ksiazka.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 film = new Form4();
            film.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 muza = new Form2();
            muza.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_2(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_3(object sender, EventArgs e)
        {
            Form4 ksiazka = new Form4();
            ksiazka.Show();
        }

        private void ksiazkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 ksiazka = new Form3();
            ksiazka.Show();
        }

        private void filmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 film = new Form4();
            film.Show();
        }

        private void muzykeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 muza = new Form2();
            muza.Show();
        }

        private void odtworzBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dbConnect.Restore();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dbConnect.Backup();
        }

        private void rezerwuj_Click(object sender, EventArgs e)
        {
            DataGridViewRow myRow = dgDisplay.CurrentRow;
            myRow.Cells[0].ToString();
            MessageBox.Show(myRow.Cells[0].Value.ToString());
        }

        

        //podwojne klikniecie na liste
        private void dgDisplay_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow myRow = dgDisplay.CurrentRow;
            string autor = myRow.Cells[2].Value.ToString();
            string tutul = myRow.Cells[3].Value.ToString();
            string available = myRow.Cells[4].Value.ToString();
            string reserved = myRow.Cells[5].Value.ToString();
            
            Form5 edit = new Form5(autor, tutul, available, reserved);
            edit.ShowDialog(this);

            //MessageBox.Show(autor);             
            //MessageBox.Show(myRow.Cells[3].Value.ToString());                 
            //nowy "myRow" z obecnie zaznaczonego rowa
            //DataGridViewRow myRow = dgDisplay.CurrentRow;
            //myRow.Cells[0].ToString();
            //messagebox
            //MessageBox.Show(myRow.Cells[0].Value.ToString());
        }

        public string autor;
        public string tutul;
        public string available;
        public string reserved;
        //nacisniecie r
        public void r(object sender, PreviewKeyDownEventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void autorzyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autorzy aut = new autorzy();
            aut.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(autor);
        }

        private void wylogujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LOGIN log = new LOGIN();
            log.Show();
        }

    
    }
}