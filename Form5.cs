using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLProjectAeroport
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet dsxml = new DataSet();
            string FilePath = @"C:\Users\cojoc\Desktop\SQLProjectAeroport\xml_Import\Import_Zboruri.xml";
            dsxml.ReadXml(FilePath);
            dataGridView1.DataSource = dsxml;
            dataGridView1.DataMember = "Zboruri";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Global.ds.Tables["Zboruri"].WriteXml(@"C:\Users\cojoc\Desktop\SQLProjectAeroport\xml_Import\Import_Zboruri.xml");
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            new Global();
            dataGridView1.DataSource = Global.ds; ;
            dataGridView1.DataMember = "Zboruri";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
