using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLProjectAeroport
{
    class Global
    { 
        public static string stringConectare = @"Data Source=DESKTOP-IKGLTSA\SPARTA;Initial Catalog=Transport_Aerian;Integrated Security=True";
        public static SqlConnection con=null;
        public static DataSet ds,ds1,ds2;
        public static SqlDataAdapter daZboruri;
        public static SqlDataAdapter daModeleAvioane;
        public static SqlDataAdapter daPasageri;
        public static DataSet dst ;
        public static SqlDataAdapter idZbor;
        public Global() {
            con = new SqlConnection(stringConectare);
            ds = new DataSet(); ds1 = new DataSet(); ds2 = new DataSet(); dst = new DataSet();
            daZboruri = new SqlDataAdapter("select * from Zboruri",con);
            daZboruri.Fill(ds,"Zboruri");
            daModeleAvioane = new SqlDataAdapter("select * from ModeleAvioane", con);
            daModeleAvioane.Fill(ds1, "ModeleAvioane");
            daPasageri = new SqlDataAdapter("select * from Pasageri",con);
            daPasageri.Fill(ds2, "Pasageri");
            idZbor = new SqlDataAdapter("select Companie_Aeriana , Oras_Plecare , Oras_Sosire  from  Zboruri" , con);
            idZbor.Fill(dst,"iii");

        }
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
