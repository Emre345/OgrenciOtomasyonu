using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbCommand cmd;
        OleDbConnection con;
        OleDbDataReader dr;
        private void button1_Click(object sender, EventArgs e)
        {


           
            con = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=Database2.mdb");
            cmd = new OleDbCommand("Select ogr_ad,ogr_soyad,ogr_no from ogrenci where sınıf ='" + textBox1.Text + "'", con);
            con.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                listBox1.Items.Add(dr["ogr_ad"]).ToString();
                listBox2.Items.Add(dr["ogr_soyad"]).ToString();
                listBox3.Items.Add(dr["ogr_no"]).ToString();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
