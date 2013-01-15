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
    public partial class USUN_UZYT : Form
    {
        private DBConnect dbConnect;
        public USUN_UZYT()
        {
            InitializeComponent();
            dbConnect = new DBConnect();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pesel = textBox1.Text;
            dbConnect.DeleteUsers(pesel);
            MessageBox.Show("Usunięto użytkownika");
            this.Close();

        }
    }
}
