using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using MySql.Data.MySqlClient;




namespace ConnectCsharpToMysql
{
   public class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBConnect()
        {
            Initialize();
        }
      
        //Initialize values
        private void Initialize()
        {
            server = "sql.doe.pl";
            database = "kasprzakleonard9";
            uid = "kasprzakleonard9";
            password = "krasnoludki123";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }


        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }



        public List<string>[] Login(string user, string pass) 
        {
            string query = "SELECT * FROM USERS where Login='"+user+"' && Password ='"+pass+"'";

            //Create a list to store the result
            List<string>[] list = new List<string>[9];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();
            list[6] = new List<string>();
            list[7] = new List<string>();
            list[8] = new List<string>();


            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {

                    list[0].Add(dataReader["id_user"] + "");
                    list[1].Add(dataReader["id_authority"] + "");
                    list[2].Add(dataReader["user_name"] + "");
                    list[3].Add(dataReader["user_surname"] + "");
                    list[4].Add(dataReader["pesel"] + "");
                    list[5].Add(dataReader["limitk"] + "");
                    list[6].Add(dataReader["amount_of_borrows"] + "");
                    list[7].Add(dataReader["login"] + "");
                    list[8].Add(dataReader["password"] + "");

                }

                //
                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {

                return list;
            }
        }
       ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
       // sprawdzenie który u¿ytkownik siê zalogowa³
        public List<string>[] ZalUzyt(string user, string pass)
        {
            string query = "SELECT id_user FROM USERS where Login='" + user + "' && Password ='" + pass + "'";

            //Create a list to store the result
            List<string>[] list = new List<string>[1];
            list[0] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {

                    list[0].Add(dataReader["id_user"] + "");

                }

                //
                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {

                return list;
            }
        }
       //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
       // Zapytanie o ilosc ksi¹¿ek u¿ytkownika
        public List<string>[] IleKsiazek(int iduzyt)
        {
            string query = "SELECT Title, Author_Name FROM RESOURCES INNER JOIN RESOURCES_USERS ON RESOURCES.Id_Resources = RESOURCES_USERS.Id_Resources WHERE Id_User =" + iduzyt + " AND Id_Kind = 1";

            //Create a list to store the result
            List<string>[] list = new List<string>[2];
            list[0] = new List<string>();
            list[1] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {

                    list[0].Add(dataReader["Title"] + "");
                    list[1].Add(dataReader["Author_name"] + "");
                }

                //
                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {

                return list;
            }
        }
       //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Zapytanie o ilosc plyt u¿ytkownika
        public List<string>[] IlePlyt(int iduzyt)
        {
            string query = "SELECT Title, Author_Name FROM RESOURCES INNER JOIN RESOURCES_USERS ON RESOURCES.Id_Resources = RESOURCES_USERS.Id_Resources WHERE Id_User =" + iduzyt + " AND Id_Kind = 2";

            //Create a list to store the result
            List<string>[] list = new List<string>[2];
            list[0] = new List<string>();
            list[1] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {

                    list[0].Add(dataReader["Title"] + "");
                    list[1].Add(dataReader["Author_name"] + "");
                }

                //
                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {

                return list;
            }
        }
       //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Zapytanie o ilosc filmów u¿ytkownika
        public List<string>[] IleFilmow(int iduzyt)
        {
            string query = "SELECT Title, Author_Name FROM RESOURCES INNER JOIN RESOURCES_USERS ON RESOURCES.Id_Resources = RESOURCES_USERS.Id_Resources WHERE Id_User =" + iduzyt + " AND Id_Kind = 3";

            //Create a list to store the result
            List<string>[] list = new List<string>[2];
            list[0] = new List<string>();
            list[1] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {

                    list[0].Add(dataReader["Title"] + "");
                    list[1].Add(dataReader["Author_name"] + "");
                }

                //
                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {

                return list;
            }
        }

       //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Insert statement
        public void Insert(int id_kind, string title, string name, string av, string res)
        {
        string query = "INSERT INTO RESOURCES (Id_Kind, Title, Author_Name, Is_Available, Is_Reserve) VALUES("+id_kind+",'"+title+"','"+name+"','"+av+"','"+res+"')";
        
            //open connection
        if (this.OpenConnection() == true)
            {
                 //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Execute command
                cmd.ExecuteNonQuery();
                //close connection
                this.CloseConnection();
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
       //EDYCJA
        //Update statement
        public void Update(string title, string name, string title_ed, string name_ed)
        {
            string query = "UPDATE RESOURCES SET Title='"+title+"', Author_Name='"+name+"' WHERE Title='"+title_ed+"' AND Author_Name='"+name_ed+"'";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
       //REZERWACJA KSI¥ZKI

        public void Rezerwuj(string res, string title_ed, string name_ed)
        {
            string query = "UPDATE RESOURCES SET Is_Reserve='"+res+"' WHERE Title='"+title_ed+"' AND Author_Name='"+name_ed+"'";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //WYPOZYCZENIE KSI¥ZKI

        public void Wypozycz(string dos, string title_ed, string name_ed)
        {
            string query = "UPDATE RESOURCES SET Is_Available='" + dos + "' WHERE Title='" + title_ed + "' AND Author_Name='" + name_ed + "'";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
       //SPRAWDZENIE CZY PODCZAS REZERWACJI LUB ODDANIA KSI¥ZKI ISTNIEJE DANY UZYTKOWNIK
        public List<string>[] CHECKUSER(string Surname, string pesel)
        {
            string query = "SELECT User_Surname, Password FROM USERS";
            //Create a list to store the result
            List<string>[] list = new List<string>[2];
            list[0] = new List<string>();
            list[1] = new List<string>();
            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {

                    list[0].Add(dataReader["User_Surname"] + "");
                    list[1].Add(dataReader["Password"] + "");

                }
                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }
       ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
       // DODANIE DO POLA AMOUNT_OF_BORROWS JEDNEJ KSI¥¯KI, P£YTY LUB FILMU  
       public void Dodajlimit(int limit, int id_uzyt)
        {
            string query = "UPDATE USERS SET Amount_of_Borrows='" + limit + "' WHERE id_user=" + id_uzyt + "";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
       ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
       //POBRANIE ILOSCI KSI¥¯EK/P£YTY/FILMU WYPO¯YCZONYCH PRZEZ U¯YTKOWNIKA ORAZ JEGO LIMITU
       public List<string>[] AoF(int id_uzyt)
       {
           string query = "SELECT Amount_Of_Borrows, Limitk FROM USERS WHERE Id_User =" + id_uzyt + "";
           //Create a list to store the result
           List<string>[] list = new List<string>[2];
           list[0] = new List<string>();
           list[1] = new List<string>();
           //Open connection
           if (this.OpenConnection() == true)
           {
               //Create Command
               MySqlCommand cmd = new MySqlCommand(query, connection);
               //Create a data reader and Execute the command
               MySqlDataReader dataReader = cmd.ExecuteReader();

               //Read the data and store them in the list
               while (dataReader.Read())
               {

                   list[0].Add(dataReader["Amount_Of_Borrows"] + "");
                   list[1].Add(dataReader["Limitk"] + "");
               }
               //close Data Reader
               dataReader.Close();

               //close Connection
               this.CloseConnection();

               //return list to be displayed
               return list;
           }
           else
           {
               return list;
           }
       }
       ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
       //szukanie id_res
        public List<string>[] id_res(string title_ed, string name_ed)
        {
            string query = "SELECT ID_RESOURCES FROM RESOURCES WHERE Title ='"+title_ed+"' AND Author_Name='"+name_ed+"'";
            //Create a list to store the result
            List<string>[] list = new List<string>[1];
            list[0] = new List<string>();
            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {

                    list[0].Add(dataReader["Id_Resources"] + "");

                }
                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //szukanie id_user
        public List<string>[] id_user(string haslo)
        {
            string query = "SELECT ID_USER FROM USERS WHERE Password ='" + haslo + "'";
            //Create a list to store the result
            List<string>[] list = new List<string>[1];
            list[0] = new List<string>();
            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {

                    list[0].Add(dataReader["Id_user"] + "");

                }
                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
       // WPISANIE KSI¥¯KI DO RESOURCES_USERS//
        public void RezerwujDoRU(int id_res, int id_user , DateTime time , DateTime czas )
        {
            string query = "INSERT INTO RESOURCES_USERS(Id_Resources, Id_User, Date_Reserve, Date_Return) VALUES(" + id_res + "," + id_user + ",'"+ time +"' , '"+ czas+"')";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // USUWANIE KSI¥¯KI Z RESOURCES_USERS//
        public void usunDoRU(int id_res, int id_user)
        {
            string query = "DELETE FROM RESOURCES_USERS WHERE id_resources =" + id_res + " and id_user=" + id_user + "";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
       // SPRAWDZENIE CZY DANY U¯YTKOWNIK PODCZAS ODDAWANIA KSI¥¯KI NAPEWNO ODDAJE SWOJ¥ KSI¥ZKE
        public List<string>[] CheckIdRU(int id_res)
        {
            string query = "SELECT id_resources, id_user FROM RESOURCES_USERS WHERE ID_RESOURCES=" + id_res + "";

            List<string>[] list = new List<string>[2];
            list[0] = new List<string>();
            list[1] = new List<string>();

            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {

                    list[0].Add(dataReader["id_resources"] + "");
                    list[1].Add(dataReader["id_user"] + "");
                }
                //
                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //InsertUSERS statement // TWORZENIE NOWEGO UZYTKOWNIKA
        public void InsertUsers(int id_authority, string User_name, string User_surname, string Pesel, int limit, int wypoz ,string login, string haslo)
        {
            string query = "INSERT INTO USERS (Id_Authority, User_name, User_Surname, Pesel, Limitk, Amount_of_Borrows, Login, Password) VALUES(" + id_authority + ",'" + User_name + "','" + User_surname + "'," + Pesel + "," + limit + ","+wypoz+",'"+login+"','"+haslo+"')";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Execute command
                cmd.ExecuteNonQuery();
                //close connection
                this.CloseConnection();
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
       //SELECT PESEL DO USUNIÊCIA UZYTKOWNIKA//
        public List<string>[] CheckPesel(string Pesel)
        {
            string query = "SELECT PESEL FROM USERS";

            List<string>[] list = new List<string>[1];
            list[0] = new List<string>();
          
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {

                    list[0].Add(dataReader["pesel"] + "");
                  
                }
                //
                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }
       ////////////////////////////////////////////////////////////////////////////////////////////////////////////
                                                  //KONTO U¯YTKOWNIKA//
                                                 //SELECT KSI¥¯KI //
        // public List<string>[] SelectKsiazki(string pesel) // paramnasze- nazwa kolumny; tekst- podany autor/tytul
        //{
        //    string query = "SELECT Id_Resources, Name, Title, Author_Name FROM RESOURCES INNER JOIN KIND_OF_RESOURCES ON RESOURCES.Id_Kind=KIND_OF_RESOURCES.Id_Kind where " + param + " like " + tekst1;

        //    //Create a list to store the result
        //    List<string>[] list = new List<string>[7];
        //    list[0] = new List<string>();
        //    list[1] = new List<string>();
        //    list[2] = new List<string>();
        //    list[3] = new List<string>();
        //    list[4] = new List<string>();
        //    list[5] = new List<string>();


       ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Delete statement // Usuwanie u¿ytkownika
        public void DeleteUsers(string Pesel)
        {
            string query = "DELETE FROM USERS WHERE Pesel ="+Pesel+"";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //Select statement
        public List<string>[] Select(string paramnasze, string tekst) // paramnasze- nazwa kolumny; tekst- podany autor/tytul
        {
            string param=paramnasze;
            string tekst1="'%"+tekst+"%'";
            string query = "SELECT Id_Resources, Name, Title, Author_Name, Is_Available, Is_Reserve FROM RESOURCES INNER JOIN KIND_OF_RESOURCES ON RESOURCES.Id_Kind=KIND_OF_RESOURCES.Id_Kind where " + param + " like " + tekst1;

            //Create a list to store the result
            List<string>[] list = new List<string>[7];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();


            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();
                
                //Read the data and store them in the list
               while (dataReader.Read())
               {
                  
                    list[0].Add(dataReader["id_resources"] + "");
                    list[1].Add(dataReader["Name"] + "");
                    list[2].Add(dataReader["title"] + "");
                    list[3].Add(dataReader["author_name"] + "");
                    list[4].Add(dataReader["is_available"] + "");
                    list[5].Add(dataReader["is_reserve"] + "");
                 
               }
//
                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////


        ////Count statement
        //public int Count()
        //{
        //    string query = "SELECT Count(*) FROM tableinfo";
        //    int Count = -1;

        //    //Open Connection
        //    if (this.OpenConnection() == true)
        //    {
        //        //Create Mysql Command
        //        MySqlCommand cmd = new MySqlCommand(query, connection);

        //        //ExecuteScalar will return one value
        //        Count = int.Parse(cmd.ExecuteScalar()+"");
                
        //        //close Connection
        //        this.CloseConnection();

        //        return Count;
        //    }
        //    else
        //    {
        //        return Count;
        //    }
        //}

        //Backup
        //public void Backup()
        //{
        //    try
        //    {
        //        DateTime Time = DateTime.Now;
        //        int year = Time.Year;
        //        int month = Time.Month;
        //        int day = Time.Day;
        //        int hour = Time.Hour;
        //        int minute = Time.Minute;
        //        int second = Time.Second;

        //        //Save file to C:\ with the current date as a filename
        //        string path;
        //        path = "C:\\Backup\\" + year + "-" + month + "-" + day + "-" + hour +".sql";
        //        StreamWriter file = new StreamWriter(path);

                
        //        ProcessStartInfo psi = new ProcessStartInfo();
        //        psi.FileName = "mysqldump";
        //        psi.RedirectStandardInput = false;
        //        psi.RedirectStandardOutput = true;
        //        psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}", uid, password, server, database);
        //        psi.UseShellExecute = false;

        //        Process process = Process.Start(psi);

        //        string output;
        //        output = process.StandardOutput.ReadToEnd();
        //        file.WriteLine(output);
        //        process.WaitForExit();
        //        file.Close();
        //        process.Close();
        //    }
        //    catch (IOException ex)
        //    {
        //        MessageBox.Show("Error , unable to backup!");
        //    }
        //}

        //Restore
        //public void Restore()
        //{
        //    try
        //    {
        //        //Read file from C:\
        //        string path;
        //        path = "C:\\MySqlBackup.sql";
        //        StreamReader file = new StreamReader(path);
        //        string input = file.ReadToEnd();
        //        file.Close();


        //        ProcessStartInfo psi = new ProcessStartInfo();
        //        psi.FileName = "mysql";
        //        psi.RedirectStandardInput = true;
        //        psi.RedirectStandardOutput = false;
        //        psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}", uid, password, server, database);
        //        psi.UseShellExecute = false;

                
        //        Process process = Process.Start(psi);
        //        process.StandardInput.WriteLine(input);
        //        process.StandardInput.Close();
        //        process.WaitForExit();
        //        process.Close();
        //    }
        //    catch (IOException ex)
        //    {
        //        MessageBox.Show("Error , unable to Restore!");
        //    }
        //}
    }
}
