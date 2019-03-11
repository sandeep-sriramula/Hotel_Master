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
    public partial class Billing : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\hotelmaster.accdb");
        public Billing()
        {
            InitializeComponent();
        }

        private void Billing_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
        }

        private void label18_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            OleDbDataAdapter adp = new OleDbDataAdapter("select * from tblTrans where status ='Reserved' or status is NULL",con );
            DataTable dt = new DataTable();
            adp.Fill(dt );
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
              OleDbCommand cmd = new OleDbCommand("select * from tblRoom ",con );
            
            con.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
               // if (e.RowIndex >= 0)
                
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                    txtGuestName.Text = row.Cells["GuestID"].Value.ToString();
                    txtRoomNumber.Text = row.Cells["RoomNum"].Value.ToString();
                    txtRoomType.Text = row.Cells["RoomType"].Value.ToString();
                    txtRoomRate.Text = row.Cells["RoomRate"].Value.ToString();
                    txtCheckin.Text = row.Cells["CheckInDate"].Value.ToString();
                    txtCheckout.Text = row.Cells["CheckOutDate"].Value.ToString();
                    txtChildren.Text = row.Cells["NoOfChild"].Value.ToString();
                    txtAdult.Text = row.Cells["NoOfAdult"].Value.ToString();
                    txtAdvance.Text = row.Cells["AdvancePayment"].Value.ToString();
                    txtDays.Text = row.Cells["NoOfDays"].Value.ToString();
                    txtTotal.Text = row.Cells["TotalBal"].Value.ToString();


                    dataGridView1.Visible = false;

                
            }
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int total = 0;
                total = int.Parse(txtCash.Text) - int.Parse(txtTotal.Text);
                txtChange.Text = total.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString ());
            }
        }

        private void bttnCheckout_Click(object sender, EventArgs e)
        {
            if (txtCash .Text =="")
            {
                MessageBox.Show("Please Enter the Cash");
            }
            if (con.State == ConnectionState.Open)
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand("UPDATE tblTrans set status='BillPaid' where GuestID='"+txtGuestName .Text +"' ", con);

                    cmd.ExecuteNonQuery();
                    MetroMessageBox.Show(this ,"Guest Successfully CheckedOut");


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("connection failed");
            }
        }

        private void txtGuestName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
