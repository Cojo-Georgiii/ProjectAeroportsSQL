using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLProjectAeroport
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Global.con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ps_Locuri";
            SqlParameter p1 = new SqlParameter();
            p1.Value = comboBox1.SelectedValue;
            p1.ParameterName = "@id_Zboruri";
            cmd.Parameters.Add(p1); 

            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@plin";
            p2.DbType = DbType.Int32;
            p2.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(p2);
            Global.con.Open();
            cmd.ExecuteScalar();
            if (int.Parse(p2.Value.ToString()) == 1)
                label2.Text = "Zborul este plin";
            else
                label2.Text = "Mai sunt locuri libere";
            Global.con.Close();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            new Global();
            DataView dv = new DataView(Global.ds.Tables["Zboruri"]);
            dv.Sort = "id_Zboruri";
            comboBox1.DataSource = dv;
            comboBox1.DisplayMember = "id_Zboruri";
            comboBox1.ValueMember = "id_Zboruri";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
