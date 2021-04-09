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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Global.con.Open();
            SqlCommand cmd = Global.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from  Pasageri where id_Pasageri = " + textBox1.Text;
            cmd.ExecuteNonQuery();
            Global.con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Global();
            dataGridView1.DataSource = Global.ds2;
            dataGridView1.DataMember = "Pasageri";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if( e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["id_Pasageri"].Value.ToString();


            }
        }
    }
}
