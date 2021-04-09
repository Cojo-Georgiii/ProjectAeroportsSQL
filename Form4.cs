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
    public partial class Form4 : Form
    {
        


        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            new Global();
            comboBox1.DataSource = Global.ds1;
            DataView dv = new DataView(Global.ds1.Tables["ModeleAvioane"]);
            dv.Sort = "Nume_Avion";
            comboBox1.DataSource = dv;
            comboBox1.DisplayMember = "Nume_Avion";
            comboBox1.ValueMember = "id_Model";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        Global.con.Open();
            SqlCommand cmd = Global.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Zboruri values (" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "'," + textBox6.Text + "," + comboBox1.SelectedValue.ToString() + ")";
            cmd.ExecuteNonQuery();
            Global.con.Close();
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
         textBox3.Text = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

      
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
