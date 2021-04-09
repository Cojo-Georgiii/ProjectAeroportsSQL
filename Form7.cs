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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Global.con.Open();
            SqlCommand cmd = Global.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from  Zboruri where id_Zboruri = " +textBox1.Text;
            cmd.ExecuteNonQuery();
            Global.con.Close();
            
        }

        private void Form7_Load(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Global();
            dataGridView1.DataSource = Global.ds;
            dataGridView1.DataMember = "Zboruri";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            dataGridView1.Update();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if( e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["id_Zboruri"].Value.ToString() ;
            }
        }
    }
}
