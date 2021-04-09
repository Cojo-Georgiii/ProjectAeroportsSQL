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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Global();
            dataGridView1.DataSource = Global.ds2;
            dataGridView1.DataMember = "Pasageri";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var select = "SELECT Companie_Aeriana, Oras_Plecare , Oras_Sosire FROM Zboruri  where id_Zboruri = " + comboBox1.SelectedValue.ToString();
            var c = new SqlConnection(@"Data Source=DESKTOP-IKGLTSA\SPARTA;Initial Catalog=Transport_Aerian;Integrated Security=True"); // Your Connection String here
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView2.ReadOnly = true;
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
        private void Form10_Load(object sender, EventArgs e)
        {
            new Global();
            comboBox1.DataSource = Global.ds;
            DataView dv = new DataView(Global.ds.Tables["Zboruri"]);
            dv.Sort = "id_Zboruri";
            comboBox1.DataSource = dv;
            comboBox1.DisplayMember = "id_Zboruri";
            comboBox1.ValueMember = "id_Zboruri";
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Global.con.Open();
            SqlCommand cmd = Global.con.CreateCommand(); 
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Pasageri set Nume_Pasager = '" +textBox2.Text+ "', Prenume_Pasager = '" +textBox3.Text+ "', Sex_Pasager = '" +textBox4.Text+ "', Numar_Telefon = " +textBox5.Text+ ", id_Zboruri = " + comboBox1.SelectedValue.ToString() + " where id_Pasageri = " + textBox1.Text; 
            cmd.ExecuteNonQuery();
            Global.con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["id_Pasageri"].Value.ToString();
                textBox2.Text = row.Cells["Nume_Pasager"].Value.ToString();
                textBox3.Text = row.Cells["Prenume_Pasager"].Value.ToString();
                textBox4.Text = row.Cells["Sex_Pasager"].Value.ToString();
                textBox5.Text = row.Cells["Numar_Telefon"].Value.ToString();
                comboBox1.Text = row.Cells["id_Zboruri"].Value.ToString();

            }
        }

        private bool nrTel(object sender)
        {
            try
            {
                if (textBox5.TextLength > 10)
                    throw new Exception("Ati depasit limita de cifre a numarului de telelfon \n");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        private bool Gender(object sender)
        {
            try
            {
                if ((textBox4.TextLength > 1) && ((textBox4.Text != "M") || (textBox4.Text != "F")))
                    throw new Exception("Introduceti prescurtarea sexului (M/F)");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (nrTel((TextBox)sender))
                ((TextBox)sender).Focus();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (Gender((TextBox)sender))
                ((TextBox)sender).Focus();
        }
    }
}
