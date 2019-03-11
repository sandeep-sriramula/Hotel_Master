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
using MetroFramework;

namespace Hotel_Mater
{
    public partial class registration : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;  Data Source=|DataDirectory|\hotelmaster.accdb");
        
       
        public registration()
        {
            InitializeComponent();
        }

        private void txtCheckInDate_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label16_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void registration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appdata.tblTransaction' table. You can move, or remove it, as needed.
            this.tblTransactionTableAdapter.Fill(this.appdata.tblTransaction);
            // TODO: This line of code loads data into the 'appdata.tblTransaction' table. You can move, or remove it, as needed.
            //this.tblTransactionTableAdapter.Fill(this.appdata.tblTransaction);
            // TODO: This line of code loads data into the 'appdata.tblRoom' table. You can move, or remove it, as needed.
            this.tblRoomTableAdapter.Fill(this.appdata.tblRoom);
            dataGridView1.Visible = false;
           // this.tblRoomTableAdapter.FillBy5(this.appdata.tblRoom);
            OleDbDataAdapter adp = new OleDbDataAdapter("select * from tblRoom where Status='Available' ", con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            this.txtCheckInDate.Enabled = false;
           


           

        }

        

        

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblRoomTableAdapter.FillBy1(this.appdata.tblRoom);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblRoomTableAdapter.FillBy2(this.appdata.tblRoom);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
       
        private void fillBy3ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblRoomTableAdapter.FillBy3(this.appdata.tblRoom);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void bttnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        public  void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            OleDbCommand cmd = new OleDbCommand("select * from tblRoom ",con );
            
            con.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
               // if (e.RowIndex >= 0)
                
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                    txtnum.Text = row.Cells["RoomNumber"].Value.ToString();
                    txtRoomType.Text = row.Cells["RoomType"].Value.ToString();
                    txtRoomRate.Text = row.Cells["RoomRate"].Value.ToString();
                   //OleDbCommand cmd2 = new OleDbCommand("update tblRoom set status ='Occupied' where RoomNumber="+txtnum .Text +" ",con );
                    //cmd2.ExecuteNonQuery();
                    dataGridView1.Visible = false;
                    groupBox3.Visible = true;
                   
                    
               
                con.Close();
                /*txtnum.Text = dr["RoomNumber"].ToString();
                txtRoomType.Text  = dr["RoomType"].ToString();
                txtRoomRate.Text = dr["RoomRate"].ToString();
                */
            }
          
        }

        private void fillBy5ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblRoomTableAdapter.FillBy5(this.appdata.tblRoom);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dtCheckOutDate_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txtDaysNumber_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtAdvance_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bttnCheckIn_Click(object sender, EventArgs e)
        {
            string gn = txtGuestName.Text;
            string num = txtnum.Text;
            string cin = txtCheckInDate.Text;
            string cout = dtCheckOutDate.Text;
            string adt = txtAdults.Text;
            string chd = txtChildren.Text;
            string adv = txtAdvance.Text;
            string rt = txtRoomType.Text;
            string rr = txtRoomRate.Text;
            string ttl = txtTotal.Text;
            string nd = txtDaysNumber.Text;
            string ad = address.Text;
            string mno = number.Text;
            string eml = email.Text;
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\vardhan\Desktop\Hotel_Master\Hotel_Mater\hotelmaster.accdb");
            OleDbCommand cmd = new OleDbCommand("INSERT into tblTrans (GuestID,RoomNum,CheckInDate,CheckOutDate,NoOfAdult,NoOfchild,AdvancePayment,RoomRate,RoomType,NoOfDays,TotalBal,MobileNo,Address,Email) Values(@gin,@num,@cin,@cout,@atd,@chd,@adv,@rr,@rt,@nd,@ttl,@mno,@ad,@eml)", con);
           OleDbCommand cmd2 = new OleDbCommand("update [tblRoom] set Status ='Occupied' where  RoomNumber="+txtnum.Text+" ",con );

           //OleDbDataAdapter adp = new OleDbDataAdapter("select * from tblTransaction",con );
            //DataTable dt = new DataTable();
            con.Open();

            if (con.State == ConnectionState.Open)
            {
                //cmd.Parameters.Add ("@tid", OleDbType.VarChar  ).Value  = tid;
               cmd.Parameters.Add("@gn", OleDbType.VarChar    ).Value = gn;
                cmd.Parameters.Add ("@num", OleDbType.VarChar ).Value = num;
              cmd.Parameters.Add("@cin", OleDbType.Date  ).Value = cin;
                cmd.Parameters.Add("@cout", OleDbType.Date  ).Value = cout;
                cmd.Parameters.Add("@adt", OleDbType.VarChar ).Value = adt;
                cmd.Parameters.Add("@chd", OleDbType.VarChar ).Value = chd;
                cmd.Parameters.Add("@adv", OleDbType.VarChar  ).Value = adv;
                cmd.Parameters.Add("@rr", OleDbType.VarChar).Value = rr ;
                cmd.Parameters.Add("@rt", OleDbType.VarChar).Value = rt;
                cmd.Parameters.Add("@nd", OleDbType.VarChar).Value = nd ;
                cmd.Parameters.Add("@ttl", OleDbType.VarChar).Value = ttl ;
                cmd.Parameters.Add("@ad", OleDbType.VarChar).Value = ad;
                cmd.Parameters.Add("@mno", OleDbType.VarChar ).Value = mno ;
                cmd.Parameters.Add("@eml", OleDbType.VarChar ).Value = eml ;
                try
                {
                   cmd.ExecuteNonQuery();
                 cmd2.ExecuteNonQuery();
                    MetroFramework.MetroMessageBox.Show(this, "", "Guest Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            
                    con.Close();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.ToString ());
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Connection Failed");
            }


        }

        private void txtTransID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtChildren_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            dataGridView1.Visible = true;
        }

        private void txtDaysNumber_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dtCheckOutDate_ValueChanged_1(object sender, EventArgs e)
        {
            txtDaysNumber.Text = new TimeSpan(dtCheckOutDate.Value.Date.Ticks - txtCheckInDate.Value.Date.Ticks).Days.ToString();

        }

        private void txtAdvance_TextChanged_1(object sender, EventArgs e)
        {
              try
            {
                int total = 0;
                total = int.Parse(txtRoomRate.Text) * int.Parse(txtDaysNumber.Text) - int.Parse(txtAdvance.Text);
                txtTotal.Text = total.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Advance Payment is must");
            }
        
        }

        private void txtnum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
