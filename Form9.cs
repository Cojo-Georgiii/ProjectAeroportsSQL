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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            new Global();
            comboBox1.DataSource = Global.ds1;
            DataView dv = new DataView(Global.ds1.Tables["ModeleAvioane"]);
            dv.Sort = "Nume_Avion";
            comboBox1.DataSource = dv;
            comboBox1.DisplayMember = "Nume_Avion";
            comboBox1.ValueMember = "id_Model";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Global.con.Open();
            SqlCommand cmd = Global.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
           // cmd.CommandText = " update Zboruri set Companie_Aeriana = '" + textBox2.Text + " where id_Zboruri = " + int.Parse(textBox1.Text) + ", Data_Plecare = " + textBox3.Text + "' where id_Zboruri = '" + int.Parse(textBox1.Text) + "' , Oras_Plecare = '" + textBox4.Text + "' where id_Zboruri = '" + int.Parse(textBox1.Text) + "' , Oras_Sosire = '" + textBox5.Text + "' where id_Zboruri = '" + int.Parse(textBox1.Text) + "' , Pret_Bilet = " + textBox6.Text + "' where id_Zboruri = '" + int.Parse(textBox1.Text) + "' , id_Model = " + comboBox1.SelectedValue.ToString() + "' where id_Zboruri = '" + int.Parse(textBox1.Text);
            //cmd.CommandText = " update Zboruri set Companie_Aeriana = '" + textBox2.Text + "' where id_Zboruri = '" + textBox1.Text;
            //cmd.CommandText = " update Zboruri set Data_Plecare = '" + textBox3.Text + "' where id_Zboruri = '" + textBox1.Text;
            //cmd.CommandText = " update Zboruri set Oras_Plecare = '" + textBox4.Text + "' where id_Zboruri = '" + textBox1.Text;
            //cmd.CommandText = " update Zboruri set Oras_Sosire = '" + textBox5.Text + "' where id_Zboruri = '" + textBox1.Text;
            //cmd.CommandText = " update Zboruri set Pret_Bilet = " + textBox6.Text + "' where id_Zboruri = '" + textBox1.Text;
            //cmd.CommandText = " update Zboruri set id_Model = " + comboBox1.SelectedValue.ToString() + "' where id_Zboruri = '" + textBox1.Text;
            //cmd.CommandText = " update Zboruri set Companie_Aeriana = " + textBox2.Text + ",'""';

            cmd.CommandText = " update Zboruri set Companie_Aeriana = '" + textBox2.Text +  "', Data_Plecare = '" + textBox3.Text + "', Oras_Plecare = '" + textBox4.Text + "', Oras_Sosire = '" + textBox5.Text +  "', Pret_Bilet = " + textBox6.Text + ", id_Model = " + comboBox1.SelectedValue.ToString()  +" where id_Zboruri = " + textBox1.Text;
            cmd.ExecuteNonQuery();
            Global.con.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox3.Text = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Global();
            dataGridView1.DataSource = Global.ds;
            dataGridView1.DataMember = "Zboruri";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["id_Zboruri"].Value.ToString();
                textBox2.Text = row.Cells["Companie_Aeriana"].Value.ToString();
                textBox3.Text = row.Cells["Data_Plecare"].Value.ToString();
                textBox4.Text = row.Cells["Oras_Plecare"].Value.ToString();
                textBox5.Text = row.Cells["Oras_Sosire"].Value.ToString();
                textBox6.Text = row.Cells["Pret_Bilet"].Value.ToString();
                comboBox1.Text = row.Cells["id_Model"].Value.ToString();
            }
        }
    }
}
