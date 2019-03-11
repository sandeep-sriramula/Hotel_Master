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

namespace Hotel_Mater
{
    public partial class room : Form
    {
        public room()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void room_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appdata.tblRoom' table. You can move, or remove it, as needed.
            this.tblRoomTableAdapter.Fill(this.appdata.tblRoom);
            OleDbDataAdapter adp = new OleDbDataAdapter("select * from tblRoom", conn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            DataGrid1.DataSource = dt;

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void lvRoom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            DataGrid1.Refresh();
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\hotelmaster.accdb");
        private void button1_Click_1(object sender, EventArgs e)
        {
            string rno = textBox1.Text;
            string rtp = textBox2.Text;
            string rr = textBox3.Text;
            string rop = textBox4.Text;
            string sts = "Available";
            
            OleDbCommand cmd = new OleDbCommand("INSERT into tblRoom (RoomNumber, RoomType,RoomRate,NoOfOccupancy,status) Values(@rno, @rtp,@rr,@rop,@sts)");
            cmd.Connection = conn;
            OleDbDataAdapter adp2 = new OleDbDataAdapter("select * from tblRoom",conn );
            DataTable dt2 = new DataTable();
            conn.Open();

            if (conn.State == ConnectionState.Open)
            {
                cmd.Parameters.Add("@rno", OleDbType.VarChar).Value = rno;
                cmd.Parameters.Add("@rtp", OleDbType.VarChar).Value = rtp;
                cmd.Parameters.Add("@rr", OleDbType.VarChar).Value = rr;
                cmd.Parameters.Add("@rop", OleDbType.VarChar).Value = rop;
                cmd.Parameters.Add("@sts", OleDbType.VarChar).Value = sts;
                
                try
                {
                    
                    cmd.ExecuteNonQuery();
                    adp2.Fill(dt2 );
                    DataGrid1.DataSource = dt2;
                    MetroFramework.MetroMessageBox.Show(this, "", "Room Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                   
                   
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Already Room Exists");
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Connection Failed");
            }

        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
