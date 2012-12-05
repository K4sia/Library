using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectCsharpToMysql
{
    class User
    {

        public static string[] search_resources(int kryterium, string tekst)
        {
            
            DBConnect connect = new DBConnect();
            string param = " ";
            string[] tab = new string[2];
            if (kryterium == 1)
            {
                param = "Author_Name";
            }
            if (kryterium == 2)
            {
                param = "Title";
            }
            else
            { //wyrzuc blad, ze kryterium jest zle
            }
            
            tab[0] = param;
            tab[1] = tekst;

            return tab;

        }
        
   
   
    }
}
