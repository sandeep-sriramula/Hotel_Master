using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data .OleDb ;

namespace Hotel_Mater
{
    public partial class Reserve : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\hotelmaster.accdb");
        public Reserve()
        {
            InitializeComponent();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reserve_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void Reserve_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            dataGridView1.Visible = true;
        }

        private void Reserve_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            OleDbDataAdapter adp = new OleDbDataAdapter("select * from tblRoom where Status='Available'", con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand("select * from tblRoom ", con);

            con.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                    txtRoomNumber.Text = row.Cells["RoomNumber"].Value.ToString();
                    txtRoomType.Text = row.Cells["RoomType"].Value.ToString();
                    txtRoomRate.Text = row.Cells["RoomRate"].Value.ToString();
                    //OleDbCommand cmd2 = new OleDbCommand("update tblRoom set status ='Occupied' where RoomNumber="+txtnum .Text +" ",con );
                    //cmd2.ExecuteNonQuery();
                    dataGridView1.Visible = false;
                    groupBox3.Visible = true;


                }
                con.Close();

            }


        }

        private void dtCheckOutDate_ValueChanged(object sender, EventArgs e)
        {
            txtDaysNumber.Text = new TimeSpan(dtCheckOutDate.Value.Date.Ticks - dtCheckInDate.Value.Date.Ticks).Days.ToString();

        }

        private void txtAdvance_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int total = 0;
                total = int.Parse(txtRoomRate.Text) * int.Parse(txtDaysNumber.Text) + int.Parse(txtAdvance.Text);
                txtTotal.Text = total.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Advance Payment is must");
            }
        }

        private void bttnReserve_Click(object sender, EventArgs e)
        {
            string gn = txtGuestName.Text;
            string num = txtRoomNumber.Text;
            string cin = dtCheckInDate.Text;
            string cout = dtCheckOutDate.Text;
            string adt = txtAdults.Text;
            string chd = txtChildren.Text;
            string adv = txtAdvance.Text;
            string rt = txtRoomType.Text;
            string rr = txtRoomRate.Text;
            string ttl = txtTotal.Text;
            string nd = txtDaysNumber.Text;
            string sts = "Reserved";
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\vardhan\Desktop\Hotel_Master\Hotel_Mater\hotelmaster.accdb");
            OleDbCommand cmd = new OleDbCommand("INSERT into tblTrans (GuestID,RoomNum,CheckInDate,CheckOutDate,NoOfAdult,NoOfchild,AdvancePayment,RoomRate,RoomType,NoOfDays,TotalBal,status) Values(@gin,@num,@cin,@cout,@atd,@chd,@adv,@rr,@rt,@nd,@ttl,@sts)", con);
            OleDbCommand cmd2 = new OleDbCommand("update [tblRoom] set Status ='Reserved' where  RoomNumber=" + txtRoomNumber.Text + " ", con);


            //OleDbDataAdapter adp = new OleDbDataAdapter("select * from tblTransaction",con );
            //DataTable dt = new DataTable();
            con.Open();

            if (con.State == ConnectionState.Open)
            {
                //cmd.Parameters.Add ("@tid", OleDbType.VarChar  ).Value  = tid;
                cmd.Parameters.Add("@gn", OleDbType.VarChar).Value = gn;
                cmd.Parameters.Add("@num", OleDbType.VarChar).Value = num;
                cmd.Parameters.Add("@cin", OleDbType.Date).Value = cin;
                cmd.Parameters.Add("@cout", OleDbType.Date).Value = cout;
                cmd.Parameters.Add("@adt", OleDbType.VarChar).Value = adt;
                cmd.Parameters.Add("@chd", OleDbType.VarChar).Value = chd;
                cmd.Parameters.Add("@adv", OleDbType.VarChar).Value = adv;
                cmd.Parameters.Add("@rr", OleDbType.VarChar).Value = rr;
                cmd.Parameters.Add("@rt", OleDbType.VarChar).Value = rt;
                cmd.Parameters.Add("@nd", OleDbType.VarChar).Value = nd;
                cmd.Parameters.Add("@ttl", OleDbType.VarChar).Value = ttl;
                cmd.Parameters.Add("@sts", OleDbType.VarChar).Value = sts ;

                try
                {
                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    MetroFramework.MetroMessageBox.Show(this, "", "Guest Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    con.Close();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.ToString());
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Connection Failed");
            }
        }

        private void bttnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
